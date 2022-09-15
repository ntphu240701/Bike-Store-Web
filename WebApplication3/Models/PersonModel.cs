using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class PersonModel
    {
        [Display(Name = "Personal Details:")]
        [Required(ErrorMessage = "Personal Details is required.")]
        [AllowHtml]
        public string PersonalDetails { get; set; }
    }
}