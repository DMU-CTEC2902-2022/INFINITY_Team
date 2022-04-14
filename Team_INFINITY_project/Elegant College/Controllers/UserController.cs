using Elegant_College.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Elegant_College.Controllers
{
    public class UserController
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string PhoneNo { get; set; }

    }
}