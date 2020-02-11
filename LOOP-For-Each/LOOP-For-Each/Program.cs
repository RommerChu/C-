using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOOP_For_Each
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array1 = { 1, 2, 4, 6, 10 };

            foreach (int batch in array1)
            {
                Console.Write("item is: " + batch + "\n");
            }
            Console.Write("Press any key to continue");
            Console.ReadKey();

        }
    }
}
