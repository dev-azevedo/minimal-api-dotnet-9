using Microsoft.EntityFrameworkCore;
using Person.Models;

namespace Person.Data;

public class AppDbContext : DbContext
{
    public DbSet<PersonModel> Persons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=person.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}
