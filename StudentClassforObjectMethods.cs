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



            Student student1 = new Student("Steve", "Engineer", 3.5);
            Student student2 = new Student("Jim", "Technician", 4.0);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            Console.ReadLine();


            //paste this into a program to have it check for honors

            /*
             
            Student student1 = new Student("Steve", "Engineer", 3.5);
            Student student2 = new Student("Jim", "Technician", 4.0);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());


            */




            //end of main method
        }
        //end of class
    }
    //end of namespace
}


