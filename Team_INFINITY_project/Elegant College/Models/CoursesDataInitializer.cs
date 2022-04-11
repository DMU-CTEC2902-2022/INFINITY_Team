using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Courses.Data;

namespace Elegant_College.Models
{
    public class CoursesDataInitialiser : DropCreateDatabaseAlways<CoursesContext>
    {

        protected override void Seed(CoursesContext context)
        {
            Courses.Models.Console con1 = new Courses.Models.Console();
            con1.ConsoleId = 1;
            con1.ConsoleName = "Computer Science";
            context.Consoles.Add(con1);

            Courses.Models.Console con2 = new Courses.Models.Console();
            con2.ConsoleId = 2;
            con2.ConsoleName = "Software Engineering";
            context.Consoles.Add(con2);

            Courses.Models.Console con3 = new Courses.Models.Console();
            con3.ConsoleId = 3;
            con3.ConsoleName = "Cyber Security";
            context.Consoles.Add(con3);
            /*
            //...................................Models.Game game1 = new GameShop.Models.Game();
            game1.GameId = 1;
            game1.ConsoleId = 1; // Xbox
            game1.Title = "Game 4";
            game1.OrignalPrice = 55;
            game1.DiscountPrice = 35;
            game1.ReleaseDate = Convert.ToDateTime("1/1/2010");
            game1.Condition = 1;
            game1.console = con1;
            context.Games.Add(game1);

            game1 = new GameShop.Models.Game();
            game1.GameId = 2;
            game1.ConsoleId = 1; // Xbox
            game1.Title = "Game 2";
            game1.OrignalPrice = 105;
            game1.DiscountPrice = 75;
            game1.ReleaseDate = Convert.ToDateTime("1/1/2015");
            game1.Condition = 1;
            game1.console = con1;
            context.Games.Add(game1);

            game1 = new GameShop.Models.Game();
            game1.GameId = 3;
            game1.ConsoleId = 1; // Xbox
            game1.Title = "Game 12";
            game1.OrignalPrice = 90;
            game1.DiscountPrice = 75;
            game1.ReleaseDate = Convert.ToDateTime("1/1/2015");
            game1.Condition = 1;
            game1.console = con1;
            context.Games.Add(game1);

            game1 = new GameShop.Models.Game();
            game1.GameId = 4;
            game1.ConsoleId = 2; // PlayStation
            game1.Title = "Game 60";
            game1.OrignalPrice = 55;
            game1.DiscountPrice = 15;
            game1.ReleaseDate = Convert.ToDateTime("1/1/2015");
            game1.Condition = 1;
            game1.console = con2;
            context.Games.Add(game1);

            base.Seed(context);*/
        }
    }
}
