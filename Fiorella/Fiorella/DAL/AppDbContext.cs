using Fiorella.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiorella.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
                
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<FlowerMainText> FlowerMainText { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Banner> Banner { get; set; }

        public DbSet<Expert> Experts { get; set; }

        public DbSet<Search> Searches { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Minislide> Minislides { get; set; }

        public DbSet<Instagram> Instagrams { get; set; }

        public DbSet<Bio> Bio { get; set; }
    }

}
