using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        protected int num8 = 8;
        internal int num6 = 6;
        protected internal int num7 = 7;
        static void Main2(string[] args)
        {
            ClassLibrary1.Class1 obj1 = new ClassLibrary1.Class1();
            Console.WriteLine(obj1.num2);
            Console.ReadKey();

            //ClassLibrary1.Class1 obj2 = new ClassLibrary1.Class1();
            //Console.WriteLine(obj1.num1);
            //Console.ReadKey();
        }
    }

    //Parent CLASS
    public class Parent2
    {
        static void Main(string[] args)
        {
            Program pr1 = new Program();
            
            Console.WriteLine("num6 is = to: " + pr1.num6);
            Console.ReadKey();
        }
     }

    //SUB-CLASS INHERITED FROM PARENT
    public class Child1 : Parent2
    {
        static void Main2(string[] args)
        {
            Program pr2 = new Program();
            
            Console.WriteLine("num7 is = to: " + pr2.num7);
            Console.ReadKey();
        }
    }

    //SUB-CLASS INHERITED FROM PARENT
    class Sample :Program
    {
        static void Main2(string[] args)
        {
            Program pr2 = new Program();
            
            Console.WriteLine("num7 is = to: " + pr2.num7);
            Console.ReadKey();
        }
    }
}
