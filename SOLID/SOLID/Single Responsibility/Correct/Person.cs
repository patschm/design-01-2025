namespace Single_Responsibility.Correct;

internal class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hello, I'm {FirstName} {LastName}");
    }
}
