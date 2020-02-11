using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            decimal num2;
            Char char3;

            //TRY PARSE STRING TO INTEGER
            int.TryParse("5", out num1);
            Console.WriteLine("This string becomes an INTEGER: " + num1);
            Console.ReadKey();

            //TRY PARSE STRING TO DECIMAL
            decimal.TryParse("5.1", out num2);
            Console.WriteLine("This is converted to decimal: " + (decimal)num2);
            Console.ReadKey();

            //TRY PARSE STRING TO CHARACTER
            char.TryParse("k", out char3);
            Console.WriteLine("This becomes a CHARACTER: " + char3);
            Console.ReadKey();

        }
    }
}
