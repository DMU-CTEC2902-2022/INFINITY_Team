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
            module1.ModuleTitle = "Scala Programming";
            module1.ModuleDescription = "Learn the multi paradigm programming language which supports both object orientated and functional programming";
            module1.ModuleContents = "75% Coursework 25% Exam";
            module1.StaffAssociated = "Ann Lawlor";
            context.Modules.Add(module1);

            Elegant_College.Models.Modules module2 = new Elegant_College.Models.Modules();
            module2.ModuleID = 2;
            module2.CourseID = 1;
            module2.ModuleCode = "COS1920";
            module2.ModuleTitle = "Database Management";
            module2.ModuleDescription = "Learn the management of data in databases using SQL";
            module2.ModuleContents = "50% Coursework 50% Exam";
            module2.StaffAssociated = "Mohammed";
            context.Modules.Add(module2);

            Elegant_College.Models.Modules module3 = new Elegant_College.Models.Modules();
            module3.ModuleID = 3;
            module3.CourseID = 1;
            module3.ModuleCode = "COS2905";
            module3.ModuleTitle = "Object Orientated Programming (Java)";
            module3.ModuleDescription = "Build a retro game using JavaScript";
            module3.ModuleContents = "80% Coursework 20% Exam";
            module3.StaffAssociated = "Raj Patel";
            context.Modules.Add(module3);

            Elegant_College.Models.Modules module4 = new Elegant_College.Models.Modules();
            module4.ModuleID = 4;
            module4.CourseID = 1;
            module4.ModuleCode = "COS29010";
            module4.ModuleTitle = "Database Management";
            module4.ModuleDescription = "The use of SQL";
            module4.ModuleContents = "75% Coursework 25% Exam";
            module1.StaffAssociated = "Usama Mannai";

            context.Modules.Add(module4);

            Elegant_College.Models.Modules module5 = new Elegant_College.Models.Modules();
            module5.ModuleID = 5;
            module5.CourseID = 1;
            module5.ModuleCode = "COS3911";
            module5.ModuleTitle = "Mobile Application";
            module5.ModuleDescription = "The development of software on protable hardware";
            module5.ModuleContents = "100% Coursework";
            module5.StaffAssociated = "Ann Lawlor";
            context.Modules.Add(module5);

            Elegant_College.Models.Modules module6 = new Elegant_College.Models.Modules();
            module6.ModuleID = 6;
            module6.CourseID = 1;
            module6.ModuleCode = "IMAT3611";
            module6.ModuleTitle = "Computer Ethics and Privacy";
            module6.ModuleDescription = "Review the thical implications of computers in todays society";
            module6.ModuleContents = "100% Coursework";
            module6.StaffAssociated = "Kerry Ann";
            context.Modules.Add(module6);

            Elegant_College.Models.Modules module7 = new Elegant_College.Models.Modules();
            module7.ModuleID = 7;
            module7.CourseID = 1;
            module7.ModuleCode = "COS3451";
            module7.ModuleTitle = "Development Project";
            module7.ModuleDescription = "Create a system based on a project of your choice";
            module7.ModuleContents = "75% Coursework 25% Exam";
            module7.StaffAssociated = "Abdullah";
            context.Modules.Add(module7);

            Elegant_College.Models.Modules module8 = new Elegant_College.Models.Modules();
            module8.ModuleID = 8;
            module8.CourseID = 2;
            module8.ModuleCode = "SE3906";
            module8.ModuleTitle = "Interaction Design";
            module8.ModuleDescription = "The analysis of design components within computing";
            module8.ModuleContents = "100% Exam";
            module8.StaffAssociated = "Matthew Dean";
            context.Modules.Add(module8);

            Elegant_College.Models.Modules module9 = new Elegant_College.Models.Modules();
            module9.ModuleID = 9;
            module9.CourseID = 2;
            module9.ModuleCode = "SE3410";
            module9.ModuleTitle = "Web Application Penetration Testing";
            module9.ModuleDescription = "Building Web applications and testing them";
            module9.ModuleContents = "50% Coursework 50% Exam";
            module9.StaffAssociated = "Usama Mannai";
            context.Modules.Add(module9);

            Elegant_College.Models.Modules module10 = new Elegant_College.Models.Modules();
            module10.ModuleID = 10;
            module10.CourseID = 2;
            module10.ModuleCode = "SE3406";
            module10.ModuleTitle = "Fuzzy Logic & Knowledge Based Systems";
            module10.ModuleDescription = "The analysis of knowledge based system";
            module10.ModuleContents = "100% Coursework";
            module10.StaffAssociated = "Katherine Flick";
            context.Modules.Add(module10);

            Elegant_College.Models.Modules module11 = new Elegant_College.Models.Modules();
            module11.ModuleID = 11;
            module11.CourseID = 2;
            module11.ModuleCode = "SE3613";
            module11.ModuleTitle = "Data Mining";
            module11.ModuleDescription = "The study of data mining";
            module11.ModuleContents = "100% Coursework";
            module11.StaffAssociated = "Oluf oberski";
            context.Modules.Add(module11);

            Elegant_College.Models.Modules module12 = new Elegant_College.Models.Modules();
            module12.ModuleID = 12;
            module12.CourseID = 2;
            module12.ModuleCode = "SE3614";
            module12.ModuleTitle = "Big Data & Business Models";
            module12.ModuleDescription = "Researching the data behind businesses and computing";
            module12.ModuleContents = "60% Coursework 40% Exam";
            module12.StaffAssociated = "Paulina Grace";
            context.Modules.Add(module12);

            Elegant_College.Models.Modules module13 = new Elegant_College.Models.Modules();
            module13.ModuleID = 13;
            module13.CourseID = 2;
            module13.ModuleCode = "IMAT3611";
            module13.ModuleTitle = "Computer Ethics and Privacy";
            module13.ModuleDescription = "The study of ethical implications in computing";
            module13.ModuleContents = "100% Coursework";
            module13.StaffAssociated = "Regina Toth";
            context.Modules.Add(module13);

            Elegant_College.Models.Modules module14 = new Elegant_College.Models.Modules();
            module14.ModuleID = 14;
            module14.CourseID = 2;
            module14.ModuleCode = "SE3451";
            module14.ModuleTitle = "Development Project";
            module14.ModuleDescription = "Final year project to create a system based on anything you want";
            module14.ModuleContents = "100% Coursework";
            module14.StaffAssociated = "Ruchika Kapoor";
            context.Modules.Add(module14);



            Elegant_College.Models.Modules module15 = new Elegant_College.Models.Modules();
            module15.ModuleID = 15;
            module15.CourseID = 3;
            module15.ModuleCode = "SE3901";
            module15.ModuleTitle = "C Programming";
            module15.ModuleDescription = "Build a system using the C language";
            module15.ModuleContents = "100% Coursework";
            module15.StaffAssociated = "David Fogg";
            context.Modules.Add(module15);

            Elegant_College.Models.Modules module16 = new Elegant_College.Models.Modules();
            module16.ModuleID = 16;
            module16.CourseID = 3;
            module16.ModuleCode = "SE3902";
            module16.ModuleTitle = "Computer Law and Cyber Secuirty Management";
            module16.ModuleDescription = "The study of security related to computers and laws realted to security";
            module16.ModuleContents = "50% Coursework 50% Exam";
            module16.StaffAssociated = "Ann Lawlor";
            context.Modules.Add(module16);

            Elegant_College.Models.Modules module17 = new Elegant_College.Models.Modules();
            module17.ModuleID = 17;
            module17.CourseID = 3;
            module17.ModuleCode = "SE3903";
            module17.ModuleTitle = "Linux Security";
            module17.ModuleDescription = "Use a new operating system for the study of security";
            module17.ModuleContents = "100% Exam";
            module17.StaffAssociated = "Qadri Mohammed";
            context.Modules.Add(module17);

            Elegant_College.Models.Modules module18 = new Elegant_College.Models.Modules();
            module18.ModuleID = 18;
            module18.CourseID = 3;
            module18.ModuleCode = "SE3904";
            module18.ModuleTitle = "Cyber Threat Intelligence and Incident Response";
            module18.ModuleDescription = "Study the threats related to computers and how they are treated";
            module18.ModuleContents = "100% Coursework";
            module18.StaffAssociated = "Ann Lawlor";
            context.Modules.Add(module18);

            Elegant_College.Models.Modules module19 = new Elegant_College.Models.Modules();
            module19.ModuleID = 19;
            module19.CourseID = 3;
            module19.ModuleCode = "SE3905";
            module19.ModuleTitle = "Malware Analysis";
            module19.ModuleDescription = "The analysis of harmful program in computers";
            module19.ModuleContents = "50% Coursework 50% Exam";
            module19.StaffAssociated = "Kathrine Richardson";
            context.Modules.Add(module19);

            Elegant_College.Models.Modules module20 = new Elegant_College.Models.Modules();
            module20.ModuleID = 20;
            module20.CourseID = 3;
            module20.ModuleCode = "IMAT3611";
            module20.ModuleTitle = "Computer Ethics and Privacy";
            module20.ModuleDescription = "The stufy of ethics in computers";
            module20.ModuleContents = "100% Coursework";
            module20.StaffAssociated = "Harpreet Singh";
            context.Modules.Add(module20);

            Elegant_College.Models.Modules module21 = new Elegant_College.Models.Modules();
            module21.ModuleID = 21;
            module21.CourseID = 3;
            module21.ModuleCode = "SE3451";
            module21.ModuleTitle = "Development Project";
            module21.ModuleDescription = "Fina year project to create a system of your choice";
            module21.ModuleContents = "100% Coursework";
            module21.StaffAssociated = "Usama Mannai";
            context.Modules.Add(module21);


            base.Seed(context);
        }
    }
}