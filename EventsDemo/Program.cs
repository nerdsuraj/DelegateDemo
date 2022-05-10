using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //add += new DelEventHandler(India);
            //add += new DelEventHandler(USA);
            //add += new DelEventHandler(England);
            //add.Invoke();
            Console.WriteLine("************Event Handling****************");
            EventHandling.ImplementEvent();
            Console.ReadKey();
        }
    }
}
