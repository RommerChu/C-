using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write("Enter first number: ");
            String num1Str = Console.ReadLine();
            int num1 = int.Parse(num1Str);
            int num1Class = Convert.ToInt32(num1Str);            
            //---------------------------------------------------------------------
            Console.Write("Enter second number: ");
            int num2 = Console.Read();
            //---------------------------------------------------------------------
            Console.WriteLine("num1 is: " + num2 +  " " + "num2Class is: " + num1Class);
            Console.ReadKey();


        }
    }
}
