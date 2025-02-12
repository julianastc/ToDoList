using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infra;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    {
    }
    public DbSet<ToDoItem> ToDoItems { get; set; } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ToDoItem>()
            .HasKey(x => x.Id);
        
        modelBuilder.Entity<ToDoItem>()
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("YourConnectionString",
                b => b.MigrationsAssembly("Infra"));  // Especificando o assembly de migrações
        }
    }

}