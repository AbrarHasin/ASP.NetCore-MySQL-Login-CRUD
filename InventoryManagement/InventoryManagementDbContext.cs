using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;

public class InventoryManagementDbContext : DbContext
{
    //Table List
    //public DbSet<Employee> Employies { get; set; }
    //Table List End

    public InventoryManagementDbContext(DbContextOptions<InventoryManagementDbContext> options)
    : base(options)
    {}

    //Fluent API to make Composite Key
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Desesase>()
            .HasIndex(u => u.Name)
            .IsUnique();

        //Key automatic generation configuration
        /*
        modelBuilder.Entity<Employee>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd();
        */

        /*-------------------------------------------*/

        //many to many relation configuration
        /*
            modelBuilder.Entity<Country>(e =>
            {
                e.HasAlternateKey(c => new { c.BengaliName });
                e.HasAlternateKey(c => new { c.EnglishName });
                e.HasAlternateKey(c => new { c.ShortName });
            });

            modelBuilder.Entity<CountryPerson>(cp =>
            {
                cp.HasOne(p => p.Person).WithMany(c => c.VisitedCountries).HasForeignKey(p => p.PersonID);
                cp.HasOne(c => c.Country).WithMany(p => p.Visitors).HasForeignKey(c => c.CountryID);

                //For Ensuring only 1 entry per person
                cp.HasAlternateKey(c => new { c.CountryID, c.PersonID });
            });
        */
    }

    //Fluent API to make Composite Key
    public DbSet<InventoryManagement.Models.Patient> Patient { get; set; }

    //Fluent API to make Composite Key
    public DbSet<InventoryManagement.Models.Desesase> Desesase { get; set; }

    //Fluent API to make Composite Key
    public DbSet<InventoryManagement.Models.Doctor> Doctor { get; set; }
}