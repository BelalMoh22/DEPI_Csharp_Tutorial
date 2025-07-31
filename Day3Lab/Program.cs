using System.Collections;
using System.Reflection;

namespace Day3Lab
{
    internal class Program
    {
        ////*.DLL  --> namespace (Sub namespace) --> class --> method
        static void Main(string[] args)
        {
            // Add FROM Belal 
            #region TaskDay2
            //char choice;
            //do
            //{
            //    Console.Clear();
            //    // Task 2
            //    Console.Write("Enter First Number: ");
            //    double num1 = Convert.ToDouble(Console.ReadLine()); // here it will convert this to double
            //    Console.Write("Enter Second Number: ");
            //    double num2;
            //    double.TryParse(Console.ReadLine(), out num2); // pass by out 
            //                                                   // TryParse : if the input that user enters a string can be double so it will store it in this out
            //                                                   // but if it cannot be double so it will stored as zero
            //    Console.WriteLine("Enter Operator as + , - , * , / ");
            //    string op = Console.ReadLine().Trim();

            //    switch (op)
            //    {
            //        case "+":
            //            Console.WriteLine($"The Result of {num1}+{num2} = {(num1 + num2)}");
            //            break;

            //        case "-":
            //            Console.WriteLine($"The Result of {num1}-{num2} = {(num1 - num2)}");
            //            break;

            //        case "*":
            //            Console.WriteLine($"The Result of {num1}*{num2} = {(num1 * num2)}");
            //            break;

            //        case "/":
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("Division By Zero is not allowed");
            //                return;
            //            }
            //            else
            //            {
            //                Console.WriteLine($"The Result of {num1}/{num2} = {(num1 / num2)}");
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Enter a Valid Operator");
            //            break;
            //    }
            //    Console.WriteLine("Enter y or Y to Reapeat or any Key to stop....");
            //    choice = Console.ReadKey().KeyChar;

            //} while (choice == 'Y' || choice == 'y');
            #endregion

            #region Day3 Part1
            ////Implementing Iteration Logic (Loops)
            ////For , Do , While  

            ////for (Intiallization; Condition; incrementing) { 
            ////    // Code
            ////}
            //// Without 10
            //for (int i = 0; i < 10; i++) { 
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("End of Loop");
            //Console.WriteLine("-------------------------------");
            //// With 10
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("End of Loop");
            //Console.WriteLine("-------------------------------");
            //// Even
            //for (int i = 0; i <= 10; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("End of Loop");
            //Console.WriteLine("-------------------------------");
            //// Odd
            //for (int i = 1; i <= 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("End of Loop");
            //Console.WriteLine("-------------------------------");
            //// Decrement
            //for (int i = 12; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("---------------");
            //// if with condition
            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i % 2 ==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-------break--------");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i > 5)
            //    {
            //        break; //Jump Statment
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("-------continue--------");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i < 5)
            //    {
            //        continue; //Jump Statment
            //    }
            //    Console.WriteLine(i);
            //}
            ////Nested Loop
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine($"Multiply Table of {i}: ");
            //    for (int j = 0; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} * {j} : {(i * j)}");
            //    }
            //    Console.WriteLine("---------------------------------------------------");
            //}

            // While (pre-test Loop)
            //int i = 0;
            //while (i < 10) {
            //    //Console.WriteLine(i);
            //    //i++;
            //    Console.WriteLine(++i);
            //}
            //Console.WriteLine("-------------------------------");

            //Do-while (post-test loop)
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}while (i < 10);

            #endregion

            #region Day3 part2
            ////*.DLL  --> namespace  --> class --> method
            //// Collection Creating and Using Arrays
            //// Declare Array
            //int[] numbers = new int[3]; // 3 here is the length of Array

            ////Intialize values of Array 
            //numbers[0] = 800;
            //numbers[1] = 600;
            //numbers[2] = 100;
            ////numbers[4] = 500; // IndexOutOfRangeException
            //// Length of Array
            //Console.WriteLine("Length of Array: "+numbers.Length);

            //// Printing Array
            //Console.WriteLine("Array Before Sort :");
            //for(i=0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Array.Sort(numbers);
            //Console.WriteLine("Array After Sort :");
            //for (i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine("-------------------------------------------------");
            //// Declare and Intialize Array in One line
            //string[] students1 = new string[3] { "Mariam" , "Tamer" , "Tarek"};
            //string[] students2 = new string[] { "Mariam", "Tamer", "Tarek","Belal" , "Malak" };
            //// print Array By Foreach
            //Console.WriteLine("Array with Foreach: ");
            //foreach (var student in students1) {
            //    Console.WriteLine(student);
            //}
            //Console.WriteLine("-------------------------------------------------");
            //// IndexOf()
            //int index =Array.IndexOf(students1, "Tamer");
            //Console.WriteLine("indexOf(): "+index);

