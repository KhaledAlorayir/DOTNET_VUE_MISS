using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class dbContext: DbContext {
    public DbSet<Customer> Customers {get; set;}
    public DbSet<Pet> Pets {get; set;}
    public DbSet<PetType> PetTypes {get; set;}
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    optionsBuilder.LogTo(Console.WriteLine);
       optionsBuilder.UseSqlServer("Server=localhost,1433;Database=dot;User Id=sa;Password=6I9G2B]LG3H2;encrypt=true;trustServerCertificate=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<PetType>().HasData(new PetType(){id = 1, type = "Dog"},new PetType(){id = 2, type = "Cat"},new PetType(){id = 3, type = "Turtle"});
    }

}