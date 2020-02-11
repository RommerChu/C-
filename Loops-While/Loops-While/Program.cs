using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            while (age <= 60)
            {
                Console.WriteLine("Your age is " + age + "\nEnter another age: ");
                age = Convert.ToInt32(Console.ReadLine());            
            }
            Console.WriteLine("age is older thata 59, \nPress any key to exit");
            Console.ReadKey();

        }
    }
}
