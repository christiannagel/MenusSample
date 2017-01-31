using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenusServer.Models
{
    public class MenuCardContext : DbContext
    {
        public MenuCardContext(DbContextOptions<MenuCardContext> options)
            : base(options)
        {
        }

        public DbSet<MenuCard> MenuCards { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
    }
}
