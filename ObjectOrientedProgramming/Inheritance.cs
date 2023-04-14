using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Vehicle  // base class (parent) 
    {
         public string brand = "Audi";  // Vehicle field
         public void start()             // Vehicle method 
        {
            Console.WriteLine("Engine Started!");
        }
    }

    class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Audi386";  // Car field
    }
    internal class Inheritance
    {
        public static void InheritanceMethod()
        {
            // Create a myCar object
            Car myCar = new Car();
            myCar.start();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }

    }
}
