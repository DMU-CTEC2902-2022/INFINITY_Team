using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elegant_College.Models
{
    public partial class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool Admin { get; set; }
    }
}