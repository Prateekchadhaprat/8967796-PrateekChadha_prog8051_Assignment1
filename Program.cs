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
                            
                            int hungercat = 5; // these are pet attributes
                            int happinesscat = 5;
                            int healthcat = 5;


                            Console.WriteLine("Main Menu:"); // main menue for pet care actions
                            Console.WriteLine("1. Feed \n2. Play with \n3. Let rest \n4. Check status \n5. Exit ");

                            bool actioncatcheck = int.TryParse(Console.ReadLine(), out int cataction); //user input for action selections

                            if (actioncatcheck)
                            {
                                switch (cataction)
                                {
                                    case 1:

                                        if (hungercat - 2 < 1)
                                        {
                                            hungercat = 1;
                                        }
                                        else
                                        {
                                            hungercat = hungercat - 2;
                                        }
                                        if (healthcat + 1 > 10) // using if to ensure health doesn't exceed to 10
                                        {
                                            healthcat = 10;
                                        }
                                        else
                                        {
                                            healthcat = healthcat + 1;
                                        }
                                        Console.WriteLine($"You fed {petname} His hunger is decreased, and health improves slightly ");
                                        break;

                                    case 2:

                                        if (happinesscat - 1 < 1) // to ensure health doesn't go below 1 
                                        {
                                            happinesscat = 1;
                                        }
                                        else
                                        {
                                            happinesscat = happinesscat - 1;

                                        }
                                        //  hungercat = hungercat + 1 > 100 ? 100 : hungercat + 1;
                                        if (hungercat + 1 > 10) // to ensure hunger doesn't exceed 10
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
                                        if (happinesscat - 1 < 1)
                                        {
                                            happinesscat = 1;
                                        }
                                        else
                                        {
                                            happinesscat = happinesscat - 1;
                                        }
                                        Console.WriteLine($"Your {petname} is resting. his health is improving and happniness is decreasing slightly\".");
                                        break;
                                    case 4:
                                        Console.WriteLine($"\n{petname}status");
                                        Console.WriteLine($"Hunger:- {hungercat}/10");
                                        Console.WriteLine($"Happiness:- {happinesscat}/10");
                                        Console.WriteLine($"Health:-{healthcat}/10");

                                        if (hungercat <= 2)
                                            Console.WriteLine("Warning : Hunger status is critically low for your pet");
                                        if (happinesscat <= 2)
                                            Console.WriteLine("Warning: Happiness status is critically low for your pet");
                                        if (healthcat <= 2)
                                            Console.WriteLine("Warning: Health status is critically low for your pet");
                                        break;
                                    case 5:
                                        Console.WriteLine($"Thank you, exiting the simulator. Bye,{petname}");
                                        Environment.Exit(0);
                                        break;
                                    default:
                                        Console.WriteLine("Invalid choice, please choose option from 1 to 5 only");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input, please choose 1-5");
                            }                                   
                         break;
                    
                        case 2:
                            Console.WriteLine("your choice is {0}", pettype);
                            Console.WriteLine("You have choosen Dog,What would you like to name your pet?");
                            String petnamedog = Console.ReadLine();

                            Console.WriteLine("Welcome, {0} Let's take a good care of it", petnamedog);

                            int hungerdog = 5; // these are pet attributes
                            int happinessdog = 5;
                            int healthdog = 5;


                            Console.WriteLine("Main Menu:"); // main menue for pet care actions
                            Console.WriteLine("1. Feed \n2. Play with \n3. Let rest \n4. Check status \n5. Exit ");

                            bool actiondogcheck = int.TryParse(Console.ReadLine(), out int dogaction); //user input for action selections

                            if (actiondogcheck)
                            {
                                switch (dogaction)
                                {
                                    case 1:

                                        if (hungerdog - 2 < 1)
                                        {
                                            hungerdog = 1;
                                        }
                                        else
                                        {
                                            hungerdog = hungerdog - 2;
                                        }
                                        if (healthdog + 1 > 10) // using if to ensure health doesn't exceed to 10
                                        {
                                            healthdog = 10;
                                        }
                                        else
                                        {
                                            healthdog = healthdog + 1;
                                        }
                                        Console.WriteLine($"You fed {petnamedog} His hunger is decreased, and health improves slightly ");
                                        break;

                                    case 2:

                                        if (happinessdog - 1 < 1) // to ensure health doesn't go below 1 
                                        {
                                            happinessdog = 1;
                                        }
                                        else
                                        {
                                            happinessdog = happinessdog - 1;

                                        }
                                        //  hungercat = hungercat + 1 > 100 ? 100 : hungercat + 1;
                                        if (hungerdog + 1 > 10) // to ensure hunger doesn't exceed 10
                                        {
                                            hungerdog = 10;
                                        }
                                        else
                                        {
                                            hungercat = hungerdog + 1;
                                        }
                                        Console.WriteLine($"You played with{petnamedog} , his happiness increases and hunger slightly increases");
                                        break;

                                    case 3:
                                        if (healthdog + 2 > 10)// to ensure health doesn't exceed 10
                                        {
                                            healthdog = 10;
                                        }
                                        else
                                        {
                                            healthdog = healthdog + 2;
                                        }
                                        if (happinessdog - 1 < 1)
                                        {
                                            happinessdog = 1;
                                        }
                                        else
                                        {
                                            happinessdog = happinessdog - 1;
                                        }
                                        Console.WriteLine($"Your {petnamedog} is resting. his health is improving and happniness is decreasing slightly\".");
                                        break;
                                    case 4:
                                        Console.WriteLine($"\n{petnamedog}status");
                                        Console.WriteLine($"Hunger:- {hungerdog}/10");
                                        Console.WriteLine($"Happiness:- {happinessdog}/10");
                                        Console.WriteLine($"Health:-{healthdog}/10");

                                        if (hungerdog <= 2)
                                            Console.WriteLine("Warning : Hunger status is critically low for your pet");
                                        if (happinessdog <= 2)
                                            Console.WriteLine("Warning: Happiness status is critically low for your pet");
                                        if (healthdog <= 2)
                                            Console.WriteLine("Warning: Health status is critically low for your pet");
                                        break;
                                    case 5:
                                        Console.WriteLine($"Thank you, exiting the simulator. Bye,{petnamedog}");
                                        Environment.Exit(0);
                                        break;
                                    default:
                                        Console.WriteLine("Invalid choice, please choose option from 1 to 5 only");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input, please choose 1-5");
                            }

                            break;

                        case 3:
                            Console.WriteLine("your choice is {0}", pettype);
                            Console.WriteLine("You have choosen Rabbit,What would you like to name your pet?");
                            String petnamerabbit = Console.ReadLine();

                            Console.WriteLine("Welcome, {0} Let's take a good care of it", petnamerabbit);

                            int hungerrabbit = 5; // these are pet attributes
                            int happinessrabbit = 5;
                            int healthrabbit = 5;


                            Console.WriteLine("Main Menu:"); // main menue for pet care actions
                            Console.WriteLine("1. Feed \n2. Play with \n3. Let rest \n4. Check status \n5. Exit ");

                            bool actionrabbitcheck = int.TryParse(Console.ReadLine(), out int rabbitaction); //user input for action selections

                            if (actionrabbitcheck)
                            {
                                switch (rabbitaction)
                                {
                                    case 1:

                                        if (hungerrabbit - 2 < 1)
                                        {
                                            hungerrabbit = 1;
                                        }
                                        else
                                        {
                                            hungerrabbit = hungerrabbit - 2;
                                        }
                                        if (healthrabbit + 1 > 10) // using if to ensure health doesn't exceed to 10
                                        {
                                            healthrabbit = 10;
                                        }
                                        else
                                        {
                                            healthrabbit = healthrabbit + 1;
                                        }
                                        Console.WriteLine($"You fed {petnamerabbit} His hunger is decreased, and health improves slightly ");
                                        break;

                                    case 2:

                                        if (happinessrabbit - 1 < 1) // to ensure health doesn't go below 1 
                                        {
                                            happinessrabbit = 1;
                                        }
                                        else
                                        {
                                            happinessrabbit = happinessrabbit - 1;

                                        }
                                        //  hungercat = hungercat + 1 > 100 ? 100 : hungercat + 1;
                                        if (hungerrabbit + 1 > 10) // to ensure hunger doesn't exceed 10
                                        {
                                            hungerrabbit = 10;
                                        }
                                        else
                                        {
                                            hungerrabbit = hungerrabbit + 1;
                                        }
                                        Console.WriteLine($"You played with{petnamerabbit} , his happiness increases and hunger slightly increases");
                                        break;

                                    case 3:
                                        if (healthrabbit + 2 > 10)// to ensure health doesn't exceed 10
                                        {
                                            healthrabbit = 10;
                                        }
                                        else
                                        {
                                            healthrabbit = healthrabbit + 2;
                                        }
                                        if (happinessrabbit - 1 < 1)
                                        {
                                            happinessrabbit = 1;
                                        }
                                        else
                                        {
                                            happinessrabbit = happinessrabbit - 1;
                                        }
                                        Console.WriteLine($"Your {petnamerabbit} is resting. his health is improving and happniness is decreasing slightly\".");
                                        break;
                                    case 4:
                                        Console.WriteLine($"\n{petnamerabbit}status");
                                        Console.WriteLine($"Hunger:- {hungerrabbit}/10");
                                        Console.WriteLine($"Happiness:- {happinessrabbit}/10");
                                        Console.WriteLine($"Health:-{healthrabbit}/10");

                                        if (hungerrabbit <= 2)
                                            Console.WriteLine("Warning : Hunger status is critically low for your pet");
                                        if (happinessrabbit <= 2)
                                            Console.WriteLine("Warning: Happiness status is critically low for your pet");
                                        if (healthrabbit <= 2)
                                            Console.WriteLine("Warning: Health status is critically low for your pet");
                                        break;
                                    case 5:
                                        Console.WriteLine($"Thank you, exiting the simulator. Bye,{petnamerabbit}");
                                        Environment.Exit(0);
                                        break;
                                    default:
                                        Console.WriteLine("Invalid choice, please choose option from 1 to 5 only");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input, please choose 1-5");
                            }

                            break;
                        default:
                            Console.WriteLine("You have to choose from only these three");
                            break;
                    }


                }
            }

            else
            {
                Console.WriteLine("Invalid input. Please choose a number from 1 to 3.");
            }
        
        }

    }
}
    

