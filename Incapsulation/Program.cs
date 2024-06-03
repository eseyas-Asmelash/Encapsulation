namespace Incapsulation;

class Program
{
    static void Main(string[] args)
    {
         List<Person> persons = new List<Person>();
        PersonHandler person = new PersonHandler();
        //try
        //{
            
            //var p = person.CreatePerson(1, "an", "dem", 70);
            //var p1 = person.CreatePerson(23, "Junee", "roberts", 59);
            //var p2 = person.CreatePerson(23, "june", "mathson", 20);
            //var p3 = person.CreatePerson(34, "Simon", "Sammm", 23);
        person.ReadPersonValues(1, "an", "dem", 70);
        person.ReadPersonValues(23, "Junee", "roberts", 59);
        person.CreatePerson(23, "june", "mathson", 20);
        person.ReadPersonValues(34, "Simon", "Sammm", 23);
        //persons.Add(person.CreatePerson(1, "alan", "dave", 70));
        //persons.Add(person.CreatePerson(23, "Junee", "roberts", 59));
        //persons.Add(person.CreatePerson(23, "june", "mathson", 20));
        //persons.Add(person.CreatePerson(- 34, "Simon", "Sammm", 23));

        //}

        //catch (ArgumentException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        foreach (var pe in persons)
        {
            Console.WriteLine($"{pe.Age} {pe.FName} {pe.LName} {pe.Weight}");

        }








    }
}
