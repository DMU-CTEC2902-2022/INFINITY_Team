using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elegant_College.Models
{
    public class User
    {
        public int UserID { get; set; }
        [DisplayName("User Name")]
        [Required{ErrorMessage = "This field cannot be null")]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required")]

        public string Password { get; set; }
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Comapre("Password")]
        public string ConfirmPassword { get; set; }
        public bool Admin { get; set; }
    }
}