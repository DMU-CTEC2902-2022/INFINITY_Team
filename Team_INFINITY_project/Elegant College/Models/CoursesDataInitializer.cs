using Elegant_College.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Elegant_College.Models
{
    public class CoursesDataInitialiser :DropCreateDatabaseAlways<CourseContext>
    {

        protected override void Seed(CourseContext context)
        {
            Elegant_College.Models.Console con1 = new Elegant_College.Models.Console();
            con1.ConsoleId = 1;
            con1.ConsoleName = "Xbox";
            context.Consoles.Add(con1);

            Elegant_College.Models.Console con2 = new Elegant_College.Models.Console();
            con2.ConsoleId = 2;
            con2.ConsoleName = "PlayStation";
            context.Consoles.Add(con2);

            Elegant_College.Models.Console con3 = new Elegant_College.Models.Console();
            con3.ConsoleId = 3;
            con3.ConsoleName = "Nintendo switch";
            context.Consoles.Add(con3);

            //...................................................................

            Elegant_College.Models.Course elegant = new Elegant_College.Models.Course();
            elegant.CourseId = 1;
            elegant.ConsoleId = 1; // Xbox
            elegant.CourseName = "Game 4";
            elegant.ModuleCode = 55;
            elegant.Duration = "35";
            elegant.DifficultyLevel= "Mid";
            elegant.Fee = "£1|";
            elegant.FacultyExperience= "Mid";
            context.Courses.Add(elegant);

            elegant = new Elegant_College.Models.Course();
            elegant.CourseId = 1;
            elegant.ConsoleId = 1; // Xbox
            elegant.CourseName = "Game 4";
            elegant.ModuleCode = 55;
            elegant.Duration = "35";
            elegant.DifficultyLevel = "Mid";
            elegant.Fee = "£1|";
            elegant.FacultyExperience = "Mid";
            context.Courses.Add(elegant);


            elegant = new Elegant_College.Models.Course();
            elegant.CourseId = 1;
            elegant.ConsoleId = 1; // Xbox
            elegant.CourseName = "Game 4";
            elegant.ModuleCode = 55;
            elegant.Duration = "35";
            elegant.DifficultyLevel = "Mid";
            elegant.Fee = "£1|";
            elegant.FacultyExperience = "Mid";
            context.Courses.Add(elegant);


            elegant = new Elegant_College.Models.Course();
            elegant.CourseId = 1;
            elegant.ConsoleId = 1; // Xbox
            elegant.CourseName = "Game 4";
            elegant.ModuleCode = 55;
            elegant.Duration = "35";
            elegant.DifficultyLevel = "Mid";
            elegant.Fee = "£1|";
            elegant.FacultyExperience = "Mid";
            context.Courses.Add(elegant);


            base.Seed(context);
        }
    }
}