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
        public virtual int CourseID { get; set; }
        public virtual string CourseName { get; set; }
        public virtual decimal CoursePrice { get; set; }
    }
}