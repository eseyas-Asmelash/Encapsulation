namespace Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userErrors = new List<UserError>();

            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());

            foreach (var error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
