

namespace Giraffe
{



    class Program
    {

        static void Main(string[] args) //run by default because it is Main
        {

            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male!");

            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not male but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");

            }
            Console.ReadLine();

        }







    }







}