            //// Single Dimensional Array
            //Console.Write("Enter the books Number: ");
            //int booksCount;
            //int.TryParse(Console.ReadLine(), out booksCount);
            //string[] books = new string[booksCount];
            //for(i=0; i < booksCount; i++) 
            //{
            //    Console.Write($"Enter the Name of The Book {i+1}: ");
            //    books[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Enter any Key to print your Book Library: ");
            //Console.ReadLine();
            //foreach(var book in books)
            //{
            //    Console.WriteLine(book);
            //}

            // Multi Dimensional Array
            //int[,] x = new int[2, 3] { { 1, 20, 200 }, { 2, 300, 400 } };

            //for (int i = 0; i < x.GetLength(0); i++) // where here 0 is rows
            //{
            //    for (int l = 0; l < x.GetLength(1); l++) // where 1 is columns
            //    {
            //        Console.Write(x[i, l] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //=================================================================================================
            //// ArrayList NotGood
            ////Base On object  Boxing and Unboxing
            //ArrayList arrlist = new ArrayList();
            //int[] v = new int[3] { 1, 2, 3 };
            //arrlist.Add(100); // index 0
            //arrlist.Add("Mariam"); // index 1
            //arrlist.Add(12.5M); // index 2
            //// arrlist.Add(v); // index 3
            //arrlist.AddRange(v); // here i add range  // index 3 , 4 , 5
            //arrlist.Add(true); // index 4 // index 6 if i use range
            //arrlist.Add(false);
            //arrlist.Add(200);

            //for (int i = 0; i < arrlist.Count; i++)
            //{
            //    Console.WriteLine(arrlist[i]);
            //}
            //Console.WriteLine("---------------------------------------------------");
            //arrlist.Remove(100); // Remove by Value 
            //arrlist.RemoveAt(1); // Remove by index
            //arrlist.RemoveRange(2, 5); // Remove by Range
            //Console.WriteLine("After Removing: ");
            //for (int i = 0; i < arrlist.Count; i++)
            //{
            //    Console.WriteLine(arrlist[i]);
            //}
            #endregion

            #region Day3 Part3
            //Task Array Vs List
            // List<T>
            //List <int> numberslist = new List<int>();
            //numberslist.Add(100); //0
            //numberslist.Add(200); //1
            //numberslist.Add(300); //2

            //Console.WriteLine("Length of List: "+numberslist.Count);

            //foreach (int i in numberslist) {
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("----------------------------------------------");
            //List <string> names = new List<string>() {"Sayed" , "Mohamed" , "Retaj" , "Sayed"};
            //foreach (string name in names) {
            //    Console.WriteLine(name);
            //}
            //=====================================================================================
            // Dictionary 
            //Dictionary<int , string> students = new Dictionary<int , string>();
            //students.Add(1, "Sayed");
            //students.Add(2, "Mohamed");
            //students.Add(3, "Retaj");
            //students.Add(4, "Sayed");

            //Console.WriteLine("Count of Students : " + students.Count);
            //Console.WriteLine("Key 1 : " + students[1]);
            //Console.WriteLine("Key 2 : " + students[2]);
            //Console.WriteLine("Key 3 : " + students[3]);
            //Console.WriteLine("Key 4 : " + students[4]);

            //foreach (var item in students)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}
            #endregion

            #region Day3 part4 (Methods)
            // Creating And Invoking Methods
            /*
                1-What Is a Method?                             Done 
                2-Types Of Methods  (void | Return Datatype)    Done 
                3-Creating a Method                             Done
                4-Calling a Method                              Done
                5-Method With Paramenters   Optional Paramters  Done
                6-Pass Paramenters With Value & Ref & Out       Done 
                7-Using Parameter Arrays                        Done
                8-Key Words Params                              Done
                9-Overloaded Methods                            Done
            */
            // Method : Block of Code That Can be reused (Head & Body(Signature))
            // Types  : void or returnType
            //    static void | DataType MethodName(Parameters)
            //{
            //    MethodBody 
            //}

            //Invoke Method (Calling Method)
            //Overloading Methods : Change the Number of Parameters and the body of Method
            //PrintMessage();
            //PrintMessage("Belal");

