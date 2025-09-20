using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Lab
{
    // Type can Be DataType (User-Defined-Type)
    internal class Employee
    {
        // Fields variables
        #region Fields
        private string _applicationName = "Smart Software";
        private int _id;
        private string _name;
        private string _job;
        private double _salary;
        // propfull
        private string _address;
        private string _attend;
        #endregion

        #region Constructors
        // Constructor -> CTOR
        //1-Public
        //2- Without Return Type (Void | Return)
        //3- Take the same Name of Class
        // Default Constructor -> Without Parameters
        public Employee()
        {
            Console.WriteLine("Say From Constructor");
        }

        // CTOR 
        //public Employee()
        //{
            
        //}
        #endregion

        #region Properties
        // full Property
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public int Id // as Encapsulation
        {
            get { return _id; }

            set { _id = value; }
        }

        // New full Property
        public string Name { get => _name; set => _name = value; }
        // == 
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        public string Job { get => _job; set => _job = value; }
        public double Salary
        {
            get { return _salary; }

            set
            {
                if (value < 1000)
                {
                    _salary = 1000;
                }
                else
                {
                    _salary = value;
                }
            }
        }

        // Read Only
        public string ApplicationName
        {
            get { return _applicationName; }
        }

        // Set Only
        public string Attend
        {
            set { _attend = value; }
        }

        // Auto Property --> Database
        // prop 
        public int Age { get; set; }
        public string City { get; set; } = "Alex"; // Initial Value  
        #endregion

        #region Methods
        // Method
        #region oldSetter and Getters
        // Getter
        //public int Id()
        //{
        //    return _id;
        //}

        //// Setter
        //public void SetId(int id)
        //{
        //    _id = id;
        //} 
        #endregion
        public string getInfo()
        {
            return $"My Name is {_name} \n Company Name is {_applicationName} \n Age is {Age} \n City is {City} \n Id is {_id} \n Job is {_job} \n Salary is {_salary:C} \n Address is {_address} ";
        }

        #endregion
    }
}
