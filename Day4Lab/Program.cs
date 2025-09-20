﻿namespace Day4Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Day4 Part1
            //Console.WriteLine("-------------------------------Day4Lab----------------------");
            //// Task Day 3 Pyramid 
            //int number = 12;
            //for (int i = 1; i <= number; i++)
            //{
            //    for (int j = 1; j <= number - i; j++)
            //        Console.Write(" ");
            //    for (int k = 1; k <= i; k++)
            //        Console.Write(" *");
            //    Console.WriteLine("");
            //}
            //Console.WriteLine("----------------------------------------------------------------");
            /*
             // Exception Handling                              Done 
            //1 - Try... Catch                                 Done 
            //2 - Try... Catch... Finally                      Done 
            //3 - Raising(Throwing) Exceptions                 Done 
            //Catch with Exception Like Default Switch  
            //Exception Error Runtime (Logical , Runtime error {Bug})
            */
            //try
            //{
            //    object obj = null; 
            //    Console.Write("Enter Number 1 : ");
            //    int num1 = int.Parse(Console.ReadLine());
            //    //int num1 = (int)obj;
            //    Console.Write("Enter Number 2 : ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int result = num1 / num2;
            //    Console.WriteLine(result);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Must Enter Number Only..........");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine($"Please Enter Number Between {int.MinValue} and {int.MaxValue}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot Divide By zero");
            //}
            //catch (NullReferenceException)
            //{
            //    Console.WriteLine("Cannot Use Null Value");
            //}
            //catch(Exception ex) {
            //    //Console.WriteLine(ex);
            //    //Console.WriteLine("");
            //    Console.WriteLine(ex.Message);
            //    //Console.WriteLine("");
            //    //Console.WriteLine(ex.StackTrace);
            //    //Console.WriteLine("");
            //    //Console.WriteLine(ex.InnerException);
            //    //Console.WriteLine("");
            //    //Console.WriteLine(ex.HelpLink);
            //    Console.WriteLine("Please Call Support 01212005985..............");
            //}finally
            //{
            //    // Connection or Streaming
            //    Console.WriteLine("Finish Apllication.....");
            //}
            //Console.ReadLine();
            //Console.WriteLine("--------------------------------------");
            try
            {
                Console.WriteLine(div(100, 0));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            #endregion

            #region Day4 Part2 (Oop)
            /*
                1-Object Class
                2-Inheritance
                3-Polymorphism 
                4-Encapsulation
                5-Abstraction
             */

            //Class Members    
            //         Fields        (Variables )  Done 
            //         Methods                     Done
            //         Property Full               Done 
            //         Property Auto               Done 
            //         Create Object From Class    Done 
            //         Constructor    ---          Done               
            //     Method OverLoad
            //     Constructor OverLoad
            //Readonly Vs Const
            //Inheritance   OverView
            //String str1 = new string("Yussif");
            //Console.WriteLine(str1);
            ////==
            //string str2= "Belal";
            //Console.WriteLine(str2);
            //Console.WriteLine("-----------------------------------");
            //Int32 i = new Int32();
            //i = 10;
            //Console.WriteLine(i);
            //int x = 15;
            //Console.WriteLine(x);
            //Console.WriteLine("-----------------------------------");
            //// Create Object 
            //Human belal = new Human();
            //belal.name = "Belal Mohamed";
            //belal._id = 10;
            //Console.WriteLine(belal.sayHello());
            //Console.WriteLine(belal.sayName());
            //Console.WriteLine("-----------------------------------");
            //Human sayed = new Human();
            //sayed.name = "Sayed Hawas";
            //sayed._id = 15;
            //Console.WriteLine(sayed.sayHello());
            //Console.WriteLine(sayed.sayName());
            //Console.WriteLine("-----------------------------------");
            // here employee is user defined Type as int , string , float ...
            // Any Type Can Be DataType
            //List <Employee> employees = new List<Employee>();
            //Employee ahmed = new Employee();
            //ahmed.SetId(100);
            //Console.WriteLine(ahmed.Id());
            // By Property
            //ahmed.Id = 10;
            //Console.WriteLine(ahmed.Id);

            // Pass Property
            //ahmed.ApplicationName = "eee"; // error because Appname is readOnly
            //ahmed.Id = 1;
            //ahmed.Name = "Ahmed Ali";
            //ahmed.Salary = 15000;
            //ahmed.Job = "Full Stack";
            //ahmed.Address = "Alexandria , Egypt";
            //ahmed.Attend = "@ 25-7-2025";
            //ahmed.Age = 25;
            ////ahmed.City = "Tanta";
            ////Console.WriteLine(ahmed.Attend); // error because there is no here getter for attend
            //Console.WriteLine(ahmed.getInfo());

            // Constructors
            Employee mariam = new Employee();
            mariam.Name = "Mariam Ahmed";
            Console.WriteLine(mariam.getInfo());
            #endregion
        }
        /// <summary>
        /// this method to Divide Two numbers 
        /// </summary>
        /// <param name="n1">Integer 1</param>
        /// <param name="n2">Integer 2</param>
        /// <returns>Divide Num 1 by Num 2 </returns>
        /// <exception cref="Exception">if Num 2 == 0 </exception>
        static int div(int n1 , int n2)
        {
            // Raising Exception 
            if(n2 == 0)
            {
                throw new Exception("Belal Say that Cannot Divide by Zero");
            }
            return n1 / n2;
        }
    }
    // Create Class 
    // Access Modifier : public , internal , private
    public class Human
    {
        // Fields (Attributes)
        public string name;
        public int _id;
        // Behaviour(Methods) 
        public string sayHello()
        {
            return "Hello...";
        }

        public string sayName()
        {
            return $"My name is {name}";
        }
    }
}
