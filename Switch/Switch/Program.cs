using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //int exit = 1;
            Console.Write("Please enter your age: ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            switch(age1)
                {
                //less than 12
                case (age1<12):
                    Console.WriteLine("Kids");
                    break;
                // less than 21
                case 21:
                    Console.WriteLine("Teenager");
                    break;
                // less than 60
                case 60:
                    Console.WriteLine("You are still young");
                    break;
                // less than 80
                case 80:
                    Console.WriteLine("You are still young");
                    break;
                default:
                    Console.WriteLine("You are senior");
                    break;

            };//while (exit<11 && exit>81)
            //    {
            //    Console.Write("Please enter your age: ");
            //    exit = Convert.ToInt32(Console.ReadLine());
            //    }
            Console.ReadKey();
            
            

        }
    }
}
