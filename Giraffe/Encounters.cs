using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Encounters
    {


        MakeSnail snail1 = new MakeSnail("Mark", "Poor", 30, 30);
        


        public static void EncounterSnail(string aName, string aQuality, double aHealth, double aEnergy)
        {
            Console.WriteLine("You've encountered a snail! His name = " + aName + ". His quality = " + aQuality + ". His health = " + aHealth + ". And his energy = " + aEnergy + ". Are you sure you wanna fight this guy?");
            Console.WriteLine("1. Yes \n 2. No");
            try
            {
                int actionNum = Convert.ToInt32(Console.ReadLine());
                if (actionNum == 1)
                {
                    Console.WriteLine("You're attacking the snail! Good luck!");


                }
                else if (actionNum == 2)
                {
                    Console.WriteLine("You're retreating! Patchetic.");

                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }





        }





    }


}
