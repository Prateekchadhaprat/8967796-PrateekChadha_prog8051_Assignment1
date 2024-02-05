using System;

namespace _8967796_PrateekChadha_prog8051_Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Displaying  options for pet types

            Console.WriteLine("Please choose a type of Pet");
            Console.WriteLine("1. Cat \n2. Dog \n3. Rabbit");

            // Using bool validation to ensure correct type of pet by user
            bool pettypecheck = int.TryParse(Console.ReadLine(), out int pettype); // using bool validation to ensure correct type of pet by user

            int hunger = 5; // these are pet attributes
            int happiness = 5;
            int health = 5;

            string petName = string.Empty;

            switch (pettype) // Using switch case to handle user input for pet type selection
            {
                case 1:
                    Console.WriteLine("your choice is {0}", pettype);
                    Console.WriteLine("You have choosen Cat,What would you like to name your pet?");
                    petName = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("your choice is {0}", pettype);
                    Console.WriteLine("You have choosen Dog,What would you like to name your pet?");
                    petName = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("your choice is {0}", pettype);
                    Console.WriteLine("You have choosen Rabbit,What would you like to name your pet?");
                    petName = Console.ReadLine();
                    break;
            }

            Console.WriteLine("Welcome, {0} Let's take a good care of it", petName);

            while (true) // Implemented main loop for pet care actions.
            {
                Console.WriteLine("Main Menu:"); // main menu for pet care actions
                Console.WriteLine("1. Feed \n2. Play with \n3. Let rest \n4. Check status \n5. Exit ");

                bool actioncheck = int.TryParse(Console.ReadLine(), out int action); //user input for action selections

                if (actioncheck)
                {
                    // for handling user selected actions implemnted another switch in if condition
                    switch (action) 
                    {
                        case 1: // Feeding the pet


                            if (hunger - 1 < 1) //// Adjusting hunger and health attributes
                            {
                                hunger = 1;
                            }
                            else
                            {
                                hunger = hunger - 1;
                            }
                            if (health + 1 > 10) // using if to ensure health doesn't exceed to 10
                            {
                                health = 10;
                            }
                            else
                            {
                                health = health + 1;
                            }
                            Console.WriteLine($"You fed {petName} His hunger is decreased, and health improves slightly ");
                            break;

                        case 2: // Playing with pet

                            if (happiness - 1 < 1)  // Adjusting happiness and hunger attributes
                            {
                                happiness = 1;
                            }
                            else
                            {
                                happiness = happiness + 1;

                            }
                            //  hungercat = hungercat + 1 > 100 ? 100 : hungercat + 1;
                            if (hunger + 1 > 10) // to ensure hunger doesn't exceed 10
                            {
                                hunger = 10;
                            }
                            else
                            {
                                hunger = hunger + 1;
                            }
                            Console.WriteLine($"You played with{petName} , his happiness increases and hunger slightly increases");
                            break;

                        case 3: // Letting the pet rest


                            if (health + 1 > 10) // Adjusting health and happiness attributes
                            {
                                health = 10;
                            }
                            else
                            {
                                health = health + 1;
                            }
                            if (happiness - 1 < 1)
                            {
                                happiness = 1;
                            }
                            else
                            {
                                happiness = happiness - 1;
                            }
                            Console.WriteLine($"Your {petName} is resting. his health is improving and happniness is decreasing slightly\".");
                            break;

                        case 4: // Checking and displaying pet status

                            Console.WriteLine($"\n{petName}status");
                            Console.WriteLine($"Hunger:- {hunger}/10");
                            Console.WriteLine($"Happiness:- {happiness}/10");
                            Console.WriteLine($"Health:-{health}/10");

                            // Displaying warnings for critical statuses

                            if (hunger >= 8)
                                Console.WriteLine("Warning : Hunger status is critically high for your pet");
                            if (happiness <= 2)
                                Console.WriteLine("Warning: Happiness status is critically low for your pet");
                            if (health <= 2)
                                Console.WriteLine("Warning: Health status is critically low for your pet");
                            break;
                        case 5: // // Exiting from the game
                            Console.WriteLine($"Thank you, exiting the simulator. Bye,{petName}");
                            
                            return;
                       
                        default:
                            Console.WriteLine("Invalid choice, please choose option from 1 to 5 only");
                            break;

                    }

                }
                else
                {
                    Console.WriteLine("Invalid input, please choose 1-5");
                }

                // Console.WriteLine("You want to continue or not, 1 for yes and 0 for no");
                // bool isContinue = int.TryParse(Console.ReadLine(), out wannaContinue);
            }

        }

    }
}


