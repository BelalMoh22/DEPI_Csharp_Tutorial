using System.Runtime.Intrinsics.X86;

namespace Day2Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Note: 
                1- implicit   small to big
                * 2- explicit   big to small (cast)  
                * 3- string to any type   <type>.Parse( )
                * 4- any type to string  Convert.to<type>( )
 */
            #region Day1
            // Day1 
            //Console.Write("Enter Your Name: ");
            //// Variables
            //String name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);
            #endregion

            #region Day2 Part1
            ////byte
            //byte b = 255;
            //Console.WriteLine("Byte: " + b);

            //// Short
            //short sh = 10000;
            //Console.WriteLine("Short: " + sh);

            ////Integer
            //int i = 2147483647;
            //Console.WriteLine("Integer: " + i);

            //// Long 
            //long l = 9223372036854775807;
            //Console.WriteLine("Long: " + l);

            //// Double
            //double d = 1 / 3;
            //Console.WriteLine("Double: " + d); // here it will print 0 because there is not d on the end of expression
            //double dd = 1 / 3d;
            //Console.WriteLine("Double: " + dd);
            //double ddd = 1.0 / 3.0;
            //Console.WriteLine("Double with decimal: " + ddd);

            //// Float
            ////float f = 1.235; // here it is an error we need to use 'f' at the end of the number
            //float f = 1.235f; // Corrected by adding 'f' at the end
            //Console.WriteLine("Float: " + f);

            //// Decimal
            //decimal dec = 1.235m; // Corrected by adding 'm' at the end 
            //Console.WriteLine("Decimal: " + dec);

            //// Diff.Betwween Decimal and Double and Float
            //double diffDouble = 1 / 3d;
            //float diffFloat = 1 / 3f;
            //decimal diffDecimal = 1 / 3m;
            //// Decimal is more precise than Double and Float 
            //// Double is more precise than Float 
            //Console.WriteLine("Double: " + diffDouble);
            //Console.WriteLine("Float: " + diffFloat);
            //Console.WriteLine("Decimal: " + diffDecimal);

            ////Use the MinValue and MaxValue properties for each unsigned integral type
            ////---------------------------------------------------------------------------
            //            Console.WriteLine("--------------------------------------------");
            //            Console.WriteLine("Unsigned integral types:"); // without negative values
            //            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            //            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            //            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            //            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            ////Use the MinValue and MaxValue properties for each signed float type
            ////------------------------------------------------------------------------
            //            Console.WriteLine("---------------------------------------");
            //            Console.WriteLine("Floating point types:");
            //            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            //            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            //            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");


            //// String
            //string str = "Hello World !";
            //Console.WriteLine("String: " + str);

            ////char
            //char a = 'a'; // int
            //Console.WriteLine("Char: " + a);
            ////Casting
            //char A = (char)65;
            //Console.WriteLine("Char With Casting: " + A);

            ////boolean
            //bool yesOrNo = true;
            //Console.WriteLine("Boolean: " + yesOrNo);
            //yesOrNo = 1 > 10;  // reassign variable
            //// Comparison Operator : > , < , <= , >= , == , !=
            //// Logical Operator : && , || , & ,| , !
            //Console.WriteLine("Boolean With Comparsion Operator: " + yesOrNo);
            //yesOrNo = 1 < 10 && 10 > 12;
            //Console.WriteLine("Boolean With AND Logical Operator: " + yesOrNo);

            //yesOrNo = 1 < 10 || 10 > 12;
            //Console.WriteLine("Boolean With OR Logical Operator: " + yesOrNo);

            ////DateTime
            //DateTime date = DateTime.Now;
            //Console.WriteLine("DateTime: " + date);

            //// Assign Operator : = , += , -= , *= , /= , %=
            //// where LeftHand = RightHand -> Righthand stored in LeftHand
            //int x = 100;
            //x += 50;// x=x+50
            //Console.WriteLine("x(100) += 50 : " + x);
            //x -= 20;
            //Console.WriteLine("x(150) -= 20 : " + x);

            //// Incrementing x++ (post-increment) , ++x (pre-increment)
            //// Decrementing x-- (post-decrement) , --x (pre-decrement)
            //Console.WriteLine("X by post-increment: " + (x++)); // here it will print then increment
            //Console.WriteLine(x);
            //Console.WriteLine("X by pre-increment: " + (++x)); // here it will increment then print

            //// Parsing
            //Console.Write("Enter First Number: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter Second Number: ");
            //int number2 = int.Parse(Console.ReadLine());

            ////Concatination (+)
            //Console.WriteLine("Add Number1 and Number2 After Parsing: " + number1 + number2); // here it will concat the two numbers no add them
            //Console.WriteLine("Add Number1 and Number2 After Parsing: " + (number1 + number2)); // here it will add the two numbers due to they are in brackets

            //// Format String
            //Console.WriteLine("Add Number1 and Number2 by Format String: {0} + {1} = {2}", number1, number2, (number1 + number2));

            //// String Literals --> Best
            //Console.WriteLine($"Add Number1 and Number2 by String Literals: {number1} + {number2} = {(number1 + number2)}");

            // to covert to string  convert 
            //char c = 'a';
            //string name = Convert.ToString(c);
            //int asci32=Convert.ToInt32(c);
            //Console.WriteLine(name);
            //Console.WriteLine(asci32);
            #endregion

            #region Day2 Part2
            ///*
            //// DataType 
            //    -- ValueType Stored in Stack --> not allow null as : int , double , bool and so on..
            //    -- ReferenceType Stored in Heap --> allow null as : String , object
            //*/
            //// Object
            //object obj = "Ahmed";
            //obj = 123;
            //obj = "Ali";
            //obj = 5;
            ////int total = obj; // here it will be error because he doesn't know the object is int here i must make unboxing by casting the Object
            //int total = (int) obj + 10;
            //// Unboxing = Casting here
            //Console.WriteLine(total);
            //obj = "Mohamed";
            //String str = obj + " Ahmed";
            ////str = obj; // here there is an error
            //str = (string) obj;


            //// Implicit And Explicit 
            //int num = 321311;
            //long lg = 56656565656;
            //double d = 1.254;
            //decimal de;
            //// Double is the default value for Floating Points

            //// Implicit --> small in big
            //de = (decimal)d;
            //lg = num;
            ////Explicit --> big in small
            //num = (int)lg;
            //Console.WriteLine(num);
            //Console.WriteLine(lg);

            //// var implicit datatype

            ////// var cannot be declared only we must declare and intialize
            //var v = 15;
            //var n = "Ali";
            ////n = 152.5; // here there is an error because the var from the first value that intialize to it so it will take it's datatype
            ////var xx = null; // here it is an error because null isn't a datatype
            //var xx = (string)null; 
            //String str3 = null;
            //object obj2 = null;
            ////int number = null;  // not allow null

            ////Dynamic --> RuntimeError

            //dynamic dy = "Ahmed";
            //dy = 123;
            //int i = dy + 15;
            //Console.WriteLine(i);

            //var str4 = "Hello World ...";         
            //Console.WriteLine(str4.Length);

            //dynamic str5= "Hello World ...";
            //Console.WriteLine(str5.Length);

            //dynamic int1 = 15;
            ////Console.WriteLine(int1.Length); // here it won't show to you a compile error but will be runtime error

            // const 
            const double pi = 3.14;
            // const cannot be declared only must be declared and intiallized
            // const cannot be reassigned
            #endregion

            #region Day2 Part3
            //Math library
            int x = 100;
            Console.WriteLine(Math.Pow(2, 3));
            ////////////////////////////////////////////////////////////////////////////////////////
            // Jump Statments
            // goto
            //start:
            //    Console.BackgroundColor = ConsoleColor.Blue;
            //    Console.ForegroundColor = ConsoleColor.Black;
            //    Console.Clear();
            //    Console.Write("Enter your name :  ");
            //    string str6 = Console.ReadLine();
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.Clear();
            //    Console.WriteLine("Welcome " + str6);
            //    Console.ReadLine();
            //    Console.Clear();
            //    //goto start;
            ////////////////////////////////////////////////////////////////////////////////////////
            //           *)Literals Letters:-
            //-----------------------

            Console.WriteLine("Sayed hawas");
            Console.WriteLine("Sayed       Hawas");
            Console.WriteLine("Sayed\t hawas"); // \t : give you five spaces
            Console.WriteLine("----------------");
            Console.WriteLine("Sayed\n hawas");
            Console.WriteLine("Sayed \"Said\" Hawas");
            Console.WriteLine("c\\folder\\ahmed.doc");
            Console.WriteLine(@"c\folder\ahmed.doc"); // here it will not see the literals 
            Console.WriteLine("\a"); // beep 
            Console.WriteLine("\0"); // Null
            /////////////////////////////////////////////////////////////////////////////////////////////////   
            //Control Flow Program
            //A.Conditional Statments : ?(ternary Operator), if-else , Switch   
            // ternary operator
            Console.Write("Enter Your Age: ");
            int age;
            int.TryParse(Console.ReadLine(), out age);
            var ageCond = (age > 25) ? "Adult" : "Minor";
            Console.WriteLine(ageCond);
            Console.WriteLine(1 > 10 ? "True" : "False");

            /*
            if-else statment
                if(condition){
                    code...
                }else {
                    code....
                }
            */
            Console.Write("Enter Your UserName: ");
            string userName = Console.ReadLine();
            Console.Write("Enter Your Password: ");
            string password = Console.ReadLine();

            if ((userName == "belal" && password == "123") || (userName == "malak" && password == "555"))
            {
                Console.WriteLine("Welcome Admin " + userName);
                if (userName == "belal")
                {
                    Console.WriteLine("Hi " + userName + "....");
                    Console.WriteLine("DateTime is " + DateTime.Now);
                }
            }
            else if ((userName == "ahmed" && password == "222") || (userName == "tamer" && password == "777"))
            {
                Console.WriteLine("Welcome EndUser " + userName);
            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Switch Statment
            /*
             switch(caseExpression) {
                case '<nameofCase>':
                    code..
                break;

                case '<nameofCase>':
                    code..
                break;

                and so on.....
                
                default:
                    code....
                break;
             }
             */
            Console.Write("Enter First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter The Operator: ");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine($"{num1} {op} {num2} = {(num1 + num2)}");
                    break;

                case "-":
                    Console.WriteLine($"{num1} {op} {num2} = {(num1 - num2)}");
                    break;

                case "*":
                    Console.WriteLine($"{num1} {op} {num2} = {(num1 * num2)}");
                    break;

                case "/":
                    Console.WriteLine($"{num1} {op} {num2} = {(num1 / num2)}");
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            #endregion
        }
    }
}
