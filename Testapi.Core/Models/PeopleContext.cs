using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Testapi.Models;

public class PeopleContext : DbContext
{
    public PeopleContext(DbContextOptions options) : base(options) { }
    public PeopleContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=password;Database=yes");
        optionsBuilder.EnableSensitiveDataLogging();
    }

    public DbSet<Person> People { get; set; } = null!;
    public DbSet<Address> Addresses { get; set; } = null!;
}