using System.Xml.Linq;

namespace Day7Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        - Generic type                Done 
                        - IO Library                  Done
                        - Abstraction                 Done
                        - Abstract Class              Done
                        - Interface                   Done
                        - Abstraction { Abstract Class 0 To 100% - Interface 100% }  //Before .Net Core 8   Done
                    LINQ Principles:-
                    ------------------
                    1)Implicit type (Var)
                    2)Object Initializer.
                    3)Collection Initializer.
                    4)Dynamic Name.
                    5)Anonymous Types.
                    6)Generic type.
                    7)Extension Methods.
                    8)Delegate. 
                    9)Linq To Object (Linq Query).
                    10)Anonymous Delegate.
                    11)Anonymous Method. 
                    12)Linq Lambda Expression. 
                    13)Bulid-in Delegate.
            */
            #region Day7 Part1
            /*
            Generic type.                 Done                              
            Generic Method                Done
            Generic Property              Done
            Generic Parameter             Done
            */
            //IntMyList ML = new IntMyList(3);
            //ML.Add(20);
            //ML.Add(30);
            //ML.Add(40);
            //Console.WriteLine("Normal List: " + ML.Get(0));

            //// Array -> FIXED Length
            //int[] x = new int[5];

            //// List -> Dynamic Length -> Generic
            //List<int> y = new List<int>();

            //GenericMyList<string> names = new GenericMyList<string>(3);
            //names.Add("Ahmed1");
            //names.Add("Ahmed2");
            //names.Add("Ahmed3");
            //Console.WriteLine("Generic String List: " + names.Get(2));
            //Console.WriteLine("Length of Names : " + names.GetLength);
            //names.Name = "Welcome As String";
            //Console.WriteLine("Generic Property: " + names.Name);

            //GenericMyList<double> salaries = new GenericMyList<double>(3);
            //salaries.Add(1.28);
            //salaries.Add(1.29);
            //salaries.Add(1.32);
            //salaries.Name = 100.30;
            //Console.WriteLine("Generic Doubles List: " + salaries.Get(0));
            //Console.WriteLine("Generic Property: " + salaries.Name);

            //// IO Library (Input , Output File , folder , streaming ...)
            ////DriveInfo, Directory , DirectoryInfo ,File ,FileInfo
            //var Drivers = DriveInfo.GetDrives(); // return Array
            //foreach (var driver in Drivers)
            //{
            //    Console.WriteLine(driver.Name);
            //} // print Drives in My PC
            //DriveInfo DI = new DriveInfo("C");
            //Console.WriteLine("Drive Format: " + DI.DriveFormat);
            //Console.WriteLine("Volume Label(if there is a name for Driver): "+DI.VolumeLabel);
            //Console.WriteLine("Total Size of Drive :" +DI.TotalSize/1024/1024/1024 +" GB");
            //Console.WriteLine("Free Space: " +DI.AvailableFreeSpace/1024/1024/1024 +"GB");
            #endregion

            #region Day7 Part2
            //LINQ Language Integrated Query
            List<string> Names = new List<string>() { "Ahmed", "Mohamed", "Ramy", "Ali", "Mariem", "Retaj", "Sayed" };

            var newlist = from name in Names
                          where name.Contains("a")
                          select name; // sugar Expression

            foreach(var name in newlist)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("----------------------------------------");
            // Lambda Expression
            var result = Names.Where(name => name.Contains("i")); 
            foreach(var name in result)
            {
                Console.WriteLine(name);
            }

            // 1)Implicit type(Var)

            var x = Names[0];

            // 2. Object Initializer : when you create a Object intializer you must make an default constructor cannot remove it
            //Teacher Ahmed = new Teacher() { Id = 1, Name = "Ahmed", Subject = "English" };
            //or
            Teacher Ahmed = new Teacher{ Id = 1, Name = "Ahmed", Subject = "English" };

            //Teacher t = new Teacher();
            //==
            var t = new Teacher();
            //==
            // 3)Anonymous Object
            new Teacher(); // but here this object has not reference to it

            // 4)Collection Initializer.
            List<Teacher> Teachers= new List<Teacher>() 
            {
               new Teacher { Id = 1, Name = "Ahmed", Subject = "English" },
               new Teacher { Id = 2, Name = "Mohamed", Subject = "Arabic" },
               new Teacher { Id = 3, Name = "Retaj", Subject = "French" }
            };

            foreach (var te in Teachers) {
                Console.WriteLine($"ID: {te.Id}");
                Console.WriteLine($"Name: {te.Name}");
                Console.WriteLine($"Subject: {te.Subject}");
                Console.WriteLine("------------------------------------");
            }

            // 5) Dynamic Name
            string str = "Welcome ....";
            Console.WriteLine(str.Length);

            int i = 100;
            //Console.WriteLine(i.length); // here syntax Error

            dynamic ii = 100;
            //Console.WriteLine(ii.length); // here runtime Error

            var xx = from v in Teachers
                     where v.Id == 1
                     select new {v.Name , v.Id };

            // 6.Anonymous Types
            var k = new { Id = 1, Name = "Belal", Salary = 15000, Job = "Developer" };
            Console.WriteLine(k.Id);
            //k.Id = 5; // Read-only Error

            //Data Source table Column    Id , Name , HireDate    
            //int , string , Datetime

            #endregion
        }
    }

    public class IntMyList // here this class must intialize to it an index so it like array fixed
    {
        private int[] MyList;
        private int currentIndex = 0;
        public IntMyList(int index)
        {   
            MyList = new int[index];
        }

        public void Add(int value) 
        { 
            MyList[currentIndex++] = value;
        }

        public int Get(int index) { 
            return MyList[index];
        }
    }

    // Generic 
    public class GenericMyList<T>  //where T :  //Employee //struct //class // if class so the value type cannot declared by this class and if it struct so the reference type cannot declared by this class
    {
        private T[] MyList; // any datatype : Generic Type
        private int currentIndex = 0;
        public GenericMyList(int index)
        {
            MyList = new T[index]; 
        }

        public  T Name { get; set; } // Generic Property
        public int GetLength { get { return MyList.Length; } }

        public void Add(T value) // Generic Parameter
        {
            MyList[currentIndex++] = value;
        }

        public T Get(int index) // Generic Method
        {
            return MyList[index];
        }
    }

    //public class Employee
    //{

    //}

    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
    }
}
