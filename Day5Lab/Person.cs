using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Lab
{
    public class Person
    {
        //Fields 
        private int _id;
        private string _name;
        //Readonly Vs Const  
        // const : fixed value for the class
        // ReadOnly : Fixed value for Object and the intial value will be from Constructor
        public const string ApplicationName = "Smart App"; // Just ReadOnly cannot Set to it a value For class
        public readonly string instanceName; // Just ReadOnly cannot Set to it a value For object
        // readonly can be set only for Constructor
        public readonly string ConnectionDatabase;

        // Constructor 
        // Default Constructor : it is the first run from the class
        public Person()
        {
            Console.WriteLine("Say from Default Constructor");
            instanceName = $"{nameof(Person)} Copy";
            ConnectionDatabase = "SQL Service .... Connection String ";
        } // if i make a non-default Constructor , must make a default constructor to apply the overload
        
        // Overload Constructors   
        // Non CTOR (Non default Constructor)
        public Person(int id ,string name , string address)
        {
            Console.WriteLine("Say from non-Default Constructor");
            instanceName = $"{typeof(Person)} Copy";
            ConnectionDatabase = "SQL Service .... Connection String ";
            this._id = id;
            this._name = name;
            this.Address = address;
        }

        // Full Property
        // Old Syntax
        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        // New Syntax
        public string Name { 
            get => _name; 
            set => _name = value; 
        }

        // Auto Property
        public string Address { get; set; } // here if i put private before set  so it will be get only and if i put private before get so it will be set only

        //Methods (Void , return Type)
        public string SayInfo()
        {
            return $"ApplicationName = {ApplicationName} \nId = {_id}\n Name : {_name} \nAddress {Address} ";
        }
        // Polymorphism (Overload Methods)
        public string SayHello()
        {
            return "Hello";
        }

        public string SayHello(string n)
        {
            return $"Hello {n}";
        }

        public string SayHello(string n , string msg)
        {
            return $"{msg} {n}";
        }

        //Polymorphism(OverLoad, Override + Inheritance)
        // Overriding
        public virtual double Income()
        {
            // here virtual Keyword to override this method in subclasses
            return 0;
        }

    }
}
