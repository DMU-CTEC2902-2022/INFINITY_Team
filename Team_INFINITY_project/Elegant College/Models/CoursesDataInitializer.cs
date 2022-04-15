using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Elegant_College.Data;

namespace Elegant_College.Models
{
    public class CoursesDataInitializer : DropCreateDatabaseAlways<CoursesContext>
    {
        // data for the available courses at the college
        protected override void Seed(CoursesContext context)
        {

            Elegant_College.Models.Course course1 = new Elegant_College.Models.Course();
            course1.CourseID = 1;
            course1.CourseName = "Computer Science";
            context.Courses.Add(course1);

            Elegant_College.Models.Course course2 = new Elegant_College.Models.Course();
            course2.CourseID = 2;
            course2.CourseName = "Software Engineering";
            context.Courses.Add(course2);

            Elegant_College.Models.Course course3 = new Elegant_College.Models.Course();
            course3.CourseID = 3;
            course3.CourseName = "Cyber Security";
            context.Courses.Add(course3);

            base.Seed(context);
        }
    }
}