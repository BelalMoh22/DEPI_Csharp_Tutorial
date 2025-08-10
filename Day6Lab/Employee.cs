using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Lab
{
    public class Employee : Human
    {
        public string JobTitle { get; set; }
        public double Salary  { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\n JobTitle : {JobTitle} \n Salary : {Salary}";
        }

        public new double Income()
        {
            return base.Income() + Salary;
        } // here new break to override this method to any subclasses again 
    }
}
