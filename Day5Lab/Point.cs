using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Lab
{
    public struct Point
    {
        public int x;
        public int y;

        public Point(int x , int y)
        {
            this.x = x;
            this.y = y;
        }

        public string PrintPoint()
        {
            return $"x: {x} & y: {y}";
        }

    }
    //public struct PointAdvanced : Point // struct is sealed so cannot inherit by any class or struct
    //{

    //}
}   
