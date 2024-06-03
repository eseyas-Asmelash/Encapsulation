namespace Incapsulation;

class Program
{
    static void Main(string[] args)
    {
         List<Person> persons = new List<Person>();
        PersonHandler person = new PersonHandler();
        try
        {
            
            var p = person.CreatePerson(1, "an", "dem", 70);
            var p1 = person.CreatePerson(23, "Junee", "roberts", 59);
            var p2 = person.CreatePerson(23, "june", "mathson", 20);
            var p3 = person.CreatePerson(34, "Simon", "Sammm", 23);
            //persons.Add(person.CreatePerson(1, "alan", "dave", 70));
            //persons.Add(person.CreatePerson(23, "Junee", "roberts", 59));
            //persons.Add(person.CreatePerson(23, "june", "mathson", 20));
            //persons.Add(person.CreatePerson(- 34, "Simon", "Sammm", 23));
            persons.Add(p);
            persons.Add(p1);
            persons.Add(p3);
            persons.Add(p2);
        }

        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        foreach (var p in persons)
        {
            Console.WriteLine($"{p.Age} {p.FName} {p.LName} {p.Weight}");

        }








    }
}
