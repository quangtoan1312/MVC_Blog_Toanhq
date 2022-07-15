using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MVC_Blog_Toanhq.Models
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("BlogConnectionString")
        {

        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
