using Microsoft.EntityFrameworkCore;

namespace Day11DataBaseFirstLab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Day 11
            **********************************
            CSS Day 1 session  1 ~ 1:30    HTML 5 + CSS 3
            C# Connection with Database EF Core Database First 
            IEnumerable vs IQueryable (LINQ)
             */
            #region Day 11 Part 1
            // 1) Create Database in SQL Server (e.g., MyDatabase)
            // 2) Create Table in the Database (e.g., Employee)
            // 3) Create a New Project
            // 4) Add Entity Framework Core NuGet Packages (Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Tools, Microsoft.EntityFrameworkCore.Design)
            // 5) Scaffold the Database to Generate Entity Classes and DbContext Class (PMC) -> by command: Scaffold-DbContext "Server=.;Database=MyDatabase;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force 

            // 6) Perform CRUD operations using the generated DbContext and Entity Classes
            Console.WriteLine("------------CRUD Operations Using EF Core (Database First Approach)------------");
            // 7) Create object the DbContext Class
            EfcoreDatabaseFirstDbContext db = new EfcoreDatabaseFirstDbContext();
            //LoadData(db); // Load data from the database
            Console.WriteLine("---------------------------------------------------------------------------");
            #endregion

            #region Day 11 Part 2
            // IEnumerable vs IQueryable (LINQ)
            using (EfcoreDatabaseFirstDbContext db2 = new EfcoreDatabaseFirstDbContext())
            {
                // SQL Profile : it is a tool to monitor the SQL queries sent to the database
                // Select Top (3) * from Employees where IsDeleted = 0;
                //IEnumerable<Employee> emps = db.Employees.Where(e => e.IsDeleted == false).ToList().Take(3);

                //Console.WriteLine("-----------IEnumerable-------------");
                //foreach (Employee e in emps)
                //{
                //    Console.WriteLine(e.ToString());
                //}
                Console.WriteLine("-----------IQueryable-------------");
                IQueryable<Employee> emps2 = db.Employees.Where(e => e.IsDeleted == false).Take(3);
                foreach (Employee e in emps2)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }    
            #endregion
        public static void LoadData(EfcoreDatabaseFirstDbContext db)
        {
            using (db)
            {
                string strQuery = db.Departments.ToQueryString(); // Get the SQL query for retrieving departments
                Console.WriteLine($"SQL Query for Departments: {strQuery}");
                Console.WriteLine("---------------------------------------------------------------------");
                // 8) Read Data from the Database
                Console.WriteLine("-------------------------List Departments---------------------------------");
                IList<Department> depts = db.Departments.ToList(); // Retrieve all departments from the database
                // or
                IEnumerable<Department> deptsQuery = db.Departments.ToList();
                foreach (var dept in depts)
                {
                    Console.WriteLine($"Department ID: {dept.DepartmentId}, Name: {dept.Name}");
                }
                Console.WriteLine("---------------------------------------------------------------------");
                string strQuery2 = db.Employees.Where(e => e.EmployeeId > 0).ToQueryString(); // Get the SQL query for retrieving employees
                Console.WriteLine($"SQL Query for Employees: {strQuery2}");
                Console.WriteLine("---------------------------------------------------------------------");
                // IEnumerable -> System.Collections.Generic : here it will fetch all data from database and store it in memory
                // IQueryable -> Microsoft.EntityFrameworkCore : here it will fetch data from database when wes iterate over it (defered execution)
                Console.WriteLine("---------------------List Employees-----------------------");
                //IEnumerable<Employee> emps = db.Employees.ToList(); // Retrieve all employees from the database
                //or
                //IQueryable <Employee> empsQuery = db.Employees.AsQueryable(); // Retrieve all employees from the database
                //or
                IEnumerable<Employee> emps = db.Employees.Where(e => e.EmployeeId > 0);
                foreach (var emp in emps)
                {
                    Console.WriteLine(emp.ToString());
                }
            }
        }

        // Full CRUD operations can be implemented here (Insert, Update, Delete) as needed.
    }
}
