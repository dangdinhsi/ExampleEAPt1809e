using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientExampleEAP.Models
{
    public class LoginModel
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Pass { get; set; }
    }
}