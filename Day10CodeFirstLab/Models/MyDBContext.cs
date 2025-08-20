using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10CodeFirstLab.Models
{
    // Database
    internal class MyDBContext : DbContext
    {
        // table : Collection of Rows
        public DbSet<Employee> Employees { get; set;  }

        // Configuration for the database connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // DbContextOptionsBuilder : building options for the DbContext
        {
            //base.OnConfiguring(optionsBuilder);
            // Specify the database provider and connection string
            optionsBuilder.UseSqlServer(@"Data Source=Belal-2004;Initial Catalog=EFCodeFirstDB;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
