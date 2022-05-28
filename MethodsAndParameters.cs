

namespace Giraffe
{



    class Program
    {

        static void Main(string[] args) //run by default
        {

            SayHi("Mike", 33); //parameter values for method passed in
            SayHi("John", 56);
            SayHi("Tom", 12);
            Console.ReadLine();



        }

        static void SayHi(string name, int age) //needs to be called. method declared, parameters declared.
        {
            Console.WriteLine("Hello " + name + " you are " + age + " years old");


        }






    }







}