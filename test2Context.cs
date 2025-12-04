using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace EFcore
{
    public class test2Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<EmployeeBook> EmployeesBooks { get; set; }
        
        public DbSet<Customers> Customers { get; set; }

        public DbSet<Orders> Orderss { get; set; }

        public DbSet<Invoice> Invoices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=test2;Trusted_Connection=true;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customers>()
                .HasMany(c => c.Orders)
                .WithOne(o => o.Customer)
                .OnDelete(DeleteBehavior.Cascade);

            foreach (var relationship in modelBuilder.Model
                .GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior =
                    DeleteBehavior.Restrict;
            }
            modelBuilder.Entity<Invoice>().Property(x => x.Tax)
                .HasComputedColumnSql("[Amount] * 2.2");

            modelBuilder.Entity<Invoice>().Property(x => x.Total)
              .HasComputedColumnSql("[Amount] + ([Amount] * 2.2)");

            modelBuilder.Entity<Invoice>().Property(x => x.Amount)
              .HasDefaultValue(0.0m);

            modelBuilder.Entity<Invoice>().Property(x => x.InvoiceDate)
             .HasDefaultValueSql("GETDATE()");


        }

    }
}
