namespace Day8Lab
{
    internal class Program
    {
        public delegate void SayHelloHandler(string message);
        public static void SayHello(string str)
        {
            Console.WriteLine("Welcome " + str);
        }

        static void Main(string[] args)
        {
            // LINQ
            #region Day 8 Part 1
            ////Object Collection 
            int[] numbers = new int[] { 12, 22, 55, 99, 78, 77, 22, 66, 5 };

            // Sugar Expreesion
            Console.WriteLine("-----------------------------Sugar(SQL) Expreesion------------------------");
            var nums = from num in numbers
                       where num % 2 == 0
                       select num;
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("-----------------------------Lambda Expression-----------------------------------------");
            // Lambda Expression
            var b = numbers.Where(e => e % 2 == 1);
            foreach (int num in b)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("----------------------------------------------------------");
            ////LINQ Principles:-
            ////------------------
            ////1)Implicit type(Var)
            var v = (string)null;
            //int ? num = null;

            // 2) Object Intializer
            Employee emp1 = new Employee() { Id = 1, Name = "Ahmed", Salary = 1000 };

            Employee emp2 = new Employee { Id = 1, Name = "Ahmed", Salary = 1000 };

            ////3)Anonymous Object
            //new Employee();

            ////4)Collection Initializer.
            List<Employee> ListEmployee = new List<Employee>()
            {
             new Employee { Id= 1 , Name = "Ahmed" , Salary = 5000},
             new Employee { Id= 2 , Name = "ali" , Salary = 7000},
             new Employee { Id= 3 , Name = "Mohamed" , Salary = 15000}
            };

            var h = from emp in ListEmployee
                    where emp.Id >= 2
                    select new { emp.Id, emp.Name }; // Anonymous Type

            ////5)Dynamic Name.
            //string str = "Ahmed";
            //Console.WriteLine(str.Length);
            //int x = 10;
            ////Console.WriteLine(x.Length);

            //dynamic d = 10;
            ////Console.WriteLine(d.Length);

            //dynamic myObject = new System.Dynamic.ExpandoObject();
            //myObject.DynamicPropertyName = "Some Value"; // Adding a property with a dynamic name
            //Console.WriteLine(myObject.DynamicPropertyName);

            ///7)Anonymous Types.
            //var g = new { id = 1, Name = "sayed", Age = 40 };
            ////g.id = 5; read-only

            // 8)generic Type

            // 9)Extension Method

            ////10)Delegate ->Reference Type
            ////Delegates are used as pointers to methods that handle events
            ///*
            // - Delegates is A Function Pointer
            // - Delegate  is a type safe Function
            // - Delegate  is Reference type (Heap) 
            // - the Signature of Delegate Must Match the Signature Of Function Pointed it. 
            //*/

            ////* To Link Action ----> Delegate----->Event
            ////* To Do Event  ----call----->Delegate------ - Point To------ > Action
            SayHelloHandler sh = new SayHelloHandler(SayHello);
            sh("Ahmed From Delegate");

            //11)Build -in Delegate -> func : return type , Action : void type , Predicate : boolean type (return true or false)
            //Func<int,int,int> func = delegate(int x , int y) { return x+y; }; // raw Function
            // == 
            var func = delegate (int x, int y) { return x + y; };
            Console.WriteLine(func(10, 20));

            Action<int, int> action = delegate (int x, int y) { Console.WriteLine($"Sum: {(x + y)}"); };
            action(100, 200);

            Predicate<int> predicate = delegate (int x) { return x % 2 == 0; };
            Console.WriteLine(predicate(12));

            ////12)Anonymous Delegate.
            //13)Anonymous Method. 
            ////14)Linq Lambda Expression
            Func<int, int, int> func2 = (x, y) => x + y;
            Console.WriteLine("Delegate Linq Lambda Expression: " + func2(10, 20));

            Action<int, int> action2 = (x, y) => Console.WriteLine($"Sum: {(x + y)}");
            action2(100, 200);

            Predicate<int> predicate2 = x => x % 2 == 0;
            Console.WriteLine(predicate2(12));

            #endregion

            #region Day 8 Part 2
            Console.WriteLine("------------------------------------------------------------");
            //Employeee.CheckHandler check = new Employeee.CheckHandler(checkMethod);
            List<Employeee> ListEmployees = new List<Employeee>();
            ListEmployees.Add(new Employeee { ID = 1, Name = "Retaj", Job = "Developer", Salary = 5000, Attend = true });
            ListEmployees.Add(new Employeee { ID = 2, Name = "Mariam", Job = "Dr", Salary = 6000, Attend = true });
            ListEmployees.Add(new Employeee { ID = 3, Name = "sayed", Job = "Developer", Salary = 3000, Attend = false });
            ListEmployees.Add(new Employeee { ID = 4, Name = "osama", Job = "eng", Salary = 7000, Attend = true });

            Employeee.Report(ListEmployees, (Employeee e) => e.Attend == true);
            #endregion

            //public static void add(int x, int y)
            //{
            //Console.WriteLine(x + y);
            //} cannot Add method inside a Method

        }

        public static bool checkMethod(Employeee emp)
        {
            return emp.ID >= 2;
        }
    }
    // Any Type Can Be A DataType
    public class Employee
    {
        public Employee(){}

        public Employee(int id , string name , double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        // disconstructor
        ~Employee()
        {
            Console.WriteLine("Constructor Ends");
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }
    }

    public class Employeee
    {
        public delegate bool CheckHandler(Employeee emp);
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public bool Attend { get; set; }

        public static void Report(List<Employeee> employeeList , CheckHandler checkHandler)
        { 
            foreach (Employeee emp in employeeList)
            {
                //Hard code
                //if (emp.Salary > 4000)
                if(checkHandler(emp))
                {
                    Console.WriteLine($"the Id {emp.ID} name {emp.Name} salary {emp.Salary} job {emp.Job}");
                }
            }
        }
    }
}