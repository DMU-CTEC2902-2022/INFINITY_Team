using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public class Game
    {
        public virtual int GameId { get; set; }
        public virtual int ConsoleId { get; set; }
        public virtual string Title { get; set; }
        public virtual int Condition { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual decimal OrignalPrice { get; set; }
        public virtual decimal DiscountPrice { get; set; }
        public virtual Console console { get; set; }
    }
}