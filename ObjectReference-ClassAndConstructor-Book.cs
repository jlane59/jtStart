using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{

    class Program
    {

        static void Main(string[] args)
        //ran by default because it is Main
        {

            Book book1 = new Book("Mike", "mike", 300);
            book1.title = "Harry Potter";
            book1.author = "J.K Rowling";
            book1.pages = 400;

            Book book2 = new Book("John", "steve", 900);
            book2.title = "Hry Pter";
            book2.author = "Rowling";
            book2.pages = 420;



            Console.WriteLine(book1.pages);


            Console.ReadLine();







            //end of main method
        }
        //end of class
    }
    //end of namespace
}


