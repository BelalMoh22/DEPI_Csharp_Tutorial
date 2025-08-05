using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Lab
{
    public class Manager : Employee
    {
        public string DepartmentManager { get; set; }

        public double Bouns { get; set; }

        public override double Income()
        {
            return base.Income() + Bouns;
        }
    }
}
