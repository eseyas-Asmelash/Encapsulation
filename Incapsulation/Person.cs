namespace Incapsulation;

class Person
{
    private int age;
    private string fName = string.Empty;
    private string lName = string.Empty;
    private int weight;

    public int Age
    {
        get 
        { 
            return age;            
        }
        set
        {
            if (value < 0 )
                throw new ArgumentException(nameof(value),
                      "The value should be above 0.");

            age = value;
        }
    }
    public string FName
    {
        get
        { 
            return fName;
        }
        set
        {
            if (value.Length < 2 || value.Length < 10)
                throw new ArgumentException(nameof(value),
                      "The valid range is between 2 and 10.");

            fName = value;
        }
    }
    public string LName
    {
        get 
        { 
            return lName; 
        }
        set
        {
            if (value.Length < 3 || value.Length < 15)
                throw new ArgumentException(nameof(value),
                      "The valid range is between 3 and 15.");

            lName = value;
        }
    }
    public int Weight
    {
        get 
        { 
            return weight;
        }
        set
        {
            if (value < 0)
                throw new ArgumentException(nameof(value),
                      "The valid should be above 0.");

            weight = value;
        }
    }
}