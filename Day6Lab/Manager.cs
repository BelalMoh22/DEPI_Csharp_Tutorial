using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Lab
{
    public class Manager : Employee
    {
        public string Department { get; set; }

        public double Bouns { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\n Mangaging Department : {Department} \n Bouns : {Bouns}";
        }

        public  double Income()
        {
            return Salary + Bouns;
        }
    }
}
