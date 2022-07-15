using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVC_Blog_Toanhq.Models;

namespace MVC_Blog_Toanhq.Data
{
    public class MVC_Blog_ToanhqContext : DbContext
    {
        public MVC_Blog_ToanhqContext (DbContextOptions<MVC_Blog_ToanhqContext> options)
            : base(options)
        {
        }

        public DbSet<MVC_Blog_Toanhq.Models.Blog> Blog { get; set; }
    }
}
