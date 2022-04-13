using Elegant_College.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elegant_College.Controllers
{
    public class UserController
    {
        public ActionResult AddEdit(int id = 0)
        {
            User user = new User();
            return View(user);

        }


    }
}