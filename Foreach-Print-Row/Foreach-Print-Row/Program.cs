using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Print_Row
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] firstName = null;
            firstName = new string[4];

            for (int i = 0; i < firstName.Length; i++)
            {
                Console.Write("Enter the first name " + " " + i + ":");
                firstName[i] = Console.ReadLine();

            }

            foreach (var row in firstName)
            {
                Console.WriteLine("row value is " + row.ToString());
                

            }

            Console.WriteLine("Press any key to exit ");
            Console.ReadKey();
        }
    }
}
