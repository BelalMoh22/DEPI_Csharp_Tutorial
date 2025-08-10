using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class MyClass                                            //Object                         Inherit
    {
        private int PrivateValue { get; set; }                      //No                                No
        public int PublicValue { get; set; }                        //Yes                               Yes
        internal int InternalValue { get; set; }                    //Yes                               Yes
        protected int ProtectedValue { get; set; }                  //No                                Yes
        internal protected int InternalProtectedValue { get; set; } //Yes or No(for protected)          Yes or Yes
        private protected int PrivateProtectedValue { get; set; }   //No or No                             No or Yes
    }

    public class TestObject
    {
        public TestObject()
        {
            MyClass myClass = new MyClass();
            myClass.PublicValue = 100;
            myClass.InternalValue = 200;
            myClass.InternalProtectedValue = 400;
        }
    }

    public class TestInheritance : MyClass
    {
        public TestInheritance()
        {    
            PublicValue = 100;
            InternalValue = 200;
            ProtectedValue = 300;
            InternalProtectedValue = 400;
            PrivateProtectedValue = 500;
        }
    }
}
