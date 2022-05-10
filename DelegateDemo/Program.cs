using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    internal class Program
    {
        public delegate int operation(int x, int y);
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static int Addition123(int a, int b, int c)
        {
            return a + b;
        }

        public static void Main(String [] args)
        {
            Console.WriteLine("Delegate Demo");

            //operation obj = new operation(Addition);

            //Console.WriteLine("Addition is = {0}",obj(23,27));

            MulticastDelegate1.ImplementDelegate();

            Console.ReadKey();
        }
        


    }
}

