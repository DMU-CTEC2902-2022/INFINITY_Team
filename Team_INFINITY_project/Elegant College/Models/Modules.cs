using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elegant_College.Models
{
    public class Modules
    {
        //attributes for modules

        //get and set methods for each attribute
        public virtual int ModuleID { get; set; }
        public virtual int CourseID {get; set;}
        public virtual string ModuleTitle { get; set; }
        public virtual string ModuleCode { get; set; }
        public virtual string ModuleDescription { get; set; }
        public virtual string ModuleContents { get; set; }
        public virtual Course course { get; set; }

     }
}