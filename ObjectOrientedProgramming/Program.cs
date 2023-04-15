using System;

namespace ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Object Oriented Programming");
            Console.WriteLine("Please Enter any below option");
            Console.WriteLine("1.ObjectAndClass\n2.Encapsulation\n3.Inheritance\n4.Polymorhism\n5.Abstraction");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ClassAndObject.CreateClassAndObject();
                    break;
                case 2:
                    Encapsulation.EncapsulationMethod();
                    break;
                case 3:
                    Inheritance.InheritanceMethod();
                    break;
                case 4:
                    Polymorphism.PolymorphismMethod();
                    break;
                case 5:
                    Abstract.AbstractMethod();
                    break;



            }

        }
    }
}