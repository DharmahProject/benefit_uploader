using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BenefitUploader.Models
{
    public class LoanMedical
    {

        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Employee ID")]
        public string EmployeeID { get; set; }
        [Display(Name = "Nama Pasien")]
        public string Pasien { get; set; }
        [Display(Name = "Tgl Awal Berobat")]
        public DateTime TglAwalBerobat { get; set; }
        [Display(Name = "Tgl Akhir Berobat")]
        public DateTime TglAkhirBerobat { get; set; }
        [Display(Name = "Tempat Berobat")]
        public string TempatBerobat { get; set; }
        [Display(Name = "Jenis Klaim")]
        public string JenisKlaim { get; set; }
        [Display(Name = "Biaya yang ditanggung pekerja")]
        public string Biaya { get; set; }
        [Display(Name = "Jumlah Angsuran")]
        public string Angsuran { get; set; }
        [Display(Name = "Nominal Potongan")]
        public string NominalPotongan { get; set; }
        [Display(Name = "Periode Mulai Pemotongan")]
        public string PeriodePemotongan { get; set; }
        [Display(Name = "Keterangan")]
        public string Keterangan { get; set; }
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public int email_status { get; set; }
    }
}
