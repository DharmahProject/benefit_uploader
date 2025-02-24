using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BenefitUploader.Helper;
using BenefitUploader.Models;
using System.Data.SqlClient;
using System.Web;
using OfficeOpenXml;
using System.Threading;
using System.Net.Mail;
using System.Net;
using System.Globalization;

namespace BenefitUploader.Controllers
{
    public class LoanMedicalsController : Controller
    {
        private readonly DbBenefitUploaderContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public LoanMedicalsController(DbBenefitUploaderContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: LoanMedicals
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoanMedicals.ToListAsync());
        }

        private bool IsSession()
        {
            if (HttpContext.Session != null)
            {
                var name = HttpContext.Session.GetString("uid");

                if (!String.IsNullOrEmpty(name))
                {
                    return true;
                }
            }

            return false;
        }


        public IActionResult Upload()
        {
            if (!IsSession())
            {
                return RedirectToAction(nameof(AuthController.SignIn), "Auth");
            }
            string webRootPath = _hostingEnvironment.WebRootPath;
            ViewData["Status"] = new List<string>();// HttpContext.Session.GetString("Status"); ;
            List<LoanMedical> reportList = new List<LoanMedical>();
            ViewData["List"] = reportList;
            return View();
        }

        [HttpPost]
        [Route("LoanMedicals/Upload")]
        public IActionResult Upload(IFormFile reportfile)
        {
            if (!IsSession())
            {
                return RedirectToAction(nameof(AuthController.SignIn), "Auth");
            }
            string folderName = "Upload";
            string webRootPath = _hostingEnvironment.WebRootPath;
            string newPath = Path.Combine(webRootPath, folderName);
            // Delete Files from Directory
            System.IO.DirectoryInfo di = new DirectoryInfo(newPath);

            if (!Directory.Exists(newPath))// Crate New Directory if not exist as per the path
            {
                Directory.CreateDirectory(newPath);
            }
            foreach (FileInfo filesDelete in di.GetFiles())
            {
                filesDelete.Delete();
            }// End Deleting files form directories

            var fiName = "Uploads" + Path.GetExtension(reportfile.FileName);
            using (var fileStream = new FileStream(Path.Combine(newPath, fiName), FileMode.Create))
            {
                reportfile.CopyTo(fileStream);
            }
            List<LoanMedical> reportList = new List<LoanMedical>();
            // Get uploaded file path with root
            string rootFolder = _hostingEnvironment.WebRootPath;
            string fileName = @"Upload\" + fiName;
            FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));
            List<string> status = new List<string>();
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
                int totalRows = workSheet.Dimension.Rows;
                for (int i = 2; i <= totalRows ; i++)
                {
                    try
                    {
                        string Nik = workSheet?.Cells[i, 1]?.Value?.ToString();
                        string Pasien = workSheet?.Cells[i, 2]?.Value?.ToString();
                        string TglAwal = workSheet?.Cells[i, 3]?.Value?.ToString();
                        string TglAkhir = workSheet?.Cells[i, 4]?.Value?.ToString();
                        string Tempat = workSheet?.Cells[i, 5]?.Value?.ToString();
                        string JenisKlaim = workSheet?.Cells[i, 6]?.Value?.ToString();
                        string Biaya = workSheet?.Cells[i, 7]?.Value?.ToString();
                        string Angsuran = workSheet?.Cells[i, 8]?.Value?.ToString();
                        string Nominal = workSheet?.Cells[i, 9]?.Value?.ToString();
                        string Periode = workSheet?.Cells[i, 10]?.Value?.ToString();
                        string Keterangan = workSheet?.Cells[i, 11]?.Value?.ToString();
                        string Remark = string.Empty;
                        string dateAwal = TglAwal.Replace(".", "").Replace("-", "").Replace("/", "");
                        string dateAkhir = TglAkhir.Replace(".", "").Replace("-", "").Replace("/", "");

                        dateAwal = string.Concat(dateAwal.Substring(2, 2), "-", dateAwal.Substring(0, 2), "-", dateAwal.Substring(4, 4));
                        dateAkhir = string.Concat(dateAkhir.Substring(2, 2), "-", dateAkhir.Substring(0, 2), "-", dateAkhir.Substring(4, 4));

                        //if (_context.LoanMedicals.Any(x => x.EmployeeID == Nik && x.Pasien == Pasien && x.TglAwalBerobat.ToString("MM-dd-yyyy") == dateAwal && x.TglAkhirBerobat.ToString("MM-dd-yyyy") == dateAkhir
                        //    && x.TempatBerobat == Tempat && x.NominalPotongan == Convert.ToDouble(Nominal).ToString("N0", CultureInfo.InvariantCulture)
                        //      && x.JenisKlaim == JenisKlaim && x.PeriodePemotongan == Periode
                        //    && x.Keterangan == Keterangan
                        //    ))
                        //{
                        //    // Exists
                        //    Remark = "Data exists";
                        //}

                        //var dupe = reportList
                        //      .Where(g => g.EmployeeID == Nik && g.Pasien == Pasien && g.TglAwalBerobat.ToString("MM-dd-yyyy") == dateAwal && g.TglAkhirBerobat.ToString("MM-dd-yyyy") == dateAkhir && g.PeriodePemotongan == Periode)
                        //      .ToList();
                        //if (dupe.Count > 0)
                        //{
                        //    Remark = "Duplicate";
                        //}
                        Employee employ = _context.Employees.Where(j => j.EmployeeID == Nik).FirstOrDefault();
                        if(employ == null)
                        {
                            Remark = "Employee doesn't exist";
                        }
                        //string PersArea = _context.Employees.Where(g => g.EmployeeID == Nik).FirstOrDefault().Location;
                        //if (PersArea != "2000")
                        //{
                        //    Remark = "Site must be 2000";
                        //}


                        LoanMedical lm = new LoanMedical();
                        lm.EmployeeID = Nik;
                        lm.Pasien = Pasien;
                        lm.TglAwalBerobat = Convert.ToDateTime(dateAwal);
                        lm.TglAkhirBerobat = Convert.ToDateTime(dateAkhir);
                        lm.TempatBerobat = Tempat;
                        lm.JenisKlaim = JenisKlaim;
                        lm.Biaya = Convert.ToDouble(Biaya).ToString("N0", CultureInfo.InvariantCulture);
                        lm.Angsuran = Angsuran;
                        lm.NominalPotongan = Convert.ToDouble(Nominal).ToString("N0", CultureInfo.InvariantCulture);
                        lm.Keterangan = Keterangan;
                        lm.PeriodePemotongan = Periode;
                        lm.CreatedBy = HttpContext.Session.GetString("uid");
                        lm.CreatedDate = DateTime.Now;
                        lm.Description = String.IsNullOrEmpty(Remark) ? "Success" : Remark;
                        lm.email_status=0;
                        reportList.Add(lm);
                    }
                    catch (Exception Ex)
                    {
                        // Exception
                    }
                }
            }
            ViewData["List"] = reportList;

            var result2 = reportList
                          .Where(g => g.Description == "Success")
                          .ToList();
            var result3 = result2.Select(a=>a.EmployeeID).Distinct().ToList();
            //var result4 = result3.GroupBy(g => g.).Distinct();
            foreach (string nik in result3)
            {

                SmtpClient client = new SmtpClient("webmail.bukitmakmur.com");
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("k2adminprod", "Hjiqfbo3Nq4JQSJOKsoi");

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("k2adminprod@bukitmakmur.com");
                mailMessage.IsBodyHtml = true;
                Employee employ = _context.Employees.Where(j => j.EmployeeID == nik).FirstOrDefault();
                var result4 = result2.Where(g => g.EmployeeID == nik).ToList();
                if (employ != null)
                {
                    if (employ.Email != null)
                    {
                        var result5 = result4.Select(g => g.PeriodePemotongan).Distinct().ToList();
                        foreach (string period in result5)
                        {
                            var result6 = result2.Where(g => g.EmployeeID == nik && g.PeriodePemotongan == period).ToList();
                            string str = "";
                            decimal dec = 0;
                            //mailMessage.To.Add("c.imantiara@gmail.com");
                            //mailMessage.To.Add("liani.susanto@bukitmakmur.com");
                            //mailMessage.To.Add("dewi.susanti@bukitmakmur.com");
                            //mailMessage.CC.Add("anik.yuli@bukitmakmur.com");
                            //mailMessage.CC.Add("dimas.triantoro@bukitmakmur.com");
                            //mailMessage.To.Add(employ.Email);
                            string gender = employ.Gender == "1" ? "Bapak " : "Ibu ";
                            string body = "<font face='calibri' size ='3'>";
                            body += " Dear " + gender + employ.Name + ",<br/> <br/>";
                            body += " Berdasarkan laporan tagihan pihak Asuransi, terdapat biaya pengobatan yang ditanggung Pekerja sebesar Rp {0} dengan rincian data sebagai berikut :<br/><br/>"
                            + "<table  border='1' border-collapse='collapse' width='100%' font-face='calibri'>" +
                            "<tr align='center' ><td>Nama Pekerja</td><td>Nama Pasien</td><td>Tanggal Awal Berobat</td><td>Tanggal Akhir Berobat</td><td>Tempat Berobat</td>"
                            + "<td>Jenis Klaim</td><td>Biaya yang ditanggung pekerja</td><td>Jumlah Angsuran</td><td>Nominal Pemotongan</td><td>Periode Mulai Pemotongan</td><td>Keterangan</td></tr> ";
                            foreach (LoanMedical lm in result6)
                            {
                                //lm. = employ.Name;
                                //list.Description = "";
                                dec += Decimal.Parse(lm.Biaya);
                                _context.LoanMedicals.Add(lm);
                                _context.SaveChanges();
                                body += "<tr  align='center' ><td>" + employ.Name + "</td><td>" + lm.Pasien + "</td><td>" + lm.TglAwalBerobat.ToString("dd.MM.yyyy") + "</td><td>" + lm.TglAkhirBerobat.ToString("dd.MM.yyyy") + "</td><td>" + lm.TempatBerobat + "</td>"
                                + "<td> " + lm.JenisKlaim + "</td><td>" + lm.Biaya + "</td><td>" + lm.Angsuran + "</td><td>" + lm.NominalPotongan + "</td><td>" + lm.PeriodePemotongan + "</td><td>" + lm.Keterangan + "</td></tr> ";
                            }
                            body += " </table><br/>";

                            body += "Biaya ini akan dipotongkan pada periode pemotongan sesuai table diatas, apabila terdapat data yang tidak sesuai mohon konfirmasi ke HR Site / HO, maksimal 7 hari setelah pemberitahuan ini dikirimkan."
                            + "<br/><br/>"

                            + "Untuk rincian biaya pengobatan dapat diakses di <b>aplikasi Asuransi Sinarmas Online</b>, menggunakan email yang terdaftar pada payroll dengan password tanggal lahir (<b>DDMMYYYY<b>)<br/><br/>"

                            + "Demikian, Terimakasih. <br/><br/> "

                            + "Salam, <br/>"
                            + "HRSC <br/>"
                            + "\"Tidak ada yang lebih berharga daripada kesehatan, mari kita menjaga kesehatan kita bersama.\" <br/></f>";
                            body = string.Format(body, Convert.ToDouble(dec).ToString("N0", CultureInfo.InvariantCulture));
                            mailMessage.Body = body;
                            mailMessage.Subject = "Loan Medical Status";
                            if (mailMessage.To.Count > 0)
                            {
                                //Task task = new Task(() => client.Send(mailMessage));
                                //task.Start();
                            }
                        }
                    }
                    else
                    {
                        foreach (LoanMedical lm in result4)
                        {
                            lm.Description = "Employee doesn't have email";
                        }
                    }
                }
                else
                {
                    foreach(LoanMedical lm in result4)
                    {
                        lm.Description = "Employee doesn't exist";
                    }
                }
            }
            return View();

        }

        public async Task<IActionResult> Download(string id)
        {
            if (id == null)
                return Content("filename not present");

            var serverPath = _hostingEnvironment.WebRootPath;

            var path = Path.Combine(
                           serverPath,
                            id);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;

            return File(memory, "application/xls", Path.GetFileName(path));
        }

        [HttpGet]
        [Route("ExportMedical")]
        public IActionResult Export()
        {
            string rootFolder = _hostingEnvironment.WebRootPath;
            string fileName = @"ExportLoanMedical.xlsx";
            byte[] fileContents;

            FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));

            using (ExcelPackage package = new ExcelPackage(file))
            {
                IList<LoanMedical> List = _context.LoanMedicals.ToList();

                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet 1");
                int totalRows = List.Count();

                worksheet.Cells[1, 1].Value = "Employee ID";
                worksheet.Cells[1, 2].Value = "Nama Pasien";
                worksheet.Cells[1, 3].Value = "Tgl Awal Berobat";
                worksheet.Cells[1, 4].Value = "Tgl Akhir Berobat";
                worksheet.Cells[1, 5].Value = "Tempat Berobat";
                worksheet.Cells[1, 6].Value = "Jenis Klaim";
                worksheet.Cells[1, 7].Value = "Biaya yang Ditanggung Pekerja";
                worksheet.Cells[1, 8].Value = "Jumlah Angsuran";
                worksheet.Cells[1, 9].Value = "Nominal Potongan";
                worksheet.Cells[1, 10].Value = "Periode Pemotongan";
                worksheet.Cells[1, 11].Value = "Keterangan";
                worksheet.Cells[1, 12].Value = "Created By";
                worksheet.Cells[1, 13].Value = "Created Date";
                int i = 0;
                for (int row = 2; row <= totalRows + 1; row++)
                {
                    worksheet.Cells[row, 1].Value = List[i].EmployeeID;
                    worksheet.Cells[row, 2].Value = List[i].Pasien;
                    worksheet.Cells[row, 3].Value = List[i].TglAwalBerobat.ToString("dd-MM-yyyy");
                    //worksheet.Cells[row, 4].Value = List[i].CutOffDate;
                    worksheet.Cells[row, 4].Value = List[i].TglAkhirBerobat.ToString("dd-MM-yyyy");
                    worksheet.Cells[row, 5].Value = List[i].TempatBerobat;
                    worksheet.Cells[row, 6].Value = List[i].JenisKlaim;
                    worksheet.Cells[row, 7].Value = List[i].Biaya;
                    worksheet.Cells[row, 8].Value = List[i].Angsuran;
                    worksheet.Cells[row, 9].Value = List[i].NominalPotongan;
                    worksheet.Cells[row, 10].Value = List[i].PeriodePemotongan;
                    worksheet.Cells[row, 11].Value = List[i].Keterangan;
                    worksheet.Cells[row, 12].Value = List[i].CreatedBy;
                    worksheet.Cells[row, 13].Value = List[i].CreatedDate.ToString("dd-MM-yyyy");
                    i++;
                }
                fileContents = package.GetAsByteArray();
                //package.Save();

            }

            return File(
               fileContents: fileContents,
               contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
               fileDownloadName: "LoanMedicals.xlsx"
           );
        }

        private bool LoanMedicalExists(int id)
        {
            return _context.LoanMedicals.Any(e => e.Id == id);
        }
    }
}
