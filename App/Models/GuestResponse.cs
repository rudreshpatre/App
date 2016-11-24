using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter your name.")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter your email address in correct format.")]
        public String Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone.")]
        public String Phone { get; set; }
        [Required(ErrorMessage = "Please make a selection.")]
        public bool? WillAttend { get; set; }
    }
}