

namespace Giraffe
{



    class Program
    {

        static void Main(string[] args)
        {

            int[] luckyNumbers = { 4, 8, 15, 16, 42 }; //declare the array
            string[] friends = new string[5]; //declare how many items the array can hold (5)
            friends[0] = "Jim"; //define array value at index 0
            friends[1] = "Kelly";
            friends[2] = "Steve";




            luckyNumbers[1] = 900;
            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[2]);


            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(luckyNumbers[2]);
            Console.WriteLine(luckyNumbers[3]);
            Console.WriteLine(luckyNumbers[4]);
            Console.ReadLine();



        }

    }







}