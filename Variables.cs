

namespace Giraffe
{



    class Program
    {

        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";
            char grade = 'A';
            int age = -30;
            double gpa = 3.2;
            bool isMale = false;
            string phrase2 = "Giraffe Academy" + " is cool";

            Console.WriteLine(age);
            Console.WriteLine(phrase2);
            Console.WriteLine("Phrase 2 length = " + phrase2.Length + " characters");
            Console.WriteLine(phrase2.ToUpper());
            Console.WriteLine("Does Phrase2 contain the word academy? " + phrase2.Contains("Academy"));
            Console.WriteLine("Giraffe \nAcademy");
            Console.WriteLine("Elephant" + " Academia");
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.Substring(8, 3));






            Console.ReadLine();






        }

    }







}