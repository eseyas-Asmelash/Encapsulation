namespace Incapsulation;

class Program
{
    static void Main(string[] args)
    {
         List<Person> persons = new List<Person>();

        PersonHandler person = new PersonHandler();
        persons.Add(person.CreatePerson(-1, "alan", "dave", 70));
        persons.Add(person.CreatePerson(23, "J", "roberts", 59));
        persons.Add(person.CreatePerson(23, "june", "mathson", -20));
        persons.Add(person.CreatePerson(34, "Simon", "Sa", 23));
        
  




        
    }
}
