using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class Customer
    {
        [Required(ErrorMessage="Please enter your name")]
        public string name { get; set; }

        [EmailAddress]
        public string email { get; set; }
    }
}