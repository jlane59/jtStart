

namespace Giraffe
{



    class Program
    {

        static void Main(string[] args) //run by default because it is Main
        {
            int cubedNumber = cube(5); //pass a number to be cubed to the cube function and store it's return value
            Console.WriteLine(cubedNumber); //write the stored return value

            Console.ReadLine();



        }

        static int cube(int num) //return an integer method. integer parameter.
        {
            int result = num * num * num;
            return result; //return the result of the cubed number back to the caller

        }





    }







}