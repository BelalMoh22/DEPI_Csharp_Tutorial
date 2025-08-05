using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Lab
{
    //Inheritance -> Sub class : Super Class
    public class Employee : Person  // Person Super Class and Employee : Sub class
    {
        string day = DayOfWeek.Friday.ToString();

        public Employee() { }

        public Employee(int id, string name, string address, string job, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Job = job;
            this.Salary = salary;
        }

        public string Job { get; set; }

        public double Salary { get; set; }

        public int Hours { get; set; }

        public double HourRate { get; set; }

        public double ProjectPrice { get; set; }
        
        // Enum : List Of Coding Data
        public enum EmployeeType  // Int
        {
            FullTime = 1,
            PartTime = 2,
            FreeLance = 3
        }
        public EmployeeType _EmployeeType { get; set; }

        // Override Method
        public override double Income()
        {
            switch (_EmployeeType)
            {
                case EmployeeType.FullTime:
                    Salary = Salary;
                    break;
                case EmployeeType.PartTime:
                    Salary = Hours * HourRate;
                    break;
                case EmployeeType.FreeLance:
                    Salary = ProjectPrice;
                    break;
                default:
                    break;
            }
            return base.Income() + Salary;
        }

        //Overload Method
        public string SayHello(string n, string msg , string moreInfo)
        {
            return $"{msg} {n} {moreInfo}";
        }
    }
    }
