using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Age_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            //age1 = age1/10;  THIS IS MUCH BETTER
            //switch(age1);     THIS IS MUCH BETTER

                switch (age1>60?6:age1>50?5:age1>40?4:age1>30?3:age1>20?2:age1>10?1:0)
                {
                    case 0: 
                        Console.Write("Kids\n");
                        break;
                    case 1:
                        Console.Write("Teen\n");
                        break;
                    case 2:
                        Console.Write("Youth\n");
                        break;
                    case 3:
                        Console.Write("Adult\n");
                        break;
                    case 4:
                        Console.Write("Wise man say\n");
                        break;
                    default:
                        Console.Write("senior\n");
                        break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
            

        }
    }
}
