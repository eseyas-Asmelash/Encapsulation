namespace Incapsulation;

class Program
{
    static void Main(string[] args)
    {
         List<string> persons = new List<string>();
        PersonHandler person = new PersonHandler();

        persons.Add(person.ReadPersonValues(-11, "an", "dem", 70));
        persons.Add(person.ReadPersonValues(23, "Jan", "roberts", 59));
        persons.Add(person.ReadPersonValues(23, "june", "ma", 20));
        persons.Add(person.ReadPersonValues(34, "Simon", "Sammm",23));

        foreach (var pers in persons)
        {
            Console.WriteLine(pers);

        }

    }
}
