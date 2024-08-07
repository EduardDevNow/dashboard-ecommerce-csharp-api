using Microsoft.EntityFrameworkCore;

namespace DashboardEcommerce.DataAccess.Entities;

public partial class DashboardEcommerceDbContext: DbContext
{
    public DashboardEcommerceDbContext(DbContextOptions<DashboardEcommerceDbContext> options) : base(options)
    { }

    public DbSet<Status> statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("Sql:ConnectionString"));
    }
}