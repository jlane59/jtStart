using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Book
    {
        //class attributes (pieces of info describing what a book is)
        public string title;
        public string author;
        public int pages;


        //constructor method. constructor is a special method inside class called when you create an object

        //declare arguments input. 
        public Book(string aTitle, string aAuthor, int aPages)
        {
            //assign object values from the arguments during construction
            title = aTitle;
            author = aAuthor;
            pages = aPages;

            //Console.WriteLine(name);


        }

    }
}
