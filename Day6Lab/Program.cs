using MyClassLibrary;

namespace Day6Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1 - Object Class                                                   Done
            2 - Inheritance                                                    Done
            3 - Polymorphism  Overload - Override                              Done
                         Method overriding  virtual ,override ,new             Done
            How to Open IL Disassembly in VS 
            CLR (Command Langauge RunTime) convert C# to --> MSIL (Intermediate Language)->(Assembely) --> JIT(Just in Time) Convert Il To Native Lang. --> (0101)   Done
            ---------------------------------
            SDK Framework
            Open this path C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.6.2 Tools
            Open File ilasm.exe
            Drag and Drop (exe Or dll) File to show the IL Dasm Code For it 


            Recursion Method                                                   Done

            Types Of Class  (Referenace Type)                                  Done
            ***************
            Normal Class                                                       Done
            Sealed Class                                                       Done
            static Class                                                       Done
            Partial Class                                                      Done
            Abstract Class                                                     Done
            [Inner]Internal Class}                                             Done
            Is                                                                 Done
            --------------------------------------------------
             Extension Method                                                  Done
            4 - Encapsulation  DLL  (Hide Data)  Property Full Auto            Done
            5 - Access Modifiers                                               Done                    
                -----------------
                https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

                    (public ,private ,protected,internal,protected internal, private protected ,file)

                    public: Code in any assembly can access this type or member. The accessibility level of the containing type controls the accessibility level of public members of the type.
                    private: Only code declared in the same class or struct can access this member.
                    protected: Only code in the same class or in a derived class can access this type or member.
                    internal: Only code in the same assembly can access this type or member.
                    protected internal: Only code in the same assembly or in a derived class in another assembly can access this type or member.
                    private protected: Only code in the same assembly and in the same class or a derived class can access the type or member.
                    file: Only code in the same file can access the type or member.
            */
            #region Day6 Part1
            Console.WriteLine("--------------Human--------------------------");
            Human h1 = new Human() { Id=1, Name="Mariam" ,Age= 21};
            Console.WriteLine(h1.ToString());
            Console.WriteLine($"Income :{h1.Income()}");

            Console.WriteLine("--------------Employee--------------------------");
            Employee emp1 = new Employee() { Id = 1, Name = "Mariam", Age = 21 , JobTitle = "Full Stack", Salary = 15000 };
            Console.WriteLine(emp1.ToString());
            Console.WriteLine($"Income :{emp1.Income()}");
            Console.WriteLine("----------------------------------------------------------------------------");
            // Recursive Method
            Console.WriteLine($"Factorial without Recursion :  {Factorial(6)}");
            Console.WriteLine($"Factorial With Recursion : {FactorialRecursion(6)}");
            Console.WriteLine("------------------------------------------------------------------------------");
            StaticClass.sayHello();
            Console.WriteLine("------------------------------------------------------------------------------");
            #endregion
            #region Day6 Part2
            //Extension Methods
            //SOLID -> O =>Open and Close 
            int x = 10;
            int y = 20;
            int add= x.Add(y); // here i add to sealed class another method called Extension Method
            Console.WriteLine(add);
            #endregion
        }
        // Recursion Method
        public static long Factorial(int Number)
        {
            long result = Number;
            for (int i = Number - 1; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }

        public static long FactorialRecursion(int Number) { 
            if (Number == 0) return 1;
            
            return Number * FactorialRecursion(Number - 1);
        
        }
    }
    /*
     Types Of Class  (Referenece Type)                                  Done
            ***************
            Normal Class                                                       Done
            Sealed Class                                                       Done
            static Class                                                       Done
            Partial Class                                                      Done
            Abstract Class                                                     Done
            [Inner]Internal Class      
     */
    /// <summary>
    ///     Comparing types of Classes by :
    ///     Creating object &  Inherit (From class or to class)
    /// </summary>
    /// 
    // 1.Normal Class :  Creating object  Done &  Inherit (From or to ) Done
    public class NormalClass : TestInheritanceTo
    {
        public int Id { get; set; }

        public string MethodTest()
        {
            return "Test";
        }
    }

    // 2.Sealed Class :  Creating object Done &  Can Inherit to يقدر يورث but don't inherit from مقدرش اورثه لكلاس تاني
    public sealed class SealedClass : NormalClass
    {

    }

    // 3. Static Class : cannot Create object   & Cannot Inherit (From or to ) 
    public static class StaticClass
    {
        // it must be have a Member static

        // Non-static or instance : can track it by Object
        //public void SayHello()
        //{

        //} // here in the static class we should make this as static

        // Static CTOR 
        static StaticClass()
        {
            Console.WriteLine("From Static");   
        } // Static CTOR cannot make an overload CTOR from it 

        // Static Member
        public static void sayHello()
        {
            Console.WriteLine("Say Hello");
        }
    }

    // 4.Partial Class: Creating object Done &  Inherit(From or to) Done
    public partial class PartialClass 
    {
        public void Save()
        {

        }

    }

    // 5. Abstract Class 0% TO 100% :  Cannot Create object Done & Can  Inherit(From) اورثه لكلاس-->  Implementing & Can Inherit To
    public abstract class AbstractClass
    {
         public abstract void CreateNew();
    }

    // 6. [Inner] Internal class
    public class OuterClass
    {
        private string str;

        public OuterClass()
        {
            
        }
        public class InnerClass
        {
            private string StrInner;

            public InnerClass()
            {
                OuterClass OC = new OuterClass();
                OC.str = "Private";
            }
            
        }
    }


    public class TestObject
    {
        public TestObject()
        {
            NormalClass NC = new NormalClass();
            SealedClass SC = new SealedClass();
            PartialClass PC = new PartialClass();
            //StaticClass SC = new StaticClass(); // error
            OuterClass OC = new OuterClass();
            OuterClass.InnerClass IC = new OuterClass.InnerClass();
            StaticClass.sayHello(); // i can track the method inside it by the name of Class Only
            NC.Id = 1;
            NC.Testinherit= 10;
            SC.ToString();
            PC.Save();
            PC.Edit();
        }
    }

    public class TestInheritanceTo
    {
        public int Testinherit { get; set; }
    }

    public class TestInheritanceFrom //: NormalClass   //: SealedClass-> Error
    {

    }

    public class TestAbstractClass : AbstractClass
    {
        public override void CreateNew()
        {
            Console.WriteLine("Create New");
        }
    }

    // if abstract class inherit from an Abstract Class so it will be inheritance not implementing
    public abstract class AbstractTwo : AbstractClass
    {
        public void NormalMethod()
        {
            Console.WriteLine("Normal Method");
        }
        public abstract void AbstractMethod();
    }

    // Extension Methods
    public static class NewInt
    {
        //this. // cannot used in static method or class
        public static int Add(this int x, int y)
        {
            return x + y;
        } 
    }
    // Encapsulation
    public class TestObject2
    {
        public TestObject2()
        {
            MyClass myClass = new MyClass();
            myClass.PublicValue = 100;
            //myClass.InternalValue = 200; // No
            //myClass.InternalProtectedValue = 400;  // No No // here the internal cannot be declared due to there is not the same namespace
        }
    }

    public class TestInheritance : MyClass
    {
        public TestInheritance()
        {
            PublicValue = 100;
            //InternalValue = 200;
            ProtectedValue = 300;
            InternalProtectedValue = 400; // no or Yes
            //PrivateProtectedValue = 500;  // because here there is no the namespace(assembely)
        }
    }
}
