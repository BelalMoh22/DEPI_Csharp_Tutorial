namespace Day5Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              OOP
                  1-Object Class
                  2-Inheritance
                  3-Polymorphism 
                  4-Encapsulation
                  5-Abstraction
               Push & Pull & Clone Github Repos Done    
               Class Members 
                       Fields              Done                    
                       Methods             Done         
                       Property Full       Done        
                       Property Auto       Done        
                       Create Object From Class     Done    
              Constructor                           Done 
              OverLoad (Method , Constructor)       Done
              Method OverLoad                       Done          
              Constructor OverLoad                  Done
              Readonly Vs Const                     Done

                Const     -- Fix Over Class  ---> Class Name   -- Static   Done  
                ReadOnly  -- Fix Over Object Initil (CTOR)                 Done
              Inheritance                            Done 
              Windows Form                           Done
            //Polymorphism(OverLoad, Override + Inheritance) Done 


              Type Can be DataType                     Done 

              Types Enum , Struct ( Value type )        Done        
              Use type (Enum , Struct)                  Done

              */
            #region Day 5 Part 1
            Console.WriteLine("----------------Part 1--------------");
            //Create Object from Person
            // Default Constructor
            Person P1= new Person();
            P1.Id = 1;
            P1.Name = "Ahmed";
            P1.Address = "Alexandria";
            Console.WriteLine(P1.SayInfo());
            P1.SayHello();
            Console.WriteLine("------------------------------");
            // Non-Default Constructor
            Person P2= new Person(2 , "Tamer" , "Cairo");
            Console.WriteLine(P2.SayInfo());
            Console.WriteLine("------------------------------");
            Console.WriteLine(Person.ApplicationName); 
            //P1.instanceName = "P1 Copy"; // here it will be an error as read only can be set only in Constructor
            Console.WriteLine(P1.instanceName);
            Console.WriteLine(P2.instanceName);
            Console.WriteLine(P1.ConnectionDatabase);
            Console.WriteLine("------------------------------");
            //Inheritance  -> Multi Inheritance Is not allowed
            Employee emp1 = new Employee();
            emp1.Job = "Developer";

            Manager M1 = new Manager();
            M1.DepartmentManager = "Software";
            Console.WriteLine("------------------------------");
            // Polymorphism
            Console.WriteLine($"Income {P1.Income()}");
            emp1.Salary = 15000;
            Console.WriteLine($"Income For Emp {emp1.Income()}");
            M1.Salary = 25000;
            M1.Bouns = 5000;
            Console.WriteLine($"Income for Manager {M1.Income()}");
            #endregion
            Console.WriteLine("----------------Part 2--------------");
            #region Day3 Part2
            //List<int> list = new List<int>() { 12, 2, 3, 5, 8, 8, 7, 8 };
            //List<string> list2 = new List<string>();
            //Type Can be DataType  (User Defined Type)
            // Person Class
            List<Employee> employees = new List<Employee>();

            // Create Object by intializer 
            Employee employee = new Employee() { Id = 2, Name = "Sayed", Address = "Tanta", Salary = 15000, Job = "Developer"};
            Console.WriteLine(employee.SayInfo());
            //employees.Add(employee);
            //foreach( Employee emp in employees)
            //{
            //    Console.WriteLine(emp.Name);
            //}
            Console.WriteLine("----------------------------------------------");
            //  Types Enum , Struct ( Value type )
            // Struct 
            Point p1 = new Point(100 , 200);
            Console.WriteLine(p1.PrintPoint());
            Console.WriteLine("---------------------------------------");
            //Enum 
            //Collection Array , Array List , List<T> ,Dic <int, string>
            //Collection Fix Enum 
            emp1._EmployeeType = Employee.EmployeeType.FullTime;
            M1._EmployeeType = Employee.EmployeeType.FullTime;

            Employee Emp2 = new Employee();
            Emp2._EmployeeType = Employee.EmployeeType.FullTime;
            Emp2.Salary = 15000;
            Console.WriteLine($"Full time: {Emp2.Income()}");
            Employee Emp3 = new Employee();
            Emp3._EmployeeType = Employee.EmployeeType.PartTime;
            Emp3.HourRate = 1000;
            Emp3.Hours = 40;
            Console.WriteLine($"PartTime: {Emp3.Income()}");
            Employee Emp4 = new Employee();
            Emp4._EmployeeType = Employee.EmployeeType.FreeLance;
            Emp4.ProjectPrice = 17000;
            Console.WriteLine($"FreeLance: {Emp4.Income()}");
            #endregion


        }
    }
}
