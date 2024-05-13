using AspIntro_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AspIntro_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }

    }
}
