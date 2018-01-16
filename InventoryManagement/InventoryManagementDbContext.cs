﻿using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;

public class InventoryManagementDbContext : DbContext
{
    //Table List
    public DbSet<Employee> Employies { get; set; }
    public DbSet<Entry> Entries { get; set; }
    //Table List End

    public InventoryManagementDbContext(DbContextOptions<InventoryManagementDbContext> options)
    : base(options)
    {
        //Migration - create Tables
        try
        {
            this.Database.EnsureDeleted();
            // Migrate the database
            this.Database.EnsureCreated();
            this.Database.Migrate();
        }
        catch (Exception ex)
        {
        }
    }

    //Fluent API to make Composite Key
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Key automatic generation configuration
        modelBuilder.Entity<Employee>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd();

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
}