using Elegant_College.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Elegant_College.Models
{
    public class ModulessDataInitialiser : DropCreateDatabaseAlways<ModuleContext>
    {

        protected override void Seed(ModuleContext context)
        {
            Elegant_College.Models.Modules module1 = new Elegant_College.Models.Modules();
            module1.ModuleID = 1;
            module1.CourseID = 1;
            module1.ModuleCode = "COS1903";
            module1.ModuleDescription = "Learn the multi paradigm programming language which supports both object orientated and functional programming";
            module1.ModuleContents = "75% Coursework 25% Exam";
            context.Modules.Add(module1);
           
            base.Seed(context);
        }
    }
}