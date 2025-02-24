using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BenefitUploader.Models
{
    public partial class Employee
    {
        public Int64 Id { get; set; }
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string AdAccount { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string EmploymentStatus { get; set; }
        public string Location { get; set; }
    }
}
