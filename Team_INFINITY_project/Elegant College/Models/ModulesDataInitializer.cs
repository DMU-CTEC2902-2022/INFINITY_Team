using Elegant_College.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Elegant_College.Models
{
    public class ModulessDataInitialiser :DropCreateDatabaseAlways<ModuleContext>
    {

        protected override void Seed(ModuleContext context)
        {
            Elegant_College.Models.Course course1 = new Elegant_College.Models.Course();
            course1.CourseId = 1;
            course1.CourseName = "Computer Science";
            context.Modules.Add(course1);

            Elegant_College.Models.Course course2 = new Elegant_College.Models.Course();
            course2.CourseId = 2;
            course2.CourseName = "Software Engineering";
            context.Modules.Add(course2);

            Elegant_College.Models.Course course3 = new Elegant_College.Models.Course();
            course3.CourseId = 3;
            course3.CourseName = "Cyber Security";
            context.Modules.Add(course3);

            //...................................................................

            Elegant_College.Models.Modules elegant = new Elegant_College.Models.Modules();
            elegant.ModuleCode= 1;
            elegant.Title= "C";
            elegant.ModuleCode = 55;
            elegant.Description = "35";
            elegant.Contents= "Mid";
            elegant.StaffAssociated= "£1|";
           
            context.Modules.Add(elegant);

            elegant = new Elegant_College.Models.Modules();
            elegant.ModuleCode = 1;
            elegant.Title = "C";
            elegant.ModuleCode = 55;
            elegant.Description = "35";
            elegant.Contents = "Mid";
            elegant.StaffAssociated = "£1|";

            context.Modules.Add(elegant);


            elegant = new Elegant_College.Models.Modules();
            elegant.ModuleCode = 1;
            elegant.Title = "C";
            elegant.ModuleCode = 55;
            elegant.Description = "35";
            elegant.Contents = "Mid";
            elegant.StaffAssociated = "£1|";

            context.Modules.Add(elegant);


            elegant = new Elegant_College.Models.Modules();
            elegant.ModuleCode = 1;
            elegant.Title = "C";
            elegant.ModuleCode = 55;
            elegant.Description = "35";
            elegant.Contents = "Mid";
            elegant.StaffAssociated = "£1|";

            context.Modules.Add(elegant);


            base.Seed(context);
        }
    }
}