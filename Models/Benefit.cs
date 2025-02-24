using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BenefitUploader.Models
{
    public class Benefit
    {

        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Employee ID")]
        public string EmployeeID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; } 
        [Display(Name = "Pers Area")]
        public string PersArea { get; set; } 
        [Display(Name = "Cut Off Date")]
        public DateTime CutOffDate { get; set; } 
        [Display(Name = "Limit Tahunan")]
        public string LimitTahunan { get; set; } 
        [Display(Name = "Klaim Dibayar")]
        public string KlaimDibayar { get; set; } 
        [Display(Name = "Estimasi Sisa Plafon")]
        public string OverPlafon { get; set; } 
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        [Display(Name = "Tahun Perobatan")]
        public string TahunPerobatan { get; set; }
    }
}
