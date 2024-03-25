using FormulaOneAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FormulaOneAPI.Data
{
    public class FormulaOneDbContext : DbContext
    {
        public FormulaOneDbContext(DbContextOptions<FormulaOneDbContext> options) : base(options)
        {
        }

        public DbSet<Circuit> Circuits { get; set; }
        public DbSet<Constructor> Constructors { get; set; }
        public DbSet<ConstructorResult> ConstructorResults { get; set; }
        public DbSet<ConstructorStanding> ConstructorStandings { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverStanding> DriverStandings { get; set; }
        public DbSet<LapTime> LapTimes { get; set; }
        public DbSet<PitStop> PitStops { get; set; }
        public DbSet<Qualifying> Qualifyings { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<SprintResult> SprintResults { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
