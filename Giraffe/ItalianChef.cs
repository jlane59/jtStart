using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    //colon denotes inheritance. Superclass = chef, subclass = italianchef
    internal class ItalianChef : Chef
    {

        public void MakePasta()
        {
            Console.WriteLine("The italian chef makes pasta");

        }
      

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The italian chef makes chicken parm");
        }

    }
}
