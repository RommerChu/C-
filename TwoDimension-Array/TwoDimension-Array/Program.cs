using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimension_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //JAGGED OR RUGGED TWO DIMENTIONAL ARRAY
            int[][] twoDA = new int[3][];

            //ENTER DATA TO GET ROW
            for (int row = 0; row < twoDA.Length; row++)
            {
                twoDA[row] = new Int32[3];
                //TO GET THE COLUMN
                for (int col = 0; col < twoDA[row].Length; col++)
                {
                    Console.Write("TWO-DIMENSIONAL-ARRAY [" + row + "][" + col +"]=");
                    twoDA[row][col] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }

            //TO PRINT USING FOR LOOP
            for (int row=0; row<twoDA.Length; row++) 
            {
                Console.WriteLine("this is array " + String.Join(",", twoDA[row]));                
            }

            //TO PRINT INDIVIDUALLY
            Console.WriteLine("this is array" + String.Join(",", twoDA[0]));
            Console.WriteLine("this is array" + String.Join(",", twoDA[1]));
            Console.WriteLine("this is array" + String.Join(",", twoDA[2]));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
