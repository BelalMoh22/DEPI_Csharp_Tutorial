using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Lab
{
    public class Developer : Employee
    {
        public string Tasks { get; set; }


        public double Income()
        {
            return Salary;
        }

        public override string ToString()
        {
            return base.ToString() + $"\n Tasks : {Tasks}";
        }
    }
}
