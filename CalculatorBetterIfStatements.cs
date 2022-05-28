

namespace Giraffe
{

    class Program
    {

        static void Main(string[] args) //run by default because it is Main
        {

            Console.WriteLine("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            Console.WriteLine("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num1 + num2);

            }
            else if (op == "-")
            {

                Console.Write(num1 - num2);
            }
            else if (op == "/")
            {
                Console.Write(num1 / num2);

            }
            else if (op == "*")
            {
                Console.Write(num1 * num2);

            }
            else
            {
                Console.WriteLine("Invalid operator or number");

            }


            Console.ReadLine();


        }

    }
}

