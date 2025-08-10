using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Lab
{
    public class Human
    {
        // Fields

        // Property
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        // Constructor
        public Human(){}

        // Methods
        public virtual double Income()
        {
            return 0;
        } // here i wrote virtual to can override it

        public override string ToString()
        {
            return $"Info: \n ID: {Id} \n Name:{Name} \n Age: {Age}";
        }
    }
}
