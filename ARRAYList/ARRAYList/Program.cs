using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYList
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add("Mercedez");
            arrayList1.Add("bmw");
            arrayList1.Add("Volvo");
            arrayList1.Add("Wagon");
            arrayList1.Add("Toyota");
            arrayList1.Add("Honda");

            Console.WriteLine("array [2]=" + arrayList1[2]);
            //expected result: array [2]=Volvo


            //*****************************************************************************
            //********USE 'object' if not sure of datatype the user is using/entering.******
            foreach (object item in arrayList1)
            {
                Console.WriteLine("the car name is " + (String)item);
                
            }
            Console.ReadKey();



            arrayList1.Remove("Mercedez");
            arrayList1.RemoveAt(1);
            arrayList1.RemoveRange(1,2);


                        
            for (int i=0; i<arrayList1.Count; i++) 
            {
                Console.WriteLine("arrayList [" + i + "]= " + arrayList1[i]);
            }
            Console.ReadKey();
       


        }
    }
}