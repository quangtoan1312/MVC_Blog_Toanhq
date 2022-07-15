using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVC_Blog_Toanhq.Data;
using System;
using System.Linq;

namespace MVC_Blog_Toanhq.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVC_Blog_ToanhqContext(
                serviceProvider.GetRequiredService<DbContextOptions<MVC_Blog_ToanhqContext>>()))
            {
                // Look for any blogs.
                if (context.Blog.Any())
                {
                    return;   // DB has been seeded
                }

                //context.Blog.AddRange(
                //    new Blog
                //    {
                //        Title = "ABC",
                //        Description = "abc",
                //        Detail = "abc",
                //        Positions = {"1"},
                //        IsPublic = "Yes",
                //        Category = ChooseCategory.Kinhtế,
                //        PublicDate = DateTime.Parse("2022-1-1")
                //    },

                //    new Blog
                //    {
                //        Title = "DEF",
                //        Description = "def",
                //        Detail = "def",
                //        Position = null,
                //        IsPublic = "Yes",
                //        Category = ChooseCategory.Chínhtrị,
                //        PublicDate = DateTime.Parse("2022-2-2")
                //    },

                //    new Blog
                //    {
                //        Title = "GHI",
                //        Description = "ghi",
                //        Detail = "ghi",
                //        Position = null,
                //        IsPublic = "Yes",
                //        Category = ChooseCategory.Quânsự,
                //        PublicDate = DateTime.Parse("2022-3-3")
                //    },

                //    new Blog
                //    {
                //        Title = "JKL",
                //        Description = "jkl",
                //        Detail = "jkl",
                //        Position = null,
                //        IsPublic = "Yes",
                //        Category = ChooseCategory.Quânsự,
                //        PublicDate = DateTime.Parse("2022-4-4")
                //    }
                //);
                context.SaveChanges();
            }
        }
    }
}
