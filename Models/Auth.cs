﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BenefitUploader.Models
{
    public class Auth
    {

        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; } 
    }
}
