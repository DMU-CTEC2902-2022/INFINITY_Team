using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GameShop.Data;

namespace GameShop.Models
{
    public class GameShopDataInitialiser : DropCreateDatabaseAlways<GameContext>
    {

        protected override void Seed(GameContext context)
        {
            GameShop.Models.Console con1 = new GameShop.Models.Console();
            con1.ConsoleId = 1;
            con1.ConsoleName = "Xbox";
            context.Consoles.Add(con1);

            GameShop.Models.Console con2 = new GameShop.Models.Console();
            con2.ConsoleId = 2;
            con2.ConsoleName = "PlayStation";
            context.Consoles.Add(con2);

            GameShop.Models.Console con3 = new GameShop.Models.Console();
            con3.ConsoleId = 3;
            con3.ConsoleName = "Nintendo switch";
            context.Consoles.Add(con3);

            //...................................................................

            GameShop.Models.Game game1 = new GameShop.Models.Game();
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

            base.Seed(context);
        }
    }
}
