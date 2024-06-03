namespace Inhereditance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal wolf = new Wolf("wolfy", 12, 34.5, 34, "night animal");
            //WolfMan wolfman = new WolfMan("Zanna", 5, 44.5, 60, "lone wolf");
            //wolf.DoSound();
            //wolfman.Talk();
            //wolfman.DoSound();
            List<Animal> animals = new List<Animal>();
            animals.Add(new Wolf("wolfy", 12, 34.5, 34, "night animal"));
            animals.Add(new WolfMan("Zanna", 5, 44.5, 60, "lone wolf"));
            foreach (var animal in animals) 
            {
                Console.WriteLine(animal.Stats());
                animal.DoSound();
                if (animal is IPerson person)
                {
                    person.Talk();
                }



            }
            Console.WriteLine(typeof(WolfMan));
            /*       List<Dog> dogs = new List<Dog>();

        // dogs.Add(new Horse("Spirit", 500, 5, 60)); // This will cause a compile-time error

        // To store all classes together, we use List<Animal>
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Stats());
        }

        // Print Stats() method only for all dogs
        foreach (var animal in animals)
        {
            if (animal is Dog dog)
            {
                Console.WriteLine(dog.Stats());
                Console.WriteLine(dog.RandomDogMethod());
            }
        }*/
        }
    }
}
