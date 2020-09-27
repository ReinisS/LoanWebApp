using System;
using System.Linq;
using LoanWebApp.Models;
using Microsoft.EntityFrameworkCore;
using static LoanWebApp.Models.OperationType;

namespace LoanWebApp.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> Person { get; set; }
        public DbSet<Operation> Operation { get; set; }
        public DbSet<OperationType> OperationType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Make sure EF knows that the OperationTypeId enum can be converted to int
            modelBuilder.Entity<OperationType>()
                .Property(e => e.Id)
                .HasConversion<int>();

            // SQLite doesn't natively support the decimal data type, so use double here instead
            // More information here: https://docs.microsoft.com/en-us/ef/core/providers/sqlite/limitations
            modelBuilder.Entity<Operation>()
                .Property(e => e.Amount)
                .HasConversion<double>();

            base.OnModelCreating(modelBuilder);

            // Add initial OperationType data to the database
            modelBuilder.Entity<OperationType>().HasData(
                Enum.GetValues(typeof(OperationTypeId))
                    .Cast<OperationTypeId>()
                    .Select(e => new OperationType()
                    {
                        Id = e,
                        Name = e.ToString()
                    })
            );

            // Add initial Person data to the database
            modelBuilder.Entity<Person>().HasData(InitialDbData.InitialPersonList);

            // Add initial Operation data to the database
            modelBuilder.Entity<Operation>().HasData(InitialDbData.InitialOperationList);
        }
    }
}