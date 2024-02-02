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
                            Console.WriteLine("your choice is {0}", pettype);
                            Console.WriteLine("You have choosen Cat,What would you like to name your pet?");
                            String petname = Console.ReadLine();

                            Console.WriteLine("Welcome, {0} Let's take a good care of it", petname);
                            
                            int hungercat = 50; // these are pet attributes
                            int happinesscat = 50;
                            int healthcat = 50;


                            Console.WriteLine("Main Menu:"); // main menue for pet care actions
                            Console.WriteLine("1. Feed \n2. Play with \n3. Let rest \n4. Check status \n5. Exit ");

                            bool actioncatcheck = int.TryParse(Console.ReadLine(), out int cataction); //user input for action selections
                  
                           if (actioncatcheck)
                              {
                                  switch (cataction)
                                  {
                                      case 1:

                                    if(hungercat - 2 < 1)
                                        {
                                            hungercat = 1;
                                        }
                                        else
                                        {
                                            hungercat= hungercat - 2;
                                        }
                                    if(healthcat + 1 > 10) // using if to ensure health doesn't exceed to 10
                                        {
                                            healthcat= 10;
                                        }
                                        else
                                        {
                                            healthcat = healthcat + 1;
                                        }
                                        Console.WriteLine($"You fed {petname} His hunger is decreased, and health improves slightly ");                              
                                       break;

                                     case 2: 

                                        if(happinesscat - 1< 1) // to ensure health doesn't go below 1 
                                        {
                                            happinesscat = 1;
                                        }    
                                        else
                                        {
                                            happinesscat= happinesscat - 1; 

                                        }
                                      //  hungercat = hungercat + 1 > 100 ? 100 : hungercat + 1;
                                        if (hungercat +1> 10) // to ensure hunger doesn't exceed 10
                                        {
                                            hungercat = 10;
                                        }
                                        else
                                        {
                                            hungercat = hungercat + 1;
                                        }                                      
                                    Console.WriteLine($"You played with{petname} , his happiness increases and hunger slightly increases");
                                      break;

                            case 3:
                                     if (healthcat + 2 > 10)// to ensure health doesn't exceed 10
                                        {
                                            healthcat = 10;
                                        }
                                        else
                                        {
                                            healthcat = healthcat + 2;
                                        }
                                     if (happinesscat -1 <1)
                                        {
                                            happinesscat = 1;
                                        }
                                     else
                                        {
                                            happinesscat = happinesscat - 1;
                                        }


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
    

