using Day10CodeFirstLab.Models;

namespace Day10CodeFirstLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CRUD operations on the database Using Entity Framework Core (Code First Approach)
            #region Day 10 Part 2
            // 1) Create a New Project
            // 2) Add Entity Framework Core NuGet Packages (Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer, Microsoft.EntityFrameworkCore.Tools)
            // 3 ) Create Folder Models
            // 4) Create Class Entity as Table in DB (e.g., Product, Category, Employee)
            // Table -> Structure , Row Collection Table 
            //5) Create a Class Inherit DbContext Class (e.g., ApplicationDbContext)->(Microsoft.EntityFrameworkCore)
            // 6) Add DbSet<T> Properties for Each Entity Class (e.g., DbSet<Employee> Employees { get; set; })
            // 7) Configure the Database Connection in OnConfiguring Method

            // 8) Add Migration (add-migration <InitialCreate>) ->(Package Manager Console (PMC))
            // PM> get-help entityframework -> Get Help for Entity Framework Commands

            // 9) Update the Database (update-database) ->(PMC) to apply the migration and create the database schema
            Console.WriteLine("------------CRUD Operations Using EF Core------------");
            // 10 ) Create object the DbContext Class
            using (MyDBContext db = new MyDBContext())
            {
                // 11) Read Data from the Database
                Console.WriteLine("Loading Data from the Database...");
                LoadData(db); // Load data from the database
                Console.WriteLine("--------------------------------------------------");
                // 12) Insert Data into the Database
                Console.WriteLine("Inserting Data into the Database...");
                InsertData(db); // Insert new data into the database
                LoadData(db); // Load data again to see the changes
                Console.WriteLine("--------------------------------------------------");
                // 13) Update Data in the Database
                Console.WriteLine("Updating Data in the Database...");
                UpdateData(db); // Update existing data in the database
                LoadData(db); // Load data again to see the changes
                Console.WriteLine("--------------------------------------------------");
                // 14) Delete Data from the Database
                Console.WriteLine("Deleting Data from the Database...");
                DeleteData(db); // Delete data from the database
                LoadData(db); // Load data again to see the changes
                Console.WriteLine("--------------------------------------------------");
            }
            #endregion
        }

        // 11) Read Data from the Database
        public static void LoadData(MyDBContext db)
        {
            //Linq
            //var emps = from emp in db.Employees
            //           where emp.EmployeeId > 0
            //           select emp; 
            int rows = db.Employees.Count(); // Count the number of rows in the Employees table
            Console.WriteLine($"Number of Employees in the Database: {rows}");
            Console.WriteLine("----------------------------------------------------------------");
            // Lambda Expression
            var emps = db.Employees.Where(emp => emp.EmployeeId > 0);
            Console.WriteLine("Employees in the Database:");
            foreach (var emp in emps)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        // 12) Insert Data into the Database
        public static void InsertData(MyDBContext db)
        {
            Console.WriteLine("---------------C -> Create");
            // Take input from the user
            Console.Write("Enter Employee Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Employee Job : ");
            string job = Console.ReadLine();
            Console.Write("Enter Employee Salary : ");
            double salary;
            salary = double.TryParse(Console.ReadLine(), out salary) ? salary : 0.0; // Try to parse the input, if it fails set salary to 0.0
            Console.Write("Enter Employee Age : ");
            int age;
            age = int.TryParse(Console.ReadLine(), out age) ? age : 0; // Try to parse the input, if it fails set age to 0

            // Create Add on the DbSet<T> Property
            db.Employees.Add(new Employee() { Name = name, Job = job, Salary = salary, Age = age });

            // Save Changes to the Database
            db.SaveChanges(); // This will execute the SQL INSERT command to add the new employee to the database

            int Rows = db.Employees.Count(); // Count the number of rows in the Employees table
            Console.WriteLine($"Number of Employees in the Database after Insert: {Rows}");
        }

        public static Employee SelectEmployee(MyDBContext db)
        {
            // Take input from the user
            Console.Write("Enter Employee Id : ");
            int empId;
            empId = int.TryParse(Console.ReadLine(), out empId) ? empId : 0; // Try to parse the input, if it fails set empId to 0
            // Find the employee by Id  -> Find, First , FirstOrDefault, SingleOrDefault , Single , Last, LastOrDefault
            //var selectEmp = db.Employees.FirstOrDefault(e=> e.EmployeeId == empId); // FirstOrDefault will return the first employee with the specified Id or null if not found
            // or  SingleOrDefault
            //var selectEmp = db.Employees.SingleOrDefault(e => e.EmployeeId == empId); // SingleOrDefault will return the single employee with the specified Id or null if not found
            //or use Find method
            Employee emp = db.Employees.Find(empId); // Find the employee with the specified Id
            if (emp == null)
            {
                Console.WriteLine($"Employee with Id {empId} not found.");
                return null;
            }
            else
            {
                return emp; // Return the found employee
            }
        }

        // 13) Update Data in the Database
        public static void UpdateData(MyDBContext db)
        {
            Console.WriteLine("---------------U -> Update");

            Employee emp = SelectEmployee(db); // Select the employee to update
            // Update the employee details
            Console.Write("Enter New Employee Name : ");
            emp.Name = Console.ReadLine();
            Console.Write("Enter New Employee Job : ");
            emp.Job = Console.ReadLine();
            Console.Write("Enter New Employee Salary : ");
            double salary;
            salary = double.TryParse(Console.ReadLine(), out salary) ? salary : 0.0; // Try to parse the input, if it fails set salary to 0.0
            emp.Salary = salary;
            Console.Write("Enter New Employee Age : ");
            int age;
            age = int.TryParse(Console.ReadLine(), out age) ? age : 0; // Try to parse the input, if it fails set age to 0
            emp.Age = age;
            // Save Changes to the Database
            db.SaveChanges(); // This will execute the SQL UPDATE command to update the employee in the database
            Console.WriteLine($"Employee updated successfully...");
        }

        // 14) Delete Data from the Database
        public static void DeleteData(MyDBContext db)
        {
            Console.WriteLine("---------------D -> Delete");
            Employee emp = SelectEmployee(db); // Select the employee to delete
            if (emp != null)
            {
                db.Employees.Remove(emp); // Remove the employee from the DbSet
                db.SaveChanges(); // This will execute the SQL DELETE command to remove the employee from the database
                Console.WriteLine($"Employee with Id {emp.EmployeeId} deleted successfully.");
            }
        }
    }
}