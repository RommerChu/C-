using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRING_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first name: ");
            String name1 = Console.ReadLine();

            Console.Write("Enter the second name: ");
            String name2 = Console.ReadLine();

            if (string.Compare(name1, name2) == 0)
            {
                Console.Write("There names are SIMILAR");
            }

            /*--------------TO IGNORE CASE SENSITIVE------------------------------------
             * 
             if (string.Compare(name1, name2,StringComparison.OrdinalIgnoreCase) == 0)
            {
                Console.Write("There names are SIMILAR");
            }

             --------------------------------------------------------------------------*/
            else
            {
                Console.Write("There names are NOT SIMILAR");
            }
            Console.ReadKey();
        }
    }
}
