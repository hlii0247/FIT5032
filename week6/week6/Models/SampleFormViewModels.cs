using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
namespace week6.Models
{
    public class SampleFormViewModels
    {
    }

    public class FormOneViewModel
    {
        [Required]
        [Display(Name = "UserName")]
        
        public string UserName { get; set; }
        [Required]  
        [Display(Name = "PassWord")] 
        public string PassWord { get; set; }
    }
}