using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOOP_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            do
            {
                Console.Clear();// TO CLEAR THE SCREEN
                Console.WriteLine("1 - Sum");
                Console.WriteLine("2 - Sub");
                Console.WriteLine("3 - Exit");
                Console.Write("Enter your selection number: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                

            } while (userInput!=3);
            Console.Write("Press any key to exit");
            Console.ReadKey();

        }
    }
}
