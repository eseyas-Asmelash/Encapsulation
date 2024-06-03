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
    public string ReadPersonValues(int age, string fName, string lName, int weight)
    {
        List<string> strings = new List<string>();
        try
        {
            Person p = CreatePerson(age, fName, lName, weight);
            return p.ToString();
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }

    }

}
