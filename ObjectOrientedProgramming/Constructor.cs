using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Bus
    {
        public string model;
        public Bus()
        {
            model = "Acc5006"; 
        }
    }
    internal class Constructor
    {
        public static void ConstructorMethod()
        {
            Bus Mahendra = new Bus();
            Console.WriteLine(Mahendra.model); 
        }
    }
}
