using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhereditance
{
    internal abstract class Animal
    {

        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
        public abstract double Weight { get; set; }
        public abstract int Height { get; set; }

        public Animal(string name, int age, double weight, int height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public abstract void DoSound();

    }

    internal class Horse : Animal
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override double Weight { get; set; }
        public override int Height { get; set; }
        public string UniqueProperty { get; set; }

        public Horse(string name, int age, double weight, int height, string uniqueProperty)
            : base(name, age, weight, height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            UniqueProperty = uniqueProperty;
        }

        public override void DoSound()
        {
            Console.WriteLine("Neigh");
        }

    }
    internal class Dog : Animal
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override double Weight { get; set; }
        public override int Height { get; set; }
        public string UniqueProperty { get; set; }

        public Dog(string name, int age, double weight, int height, string uniqueProperty)
            : base(name, age, weight, height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            UniqueProperty = uniqueProperty;
        }

        public override void DoSound()
        {
            Console.WriteLine("bark");
        }

    }
    internal class Hedgehog : Animal
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override double Weight { get; set; }
        public override int Height { get; set; }
        public string UniqueProperty { get; set; }

        public Hedgehog(string name, int age, double weight, int height, string uniqueProperty)
            : base(name, age, weight, height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            UniqueProperty = uniqueProperty;
        }

        public override void DoSound()
        {
            Console.WriteLine("Snuffling");
        }

    }
    internal class Worm : Animal
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override double Weight { get; set; }
        public override int Height { get; set; }
        public string UniqueProperty { get; set; }

        public Worm(string name, int age, double weight, int height, string uniquiProperty)
            : base(name,age,weight,height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            UniqueProperty = uniquiProperty;

        }

        public override void DoSound()
        {
            Console.WriteLine("Grunting");
        }

    }
    internal class Bird : Animal
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public override double Weight { get; set; }
        public override int Height { get; set; }
        public string UniqueProperty { get; set; }

        public Bird(string name, int age, double weight, int height, string uniqueProperty) 
            : base(name, age, weight, height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            UniqueProperty = uniqueProperty;
        }

        public override void DoSound()
        {
            Console.WriteLine("Sing");
        }

    }
    internal class Wolf : Animal
    {
        public override string Name { get ; set ; }
        public override int Age { get; set; }
        public override double Weight { get; set; }
        public override int Height { get; set; }
        public string UniqueProperty { get; set; }

        public Wolf(string name, int age, double weight, int height, string uniqueProperty)
            : base(name, age, weight, height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
            UniqueProperty = uniqueProperty;
        }

        public override void DoSound()
        {
            Console.WriteLine("whine");
        }
    }
    internal class WolfMan : Wolf, IPerson
    {

        public WolfMan(string name, int age, double weight, int height, string uniqueProperty) : base(name, age, weight, height, uniqueProperty)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
            this.UniqueProperty = uniqueProperty;
        }
        public void Talk()
        {
            Console.WriteLine("Hello, is it me you looking for?");
        }
    }
}
