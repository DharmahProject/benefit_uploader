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
    public class BenefitController : Controller
    {
        private readonly DbBenefitUploaderContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public BenefitController(DbBenefitUploaderContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
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

        // GET: Benefits
        public async Task<IActionResult> Index()
        {
            return View(await _context.Benefits.ToListAsync());
        }

        public IActionResult Upload()
        {
            if (!IsSession())
            {
                return RedirectToAction(nameof(AuthController.SignIn), "Auth");
            }
            string webRootPath = _hostingEnvironment.WebRootPath;
            ViewData["Status"] = new List<string>();// HttpContext.Session.GetString("Status"); ;
            List<Benefit> reportList = new List<Benefit>();
            ViewData["List"] = reportList;
            return View();
        }

        [HttpPost]
        [Route("Benefit/Upload")]
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

            var fiName = "Upload" + Path.GetExtension(reportfile.FileName);
            using (var fileStream = new FileStream(Path.Combine(newPath, fiName), FileMode.Create))
            {
                reportfile.CopyTo(fileStream);
            }
            List<Benefit> reportList = new List<Benefit>();
            // Get uploaded file path with root
            string rootFolder = _hostingEnvironment.WebRootPath;
            string fileName = @"Upload\" + fiName;
            FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));
            List<string> status = new List<string>();
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets[0];
                int totalRows = workSheet.Dimension.Rows;
                for (int i = 2; i <= totalRows + 1; i++)
                {
                    try
                    {
                        string TahunPerobatan = workSheet?.Cells[i, 1]?.Value?.ToString();
                        string Nik = workSheet?.Cells[i, 2]?.Value?.ToString();
                        string Name = workSheet?.Cells[i, 3]?.Value?.ToString();
                        string PersArea = workSheet?.Cells[i, 4]?.Value?.ToString();
                        string CutOffDate = workSheet?.Cells[i, 5]?.Value?.ToString();
                        string LimitTahunan = workSheet?.Cells[i, 6]?.Value?.ToString();
                        string KlaimDibayar = workSheet?.Cells[i, 7]?.Value?.ToString();
                        string OverPlafon = workSheet?.Cells[i, 8]?.Value?.ToString();
                        string Remark = string.Empty;
                        string date = CutOffDate.Replace(".", "");
                        date = date.Replace("-", "");
                        date = date.Replace("/", "");
                        date = string.Concat(date.Substring(2, 2), "-", date.Substring(0, 2), "-", date.Substring(4, 4));

                        //if (_context.Benefits.Any(x => x.EmployeeID == Nik && x.PersArea == PersArea && x.CutOffDate.ToString("MM-dd-yyyy") == date
                        //    && x.KlaimDibayar == Convert.ToDouble(KlaimDibayar).ToString("N", CultureInfo.InvariantCulture)
                        //    && x.LimitTahunan == Convert.ToDouble(LimitTahunan).ToString("N", CultureInfo.InvariantCulture)
                        //    && x.OverPlafon == Convert.ToDouble(OverPlafon).ToString("N", CultureInfo.InvariantCulture)
                        //    ))
                        //{
                        //    // Exists
                        //    Remark = "Data exists";
                        //}

                        //var dupe = reportList
                        //      .Where(g => g.EmployeeID == Nik && g.PersArea == PersArea && g.CutOffDate.ToString("MM-dd-yyyy") == date)
                        //      .ToList();
                        //if (dupe.Count > 0)
                        //{
                        //    Remark = "Duplicate";
                        //}
                        //if (PersArea != "2000")
                        //{
                        //    Remark = "Site must be 2000";
                        //}


                        Benefit ben = new Benefit();
                        ben.EmployeeID = Nik;
                        ben.Name = Name;
                        ben.PersArea = PersArea;

                        ben.CutOffDate = Convert.ToDateTime(date);
                        ben.LimitTahunan = Convert.ToDouble(LimitTahunan).ToString("N0", CultureInfo.InvariantCulture);
                        ben.KlaimDibayar = Convert.ToDouble(KlaimDibayar).ToString("N0", CultureInfo.InvariantCulture);
                        ben.OverPlafon = Convert.ToDouble(OverPlafon).ToString("N0", CultureInfo.InvariantCulture);
                        ben.CreatedBy = HttpContext.Session.GetString("uid");
                        ben.CreatedDate = DateTime.Now;
                        ben.Description = String.IsNullOrEmpty(Remark) ? "Success" : Remark;
                        ben.TahunPerobatan = TahunPerobatan;
                        reportList.Add(ben);
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
            foreach (Benefit list in result2)
            {

                SmtpClient client = new SmtpClient("webmail.bukitmakmur.com");
                client.UseDefaultCredentials = false;
                //client.Credentials = new NetworkCredential("k2adminprod", "Hjiqfbo3Nq4JQSJOKsoi");
                client.Credentials = new NetworkCredential("hrservicecenter", "Bumabisa20@)");

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("hrservicecenter@bukitmakmur.com");
                //mailMessage.From = new MailAddress("k2adminprod@bukitmakmur.com");
                mailMessage.IsBodyHtml = true;
                Employee employ = _context.Employees.Where(j => j.EmployeeID == list.EmployeeID).FirstOrDefault();
                if (employ != null)
                {
                    list.Name = employ.Name.Replace(".","");
                    //list.Description = "";
                    _context.Benefits.Add(list);
                    _context.SaveChanges();
                    //mailMessage.To.Add("cahya.imantiara@bukitmakmur.com");
                    //mailMessage.To.Add("liani.susanto@bukitmakmur.com");
                    //mailMessage.To.Add("dewi.susanti@bukitmakmur.com");
                    mailMessage.CC.Add("anik.yuli@bukitmakmur.com");
                    mailMessage.CC.Add("dimas.triantoro@bukitmakmur.com");
                    //mailMessage.Bcc.Add("cahya.imantiara@bukitmakmur.com");
                    mailMessage.To.Add(employ.Email);
                    string gender = employ.Gender == "1" ? "Bapak " : "Ibu ";
                    string body = "<font face='calibri' size ='3'>";
                    body += " Dear " + gender + employ.Name + ",<br/> <br/>";
                    body += " Sesuai dengan laporan klaim rawat jalan per " + list.CutOffDate.ToString("dd MMMM yyyy") + " yang diterima dari Asuransi, maka kami sampaikan estimasi sisa plafon Rawat Jalan sebagai berikut:<br/><br/>"
                    + "<table  border='1' border-collapse='collapse' width=' 100%' font-face ='calibri' font-size='3' align='center'><tr align='center'><td>Tahun Perobatan</td><td>NIK</td><td>Nama Karyawan</td><td>Plafon Rawat Jalan</td><td>Estimasi Penggunaan Plafon</td><td>Estimasi Sisa Plafon</td></tr> "
                    + "<tr align='center'><td> " + list.TahunPerobatan + "</td><td> " + list.EmployeeID + "</td><td>" + employ.Name + "</td><td>" + list.LimitTahunan + "</td><td>" + list.KlaimDibayar + "</td><td>" + list.OverPlafon + "</td></tr> </table><br/>"

                    + @"<b>Note :</b><br/>
                        • Sisa Plafon bersifat belum final karena sebagian klaim masih dilakukan verifikasi dokumen sehingga dimungkinkan jumlah claim bisa berubah.<br/>
                        • Informasi yang tertera berdasarkan tagihan dari RS / Klinik yang telah masuk ke ASM<br/>
                        • Detail klaim bisa diakses melalui <b>aplikasi Asuransi Sinar Mas Online</b> <br/>
                        • Apabila ada hal yang ingin dikonfirmasi ulang dapat menghubungi HR Site atau HR HO<br/><br/>"
                    //+ "*Sisa Plafon bersifat belum final karena sebagian klaim masih dilakukan verifikasi dokumen sehingga dimungkinkan jumlah claim bisa berubah.<br/><br/>"

                    //+ "Detail klaim bisa diakses melalui <b>aplikasi Asuransi Sinar Mas Online</b> <br/><br/>"

                    + "Terimakasih. <br/><br/> "

                    + "Salam, <br/>"
                    + "HRSC <br/>"
                    + "\"Tidak ada yang lebih berharga daripada kesehatan, mari kita menjaga kesehatan kita bersama.\" <br/></f>";
                    mailMessage.Body = body;
                    mailMessage.Subject = "Benefit Status";
                    if (mailMessage.To.Count > 0)
                    {
                        Task task = new Task(() => client.Send(mailMessage));
                        task.Start();
                    }

                }
                else
                {
                    list.Description = "Employee doesn't exist";
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
        [Route("ExportBenefit")]
        public IActionResult Export()
        {
            string rootFolder = _hostingEnvironment.WebRootPath;
            string fileName = @"ExportBenefit.xlsx";
            byte[] fileContents;

            FileInfo file = new FileInfo(Path.Combine(rootFolder, fileName));

            using (ExcelPackage package = new ExcelPackage(file))
            {
                IList<Benefit> List = _context.Benefits.ToList();

                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet 1");
                int totalRows = List.Count();

                worksheet.Cells[1, 1].Value = "Employee ID";
                worksheet.Cells[1, 2].Value = "Name";
                worksheet.Cells[1, 3].Value = "Pers Area";
                worksheet.Cells[1, 4].Value = "Cut Off Date";
                worksheet.Cells[1, 5].Value = "Limit Tahunan";
                worksheet.Cells[1, 6].Value = "Klaim Dibayar";
                worksheet.Cells[1, 7].Value = "Sisa Plafon";
                worksheet.Cells[1, 8].Value = "Created By";
                worksheet.Cells[1, 9].Value = "Created Date";
                int i = 0;
                for (int row = 2; row <= totalRows + 1; row++)
                {
                    worksheet.Cells[row, 1].Value = List[i].EmployeeID;
                    worksheet.Cells[row, 2].Value = List[i].Name;
                    worksheet.Cells[row, 3].Value = List[i].PersArea;
                    //worksheet.Cells[row, 4].Value = List[i].CutOffDate;
                    worksheet.Cells[row, 4].Value = List[i].CutOffDate.ToString("dd-MM-yyyy");
                    worksheet.Cells[row, 5].Value = List[i].LimitTahunan;
                    worksheet.Cells[row, 6].Value = List[i].KlaimDibayar;
                    worksheet.Cells[row, 7].Value = List[i].OverPlafon;
                    worksheet.Cells[row, 8].Value = List[i].CreatedBy;
                    worksheet.Cells[row, 9].Value = List[i].CreatedDate.ToString("dd-MM-yyyy");
                    i++;
                }
                fileContents = package.GetAsByteArray();
                //package.Save();

            }

            return File(
               fileContents: fileContents,
               contentType: "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
               fileDownloadName: "SisaPlafon.xlsx"
           );
        }

    }

}
