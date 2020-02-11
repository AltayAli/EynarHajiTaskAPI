using EynarHajiTask.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace EynarHajiTask.Infrastructur
{
    public static class DataInitializer
    {
        public static void Seed(IServiceScope scope)
        {
            using(var db = scope.ServiceProvider.GetService<UserDBContext>())
            {
                if (!db.Users.Any())
                {
                    db.Users.Add(new User
                    {
                        Name="FirstUser",
                        Email = "firstuser@gmail.com",
                        Password = Crypto.HashPassword("first123")
                    });
                    db.SaveChanges();
                }
            }
        }
    }
}
