using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    internal class ClassAndObject
    {
        class Car //Initilizig the class Object
        {
            public string color = "red";
            public string brand = "BMW";
        }
        public static void CreateClassAndObject()
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.brand);
        }
    }

    
}
