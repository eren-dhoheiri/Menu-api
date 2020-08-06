using Microsoft.EntityFrameworkCore;

namespace Menu.Models
{
    public class MenuDbContext : DbContext
    {

        public MenuDbContext(DbContextOptions<MenuDbContext> options) : base(options)
        {
        }
        public DbSet<MenuItem> MenuItems { get; set; }

    }

}

