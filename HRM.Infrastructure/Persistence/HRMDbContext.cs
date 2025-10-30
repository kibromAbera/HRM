using HRM.Domain.Entities;
using HRM.Domain.Entities.ExceedERP.Domain.HRM.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRM.Infrastructure.Persistence
{
    public class HRMDbContext : DbContext
    {
        public HRMDbContext(DbContextOptions<HRMDbContext> options) : base(options) { }

        public DbSet<PersonEmployee> Employees => Set<PersonEmployee>();
        public DbSet<Placement> Placements => Set<Placement>();
    }
}
