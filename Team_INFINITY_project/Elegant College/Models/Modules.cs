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
        public virtual int ModuleCode{ get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string Contents { get; set; }
        public virtual string StaffAssociated { get; set; }
        
    }
}