using System;

namespace Giraffe
{

    class Program
    {

        static void Main(string[] args) //run by default because it is Main
        {
            Console.WriteLine("Enter two integers to be added together. ");
            Console.WriteLine("\nPlease enter the first integer: ");
            int toPass1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter the second integer: ");
            int toPass2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nYour result is: " + PostNums(toPass1, toPass2));

            int[] nums = { toPass1, toPass2 };

            for (int i = 0; i < nums.Length; i++)
            {

                Console.WriteLine(nums[i]);


            }

            Console.ReadLine();





        }


        static int PostNums(int num1, int num2)
        {
            int result = num1 + num2;


            return result;


        }
    }
}

