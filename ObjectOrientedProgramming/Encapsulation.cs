using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Human
    {
        private string name; // field
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
    }
    
  class Encapsulation
  {
      public static void EncapsulationMethod()
      {
         Human myObj = new Human();
         myObj.Name = "Venu";
         Console.WriteLine(myObj.Name);
      }
  }

}

