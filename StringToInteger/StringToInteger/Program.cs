using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is to print
            Console.Write("Enter number1: ");
            
            //This is input from the user
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num6 = Convert.ToInt32(Console.ReadLine());

            //TO PRINT THE RESULT
            Console.WriteLine("Max is: " + Math.Max(num5, num6));
            Console.WriteLine("Min is: " + Math.Min(num5, num6));
            
            //THIS IS TO GET ROUND NUMBER MAX AND MIN
            Console.Write("Enter decimal number: ");
            decimal num7 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ceiling is " + Math.Ceiling(num7) + "\n" + "Floor is: " + Math.Floor(num7));
            Console.ReadKey();
        }
    }
}
