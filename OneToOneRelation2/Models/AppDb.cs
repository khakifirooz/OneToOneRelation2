using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace OneToOneRelation2.Models;

public class AppDb : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<ContactInfo> ContactInfo { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configBulder = new ConfigurationBuilder();
        var configuration = configBulder.AddJsonFile("appsettings.json").Build();
        var configSection = configuration.GetSection("ConnectionStrings");
        var connectionString = configSection["DBConnection"];
        optionsBuilder.UseSqlServer(connectionString);
    }
}
