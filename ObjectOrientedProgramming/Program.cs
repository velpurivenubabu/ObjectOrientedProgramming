using System;

namespace ObjectOrientedProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Object Oriented Programming");
            Console.WriteLine("Please Enter any below option");
            Console.WriteLine("1.ObjectAndClass\n2.Encapsulation");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ClassAndObject.CreateClassAndObject();
                    break;
                case 2:
                    Encapsulation.EncapsulationMethod();
                    break;

            }

        }
    }
}