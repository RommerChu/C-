using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            int exitVar = 1;
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            while (exitVar == 1) { 
                switch (num1)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.Write("Less than 5\n");
                        break;
                    case 6:
                        Console.Write("Bigger than 5\n");
                        break;
                    default:
                        Console.Write("More than 6 or less than zero\n");
                        break;            
                }
            
                Console.WriteLine("To continue press 1");              
                exitVar=Convert.ToInt32(Console.ReadLine());
            }

            // NOT PROPERLY WORKING NEED TO SEARCH HOW TO FIX THIS!!!!!
        }
    }
}
