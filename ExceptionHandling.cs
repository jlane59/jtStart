
using System;

namespace Giraffe
{

    class Program
    {

        static void Main(string[] args)
        //ran by default because it is Main
        {

            try
            {

                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);

            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message + "\nPlease do not input letters.");

            }
            finally
            {


            }






            Console.ReadLine();







            //end of main method
        }
        //end of class
    }
    //end of namespace
}


