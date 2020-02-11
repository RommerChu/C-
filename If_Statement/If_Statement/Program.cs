using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num3: ");
            int num3 = Convert.ToInt32(Console.ReadLine());


            //EXAMPLE 3
            if (num1 >= num2 && num2 >= num3)
            {
                Console.WriteLine("num1 > num3");
            }
            else if (num2 >= num1 && num1 >= num3)
            {
                Console.WriteLine("num1 < num2");
            }
            else
            {
                Console.WriteLine("num3 < num1");
            }



            //EXAMPLE 2
            //if (num1 >= num2)
            //{
            //    Console.WriteLine("num1 > num3");
            //}
            //else if (num2 >= num1)
            //{
            //    Console.WriteLine("num1 < num2");
            //}
            //else if (num2 >= num3)
            //{
            //    Console.WriteLine("num2 >= num3");
            //}
            //else
            //{
            //    Console.WriteLine("num3 < num2");
            //}


            //EXAMPLE 1
            //if (num2 >= num3)
            //{
            //    Console.WriteLine("num2 >= num3");
            //}
            //else if ()
            //{
            //    Console.WriteLine("num3 < num2");
            //}




            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
