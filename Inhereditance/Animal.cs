using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhereditance
{
    internal abstract class Animal
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }

        public Animal(string name, int age, double weight, int height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public abstract void DoSound();
        public abstract string Stats();

    }

    internal class Horse : Animal
    {
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
            Console.WriteLine("neigh");
        }
        public override string Stats()
        {
            return $"Name: {Name} Age: {Age} Weight: {Weight} Height: {Height} Property: {UniqueProperty}";
        }

    }
    internal class Dog : Animal
    {

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
        public override string Stats()
        {
            return $"Name: {Name} Age: {Age} Weight: {Weight} Height: {Height} Property: {UniqueProperty}";
        }
        public string DogSays()
        {
            return "Let go out for a walk";
        }

    }
    internal class Hedgehog : Animal
    {

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
        public override string Stats()
        {
            return $"Name: {Name} Age: {Age} Weight: {Weight} Height: {Height} Property: {UniqueProperty}";
        }

    }
    internal class Worm : Animal
    {

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
        public override string Stats()
        {
            return $"Name: {Name} Age: {Age} Weight: {Weight} Height: {Height} Property: {UniqueProperty}";
        }

    }
    internal class Bird : Animal
    {
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
            Console.WriteLine("chip chip");
        }
        public override string Stats()
        {
            return $"Name: {Name} Age: {Age} Weight: {Weight} Height: {Height} Property: {UniqueProperty}";
        }

    }
    internal class Wolf : Animal
    {
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
            Console.WriteLine("auhhhhh");
        }
        public override string Stats()
        {
            return $"Name: {Name} Age: {Age} Weight: {Weight} Height: {Height} Property: {UniqueProperty}";
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
