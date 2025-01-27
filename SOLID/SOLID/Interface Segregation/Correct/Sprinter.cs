namespace Interface_Segregation.Correct;

internal class Sprinter : IIntroducable, IRunable
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hello, I'm {FirstName} {LastName}");
    }

    public void Run()
    {
        Console.WriteLine($"{FirstName} {LastName} running as fast as he can.");
    }

}
