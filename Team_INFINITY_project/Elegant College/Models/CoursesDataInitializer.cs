using Elegant_College.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Elegant_College.Models
{
    public class CoursesDataInitialiser :DropCreateDatabaseAlways<CoursesContext>
    {
    }
}