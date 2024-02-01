    using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8967796_PrateekChadha_prog8051_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type of Pet");
            Console.WriteLine("1. Cat \n2. Dog \n3. Rabbit");
            bool pettypecheck = int.TryParse(Console.ReadLine(), out int pettype); // using bool validation to ensure correct type of pet by user


            if (pettypecheck == true)

            {
                while (true)// using while loop for infinite pet care actions.
                {

                    switch (pettype)
                    {
                        case 1:
                            Console.WriteLine("your choice is {0}", pet);
                            Console.WriteLine("You have choosen Cat,What would you like to name your pet?");
                            String petname = Console.ReadLine();

                            Console.WriteLine("Welcome, {0} Let's take a good care of it", petname);
                            //pet attribute 
                            int hungercat = 50;
                            int happinesscat = 50;
                            int healthcat = 50;


                            Console.WriteLine("Main Menu:");
                            Console.WriteLine("1. Feed \n2. Play with \n3. Let rest \n4. Check status \n5. Exit ");


                            /*  bool mm1 = int.TryParse(Console.ReadLine(), out int mm);
                              if (mm1 == true)
                              {
                                  switch (mm)
                                  {
                                      case 1:
                                          Console.WriteLine("You have choosen feeding{0}", mm);
                                          Console.WriteLine("You fed, pet His hunger is decreases, and health improves slightly");
                                        break;
                                     case 2: 
                            Console.WriteLine("You have choosen Playing{0}, mm)";
                            Console.WriteLine("You played pet, his happiness increases and hunger slightly increases");
                            break;

                            case 3:
                            Console.WriteLine("You have choosen Resting {0}, mm)";
                            Console.WriteLine("pet is resting, his health is improving and happniness is decreasing slightly");




 */
                            break;


                        case 2:
                            Console.WriteLine("your choice is {0}", pet);
                            Console.WriteLine("You have choosen Dog,What would you like to name your pet?");
                            String petname1 = Console.ReadLine();

                            Console.WriteLine("Welcome, {0} Let's take a good care of it", petname1);

                            Console.WriteLine("Main Menu:");
                            break;

                        case 3:
                            Console.WriteLine("your choice is {0}", pet);
                            Console.WriteLine("You have choosen Rabbit,What would you like to name your pet?");
                            String petname2 = Console.ReadLine();

                            Console.WriteLine("Welcome, {0} Let's take a good care of it", petname2);

                            Console.WriteLine("Main Menu:");
                            break;
                        default:
                            Console.WriteLine("You have to choose from only these three");
                            break;
                    }


                }
            }
        }
    }
}
    

