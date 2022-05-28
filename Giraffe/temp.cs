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


            //Console.WriteLine(CustomTools.Add(2, 3));
            //Console.WriteLine(CustomTools.ConcatenateStrings("Hello!", "Yes!"));



            //Phone phone1 = new Phone("yeet", "za", "hello1");



            //Console.WriteLine(phone1.manufacturer);



            Snail snail1 = new Snail("Mark", "Poor", 100, 100);
            Console.WriteLine("Snail health = " + snail1.health);
            snail1.health--;
            Console.WriteLine("Reducing snail health by 1 point and reprinting.");
            Console.WriteLine("Snail health = " + snail1.health);

            Console.WriteLine("Reducing snail health by 4");


            snail1.health = snail1.health - 3;
            Console.WriteLine("Snail health = " + snail1.health);


            //prompt damage

            do
            {

                Console.WriteLine("Please input a value to set the snail's health to");
                int input1 = Convert.ToInt32(Console.ReadLine());
                snail1.health = snail1.health + input1;


            } while (snail1.health <= 50);



            do
            {

                try
                {
                    Console.WriteLine("\n" + "Would you like to attack the snail?");
                    Console.WriteLine("0: Attack (-3 hp) ");
                    Console.WriteLine("1: Heal (+1 hp) ");
                    int actionNum = Convert.ToInt32(Console.ReadLine());

                    switch (actionNum)
                    {
                        case 0:
                            //damage
                            snail1.health = snail1.health - 3;
                            Console.WriteLine("3 damage dealt");
                            Console.WriteLine("Snail health = " + snail1.health);
                            break;

                        case 1:
                            //heal
                            snail1.health = snail1.health + 3;
                            Console.WriteLine("3 health healed!");
                            Console.Write("Snail health = " + snail1.health);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                try
                {
                    Console.WriteLine("\n" + "Would you like to attack the snail?");
                    Console.WriteLine("0: Attack (-3 hp) ");
                    Console.WriteLine("1: Heal (+1 hp) ");
                    int actionNum = Convert.ToInt32(Console.ReadLine());

                    switch (actionNum)
                    {
                        case 0:
                            //damage
                            snail1.health = snail1.health - 3;
                            Console.WriteLine("3 damage dealt");
                            Console.WriteLine("Snail health = " + snail1.health);
                            break;
                        case 1:
                            //heal
                            snail1.health = snail1.health + 3;
                            Console.WriteLine("3 health healed!");
                            Console.Write("Snail health = " + snail1.health);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();

            } while (snail1.health <= 50);





        }


        //readline last always

        //end of main method

        //end of class
    }
    //end of namespace
}
*/