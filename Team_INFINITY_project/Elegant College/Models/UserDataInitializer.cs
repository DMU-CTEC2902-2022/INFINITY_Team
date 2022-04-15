using Elegant_College.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Elegant_College.Models
{
    public class UserDataInitialiser : DropCreateDatabaseAlways<UserContext>
    {
        //some data for referrring 
        protected override void Seed(UserContext context)
        {

            Elegant_College.Models.User user1 = new Elegant_College.Models.User();
            user1.UserID = 1;
            user1.UserName = "Jack";
            context.Users.Add(user1);


            base.Seed(context);
        }
    }
}