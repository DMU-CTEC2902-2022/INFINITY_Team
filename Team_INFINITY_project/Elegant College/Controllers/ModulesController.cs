using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Elegant_College.Models;
using Elegant_College.Data;
using System.Web.Mvc;

namespace Elegant_College.Controllers
{
    public class ModulesController : Controller
    {
        private ModuleContext db = new ModuleContext();

        /*
        // getting courses
        public ActionResult Index(int? Id)
        {
            List<Course> moduleList;
            var modules = db.Modules.Include(g => g.ModuleID);
            if (Id != null)
                moduleList = modules.ToList().FindAll(p => p.ModuleID == Id); // retrieve
                                                                              //  all courses for id
            else moduleList = modules.ToList();    // Retrieving all courses

            if (moduleList.Count() == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(moduleList);
        }


        // GET: Courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Module modules = db.Modules.Find(id);

            if (modules == null)
            {
                return HttpNotFound();
            }
            return View(modules);
        }

    }*/
    }
}