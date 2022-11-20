using BizLand.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BizLand.DAL
{
    public class BizLandDbContext:DbContext
    {
        public BizLandDbContext(DbContextOptions<BizLandDbContext> options) : base(options)
        {

        }

        public DbSet<Features> Features { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Portfolio> Portfolio { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
    }
}
