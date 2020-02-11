using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numericArray = { 7, 5, 2, 12, 15, 1 };


            //OPTION 1
            Array.Sort(numericArray);
            Console.WriteLine(String.Join(",", numericArray));
            Console.WriteLine(String.Join(",", numericArray.Reverse()));
            Console.ReadKey();

            //OPTION2
            Array.Sort(numericArray);
            Console.WriteLine("First Array: [{0}] ", String.Join(",", numericArray));
            Array.Reverse(numericArray);
            Console.WriteLine("First Array: [{0}] ", String.Join(",", numericArray));
            Console.ReadKey();








        }
    }
}
