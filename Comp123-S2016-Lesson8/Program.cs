using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*         EXCEPTION HANDLING - Lesson 8 - IO Handling Next Week!!             */
namespace Comp123_S2016_Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            { 
            Console.WriteLine("Enter an Integer: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another Integer: ");
            int second = Convert.ToInt32(Console.ReadLine());
                //the f2 stands for the results decimal place 
            Console.WriteLine("Result: {0:f2}", DivideAndShow(first, second));
        }
            //Only for format errors, this message will display
            catch (FormatException exception)
        {
               Console.WriteLine("Error: Invalid Input, " + exception.Message);
        }
            ///Number too long error
            catch(OverflowException overflow)
            {
                Console.WriteLine("Error: ,", overflow.Message);
            }


        }


        private static double DivideAndShow(int numerator, int denominator)
        {
            try
            {
                double result = numerator / denominator;
                /*double result = Convert.ToDouble (numerator) / convert.ToDouble (Denominator)*/
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
                return 0f;
            }
        }
    }
}
