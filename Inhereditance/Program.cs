namespace Inhereditance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            List<Dog> dogs = new List<Dog>();

            animals.Add(new Wolf("wolfy", 12, 34.5, 34, "lone  wolf"));
            animals.Add(new WolfMan("Jacob", 8, 44.5, 60, "Kills vampires"));
            animals.Add(new Dog("Tom", 7, 44.5, 60, ""));
            animals.Add(new Horse("Zanna", 5, 44.5, 60, "race horse"));
            foreach (var animal in animals) 
            {
                Console.WriteLine(animal.Stats());
                animal.DoSound();
                if (animal is IPerson person)
                {
                    person.Talk();
                }
            }
        // dogs.Add(new Horse("Spirit", 500, 5, 60)); // This will cause a compile-time error

            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                {
                    Console.WriteLine(dog.Stats());
                    Console.WriteLine(dog.DogSays());
                }
            }
        }
    }
}
