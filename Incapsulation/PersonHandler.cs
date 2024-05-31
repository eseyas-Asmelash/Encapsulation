namespace Incapsulation;

class PersonHandler
{
    private List<Person> persons= new List<Person>();
    public void SetAge(Person person, int age)
    {
        try
        {
            person.Age = age;
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void  SetFName(Person person, string fName)
    {
        try
        {
            person.FName = fName;
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void SetLName(Person person, string lName)
    {
        try
        {
            person.LName = lName;
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void SetWeight(Person person, int weight)
    {

        try
        {
            person.Weight = weight;
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public Person CreatePerson(int age, string fName, string lName, int weight) 
    {
        Person person = new Person();
        person.Age = age;
        person.FName = fName;
        person.LName = lName;
        person.Weight = weight;

        //SetAge(person, age);

        //SetFName(person, fName);

        //SetLName(person, lName);

        //SetWeight(person, weight);


        return person;
    }
    public void ReadPersonValues()
    {
        Console.WriteLine("Enter the Age of the Person");
        int.TryParse(Console.ReadLine(), out int _age);

        Console.WriteLine("Enter the FirstName of the Person");
        string _fName = Console.ReadLine()!;


        Console.WriteLine("Enter the Last Name of the Person");
        string _lName = Console.ReadLine()!;

        Console.WriteLine("Enter the Weight of the Person");
        int.TryParse(Console.ReadLine(), out int _weight);

        CreatePerson(_age, _fName, _lName, _weight);

    }
}
