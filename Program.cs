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
               bool pet1 =int.TryParse(Console.ReadLine(), out int pet);
            
               
               if(pet1 == true)

               {
                   switch(pet)
                   {
                    case 1: Console.WriteLine("You have choosen Cat");
                        
                        break;
                        case 2: Console.WriteLine("You have choosen Dog");
                        break;
                        case 3: Console.WriteLine("")
                   }
               }
        }
    }
}
