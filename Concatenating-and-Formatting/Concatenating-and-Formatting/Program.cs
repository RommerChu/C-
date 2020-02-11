using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenating_and_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            String firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            String lastName = Console.ReadLine();

            Console.Write("Enter your salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            String fullName = string.Concat(firstName, " ", lastName);

            Console.WriteLine("Full name is: " + fullName);
            //TO IDENTIFY IT IS A VARIABLE USE CURLY BRACE {0:F2}
            //F2 ---> MEANING TWO FRACTIONS
            Console.WriteLine("Salary is: " + string.Format("{0:F2}", salary));
            Console.Write("Press any key to exit");
            Console.ReadKey();

        }
    }
}
