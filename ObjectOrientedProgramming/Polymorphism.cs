using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    class Animal  
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    internal class Polymorphism
    {
        public static void PolymorphismMethod() {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();  
            Animal myDog = new Dog();  
            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

        }
    }
}
