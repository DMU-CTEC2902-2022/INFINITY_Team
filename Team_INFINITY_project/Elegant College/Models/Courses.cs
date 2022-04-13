using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elegant_College.Models
{
    public class Course
    {
        //attributes for each course

        //get and set methods for each attribute
        public virtual int  CourseId {get; set;}
        public virtual int ConsoleId { get; set; }

        public virtual int ModuleCode { get; set; }
        public virtual String CourseName { get; set; }
        public virtual String Duration { get; set; }
        public virtual String DifficultyLevel { get; set; }
        public virtual String Fee { get; set; }
        public virtual String Faculty { get; set; }
        public virtual String FacultyExperience { get; set; }

    }
}