using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10CodeFirstLab.Models
{
    public class Employee  // Entity Class -> Table in Database and one of it is row
    {
        // The First Field is the Primary Key

        // Configuration for Entity Framework Core
        // 1) Data Annotations
        //[Key]  // This attribute specifies that this property is the primary key

        public int EmployeeId { get; set; } // Primary Key

        public string Name { get; set; }

        public string Job { get; set; }

        public double Salary { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"EmployeeId: {EmployeeId}, Name: {Name}, Job: {Job}, Salary: {Salary:C}, Age: {Age}";
        }
    }
}
