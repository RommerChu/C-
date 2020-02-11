using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableArray //PARALLEL ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARALLEL ARRAY
            //PARALLEL ARRAY
            //PARALLEL ARRAY


            Hashtable hT = new Hashtable();
            //object(key, value)
            hT.Add("Nissan", "Altima");
            hT.Add("Toyota", "Camry");
            hT.Add("Tata", "Harrier");
            hT.Add("Fiat", "Ferrari");

            //can look from the Interface
            ICollection keys = hT.Keys;

            foreach (string key in keys) 
            {
                Console.WriteLine("The value of key of " + key + " is: " + hT[key]);
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();


        }
    }
}
