using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab_25_ValidateUserInformation.Models
{
    public class Validator
    {
        [Required(ErrorMessage = "Name: Non empty, characters, up to 20 characters.")]
        [StringLength(20)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Age: Only Integers, Values from 1 to 150")]
        [RegularExpression("^(0?[1-9]|[1-9][0-9])$", ErrorMessage = "Enter a valid age(1 to 150)")]
        public int Age { get; set; }
       // public string EmailID { get; set; }
    }
}