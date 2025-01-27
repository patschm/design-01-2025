namespace Interface_Segregation.Incorrect;

internal class Sprinter : IActions
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello, I'm {FirstName} {LastName}");
    }

    public void Run()
    {
        Console.WriteLine($"{FirstName} {LastName} running as fast as he can.");
    }

    public void Sleep()
    {
        throw new NotImplementedException();
    }
}
