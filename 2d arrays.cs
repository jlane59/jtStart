
using System;

namespace Giraffe
{

    class Program
    {

        static void Main(string[] args)
        //ran by default because it is Main
        {
            int[,] numberGrid =
            {
                {1,2},
                {3,4},
                {5,6}
            };

            //if you dont know what elements you want to go into a 2d array when it's iniaitiliazed, then you can create it this way. [2,3] 2 rows, 3 columns. 2 elements that contain 3 elements inside.
            int[,] myArray = new int[2, 3];

            Console.WriteLine(numberGrid[0, 1]);


            Console.ReadLine();







            //end of main method
        }
        //end of class
    }
    //end of namespace
}


