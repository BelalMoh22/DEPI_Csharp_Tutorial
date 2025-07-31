namespace Day4Lab
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
            Console.WriteLine("--------------------------------------");
            try
            {
                Console.WriteLine(div(100, 0));
                Console.ReadLine();
            }
            catch (Exception ex) { 
                Console.WriteLine($"{ex.Message}");
            }
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
}
