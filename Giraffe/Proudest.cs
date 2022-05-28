/*
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
            //objects
            //items
            Swords sword1 = new Swords("Zweihander", 30, "Perfect", "Greatsword");
            //enemies
            MakeSnail snail1 = new MakeSnail( "Mark", "Poor", 100, 100);
            //players
            Player player1 = new Player("Jordan", 200, 1.5, 200, sword1.name, sword1.damage);

            //main variables
            int snailsKilled = 0;

            Console.WriteLine(player1.weaponDamage);
            Console.WriteLine(player1.weaponName);
            try
            {
                while (snail1.health >= 0)
                {
                    Console.WriteLine("The snail has >= 50 health! Get it to <50!");
                    Console.WriteLine("\n1. Attack with " + player1.weaponName + " for " + player1.weaponDamage + " damage.");
                    Console.WriteLine("2. Heal");
                    int actionNum = Convert.ToInt32(Console.ReadLine());
                    if (actionNum == 1 && snail1.health >= 0)
                    {
                        Console.WriteLine("\nYou attack the snail with your " + player1.weaponName + ". -" + player1.weaponDamage + " hp!");
                        
                        snail1.health = snail1.health - player1.weaponDamage;
                        Console.WriteLine("It has exactly " + snail1.health + " health remaining!");
                    }
                    else if (actionNum == 2 && snail1.health >= 0)
                    {
                        Console.WriteLine("You heal the snail! +3 HP!");
                        snail1.health = snail1.health + 3;
                        Console.WriteLine("It has exactly " + snail1.health + " health remaining!");
                    }
                    if (snail1.health <= 0)
                    {
                        snailsKilled = snailsKilled + 1;
                    }
                }
                Console.WriteLine("Broken out - snail dead!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //print snail kills that player got from the while loop
            Console.WriteLine("You have killed " + snailsKilled + " snails");
            Console.WriteLine("If you kill 2 snails, then you can learn the secret word!");







            Console.ReadLine();


        }
        //readline last always
        //end of main method
        //end of class
    }
    //end of namespace
}

*/