
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

                string[] codeNotes = { "How to code in C#: \n C# is a very powerful language and it is very specific, watch freecodecamp on YT for tutorials! ", "RedShoes" };

                double[] storageNums = { 1.1, 3.2 };

                Console.WriteLine("Welcome to my note taking program!");

                Console.WriteLine("\nType the number of the storage you want to access");

                Console.WriteLine("\n" + "1. " + nameof(codeNotes));

                Console.WriteLine("\n" + "2. " + nameof(storageNums));

                int accessNum = Convert.ToInt32(Console.ReadLine());

                switch (accessNum)

                {
                    case 1:
                        //codeNotes
                        Console.WriteLine("Accessing codeNotes");

                        for (int i = 0; i < codeNotes.Length; i++)
                        {
                            Console.WriteLine("\n" + codeNotes[i]);
                        }
                        break;

                    case 2:
                        //storageNums
                        Console.WriteLine("Accessing storageNums");

                        for (int i = 0; i < storageNums.Length; i++)
                        {

                            Console.WriteLine(storageNums[i]);
                        }

                        break;


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();



        }



    }
}

