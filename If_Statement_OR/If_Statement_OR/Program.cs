using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement_OR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            //AND OPERATOR
            if (age1 > 40 && age1 < 80)
            {
                Console.WriteLine("Qualify for heart attack");
            }

            //OR OPERATOR
            if (age1 > 20 || age1 > 16)
            {
                Console.WriteLine("You are strong");
            }

            //OR OPERATOR
            if (age1 > 16)
            {
                Console.WriteLine("You can vote");
            }

            Console.ReadKey();

        }
    }
}
