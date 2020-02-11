using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintArray
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] firstName = null;
            firstName = new String[4];
            for (int i=0; i<firstName.Length; i++) 
            {
                Console.Write("Enter the first name" + i + ";");
                firstName[i] = Console.ReadLine();
            }

            //To print array of names
            Console.WriteLine(string.Join("\n", firstName));


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