            //Console.WriteLine(AddNumbers());
            //Console.WriteLine(AddNumbers(100 , 200));

            ////Calc Method
            //Console.WriteLine(CalcTwoNumbers(10, 20, "/"));
//====================================================================================
            //Optional Parameters

            //Console.WriteLine(subtract(10, 20)) ;
            //Console.WriteLine(subtract(y: 10, x: 20)); //Pass Naming
            //Console.WriteLine(subtract());
//==========================================================================================
            // Pass Paramenters With Value & Ref & Out 
            // pass By Value
            int number = 5;
            Console.WriteLine("Before Add Value: " + number); //5

            Console.WriteLine("Pass By Value: "+AddValue(number)); //15

            Console.WriteLine("After Add Value: " + number); // 5 because i didnot change in the variable i pass the value only
            Console.WriteLine("--------------------------------------------------------");

            // pass By Reference
            int number2 = 5;
            Console.WriteLine("Before Add Value: " + number2); //5

            Console.WriteLine("Pass By Reference: " + AddValue(ref number2)); //15 because here i passed to it the variable so it will change it

            Console.WriteLine("After Add Value: " + number2);
            Console.WriteLine("--------------------------------------------------------");
            // pass by Out
            //int x;
            //int total = x + 30; //x is not initialized Error
            int Oddnumber;
            Console.WriteLine("Pass by out: "+isOdd(14 , out Oddnumber));
            Console.WriteLine(Oddnumber);
            Console.WriteLine("---------------");
            Console.WriteLine("Pass by out: " + isOdd(15, out Oddnumber));
            Console.WriteLine(Oddnumber);
            Console.WriteLine("--------------------------------------------------------");
            //=======================================================================================
            //Using Parameter Arrays 
            int [] nums = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine(SumArray(nums));
            Console.WriteLine("-------------------------------------------------");
            // Key Words Params   
            Console.WriteLine(SumArrays(10 ,20 ,30 ,40 ,50));
            #endregion
        }

        //Methods:
        // 1.void Method With no Parameters
        // Creating Method
        static void PrintMessage()
        {
            Console.WriteLine("Hello World!");
        }

        // 1.void Method With Parameters and overload Another Method
        static void PrintMessage(string user)
        {
            Console.WriteLine($"Hello {user}");
        }

        // 2.returnType Method With no Parameters
        static int AddNumbers()
        {
            return 10 + 20;
        }

        // 2.returnType Method With Parameters and overload Another Method
        static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        // Method Calc() For Task 2
        static string CalcTwoNumbers(double num1, double num2, string op)
        {
            string Result = string.Empty;
            switch (op)
            {
                case "+":
                    Result = $"The Result of {num1}+{num2} = {(num1 + num2)}";
                    break;

                case "-":
                    Result = $"The Result of {num1}-{num2} = {(num1 - num2)}";
                    break;

                case "*":
                    Result = $"The Result of {num1}*{num2} = {(num1 * num2)}";
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Result= "Division By Zero is not allowed";
                        break;
                    }
                    else
                    {
                        Result= $"The Result of {num1}/{num2} = {(num1 / num2)}";
                    }
                    break;

                default:
                    Result= "Enter a Valid Operator";
                    break;
            }
            return Result; 
        }

        // Method With Paramenters   Optional Paramters

        /// <summary>
        /// Sum Method
        /// </summary>
        /// <param name="x">Integer</param>
        /// <param name="y">Integer</param>
        /// <returns>Sum = x + y</returns> // Documentation 
        static int subtract(int x =100 , int y =200) //Optional Paramters
        {
            return x - y;
        }

        // Pass Paramenters With Value & Ref & Out 

        // Pass by Value
        static int AddValue(int x)
        {
            return x += 10;
        }

        // Pass by Reference
        static int AddValue(ref int x)
        {
            return x += 10;
        }

        // pass by out
        static Boolean isOdd(int number , out int result)
        {
           if(number %2 != 0)
            {
                result = number;
                return true;
            }
            else
            {
                result = -1;
                return false;
            }
        }

        //Using Parameter Arrays   
        static int SumArray(int[] arr)
        {
            int result = 0;
            foreach (int i in arr)
            {
                result += i;
            }
            return result;
        }
        //Key Words Params   
        static int SumArrays(params int[] arr) // here params means that i will pass the numbers of array as arguments not an array but it must be the last parameter in the method head
        {
            int result = 0;
            foreach (int i in arr)
            {
                result += i;
            }
            return result;
        }

    }
}
