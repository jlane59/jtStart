using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Chef
    {
        
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes a salad");
        }


        //virtual means it can be overridden in subclasses
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes bbq ribs");
        }




    }
}
