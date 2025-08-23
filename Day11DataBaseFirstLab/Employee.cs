using System;
using System.Collections.Generic;

namespace Day11DataBaseFirstLab;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string Name { get; set; } = null!;

    public string Job { get; set; } = null!;

    public string? Email { get; set; }

    public decimal Salary { get; set; }

    public bool IsDeleted { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }

    public override string ToString()
    {
        return $"ID: {EmployeeId}, Name: {Name}, Job: {Job}, Email: {Email}, Salary: {Salary:C}";
    }
}
