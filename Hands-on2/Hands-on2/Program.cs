using System;
using System.Collections;
using System.Collections.Generic;

namespace Hands_on2
{
    interface IAnimal
    {
        //DateTime Birthdate();
        void Move();
        void Speak();
        void Climb();
    }
    public abstract class BaseAnimal : IAnimal
    {
        //DateTime Birthdate();
        public abstract void Climb();
        public abstract void Move();
        public abstract void Speak();
    }

    public class Monkey : BaseAnimal
    {
        
        public override void Climb()
        {
            Console.WriteLine("The monkey climbs with two hands and two legs.");
            Console.ReadLine();
        }

        public override void Move()
        {
            Console.WriteLine("The monkey moves with 4 limbs.");
        }
        public override void Speak()
        {
            Console.WriteLine("The monkey says Ooh!!Aah!!.");
        }
    }
    public class Pet : BaseAnimal
    {
        public string name { get; set; }

        public Pet(string name)
        {
            this.name = name;
        }
        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override void Climb()
        {
        }

        public override void Speak()
        {
            throw new NotImplementedException();
        }
    }

    public class Dog : Pet
    {
        public Dog(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine(name + " moves with four limbs.");
        }

        public override void Speak()
        {
            Console.WriteLine(name + " says Woff Woff!");
            Console.ReadLine();
        }
    }

    public class Cat : Pet
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine(name + " moves with four limbs.");
        }

        public override void Speak()
        {
            Console.WriteLine(name + " say Meow Meow!");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Dog("Black Doberman"));
            animals.Add(new Monkey());
            animals.Add(new Cat("Arabic Cat"));

            foreach (IAnimal animal in animals)
            {
                animal.Move();
                animal.Speak();
                animal.Climb();
            }

            Console.ReadLine();
        }
    }
}
