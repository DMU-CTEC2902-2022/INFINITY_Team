using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elegant_College.Models
{
    public class Courses
    {

        public virtual int  CoursesID {get; set;}
        public virtual int ConsoleID { get; set; }

        public virtual int ModuleCode { get; set; }
        public virtual String CourseName { get; set; }
        public virtual String Duration { get; set; }
        public virtual String DifficultyLevel { get; set; }
        public virtual String Fee { get; set; }
        public virtual String Faculty { get; set; }
        public virtual String FacultyExperience { get; set; }

    }
}