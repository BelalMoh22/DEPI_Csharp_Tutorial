namespace Day10Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Indexers 
            /* Use the this keyword to declare an indexer
               Use get and set accessors to provide access to the collection

                 In C#, indexers are special class members that allow instances of a class or struct to be indexed just like arrays []. 
                 They are defined using the this keyword, followed by one or more parameters in square brackets.
                 Indexers enable objects to be accessed using the array-like syntax.

                Here's a basic example to illustrate indexers in C#:
            */
            // Arch N-Layer  & N-tires
            // Entity Framework Core Code First 
            #region Day 10 Part 1
            // Indexer Example 
            // fixed size array
            int[] numbers = new int[5]; //{ 22, 55, 88, 77, 99, 2, 4, 57, 2, 550 };
            numbers[0] = 22;
            numbers[1] = 55;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine("----------------------------------------");
            // List Dynamic Length
            List<int> numbersList = new List<int>(); //{ 22, 55, 88, 77, 99, 2, 4, 57, 2, 550 };
            numbersList.Add(100);
            numbersList.Add(200);
            numbersList.Add(300);
            //numbersList[3] = 400; // here error because index 3 is not yet defined we need to add first
            numbersList.Add(400);
            numbersList[3] = 500; // now we can set the value at index 3
            Console.WriteLine(numbersList[0]);
            Console.WriteLine(numbersList[1]);
            Console.WriteLine(numbersList[3]);
            Console.WriteLine("--------------------------------------------");
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, Name = "John", Salary = 50000 });
            //employees[1] = new Employee() { Id = 2, Name = "Jane", Salary = 60000 }; // This will throw an error because index 1 does not exist yet

            Console.WriteLine(employees[0].ToString());
            //Console.WriteLine(employees[1].ToString()); // This will throw an error because index 1 does not exist yet
            Console.WriteLine("---------------------------------------------------------");
            // With Array
            Employee[] employeeArray = new Employee[3];
            employeeArray[0] = new Employee { Id = 1, Name = "John", Salary = 50000 };
            employeeArray[1] = new Employee { Id = 2, Name = "Jane", Salary = 60000 };

            foreach(var emp in employeeArray)
            {
                if (emp != null) // Check for null to avoid NullReferenceException
                {
                    Console.WriteLine(emp.ToString());
                }
            }

            Console.WriteLine("---------------------------------------------------------------");
            // Indexer with List 
            // Indexers allow you to access elements in a collection using an index, similar to how you would access elements in an array.
            Console.WriteLine("----------------------Indexer---------------------------");
            SampleCollection<int> Nums = new SampleCollection<int>();
            Nums.Add(100);
            Nums[1] = 200;// This will add 200 at index 1
            for(int i = 0 ; i < Nums.Count; i++)
            {
                Console.WriteLine(Nums[i]);
            }
            Console.WriteLine("---------------------------------------------------");
            SampleCollection<Employee> empCollection = new SampleCollection<Employee>();
            empCollection.Add(new Employee { Id = 1, Name = "John", Salary = 50000 });
            empCollection[1] = new Employee { Id = 2, Name = "Jane", Salary = 60000 }; // This will add Jane at index 1
            empCollection[2] = new Employee { Id = 3, Name = "Doe", Salary = 70000 }; // This will add Doe at index 2

            for (int i = 0; i < empCollection.Count;  i++)
            {
                Console.WriteLine(empCollection[i].ToString());
            }
            #endregion
        }
    }
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        override public string ToString()
        {
            //return base.ToString();
            return $" ID : {Id}\nName : {Name}\nSalary : {Salary}";
        }
    }

    public class SampleCollection<T> : IComparable
    {
        // Declare an array to store the collection elements
        private List<T> data = new List<T>();
        // Define an indexer to allow array-like access
        public T this[int index]
        {
            get
            {
                // The get accessor returns the value at the specified index
                return data[index];
            }
            set
            {
                // The set accessor assigns a value to the element at the specified index
                if (index < data.Count)
                {
                    data[index] = value;
                }
                else
                {
                    data.Add(value);
                }
            }
        }

        //Read Only Prop
        public int Count
        {
            get
            {
                return data.Count;
            }
        }
        //Method
        public void Add(T item)
        {
            // Adds an item to the collection
            data.Add(item);
        }

        public int CompareTo(object obj)
        {
            if (obj is SampleCollection<T> otherCollection)
            {
                // Compare the two collections (this is just an example, you can implement your own logic)
                return this.Count.CompareTo(otherCollection.Count);
            }
            throw new ArgumentException("Object is not a SampleCollection");
        }
    }

    public class SampleNonGenericCollection
    {
        // Declare an array to store the collection elements
        private List<int> data = new List<int>();
        // Define an indexer to allow array-like access
        public int this[int index] //0 1 2 3 ...
        {
            get
            {
                // The get accessor returns the value at the specified index
                return data[index];
            }
            set
            {
                //0 1  2
                // The set accessor assigns a value to the element at the specified index
                if (index < data.Count)
                {
                    data[index] = value;
                }
                else
                {
                    data.Add(value);
                }
            }
        }
        //Read Only Prop
        public int Count
        {
            get
            {
                return data.Count;
            }
        }
        //Method
        public void Add(int item)
        {
            data.Add(item);
        }
    }
}
