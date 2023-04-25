using Eterna.Models;
using Eterna2WithDb.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna.DAL
{
    public class EternaDbContext:DbContext
    {
        public EternaDbContext(DbContextOptions<EternaDbContext> options):base(options)
        {
        }

        public DbSet<Feature> Features { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioImages> PortfolioImage { get; set; }

    }
}
