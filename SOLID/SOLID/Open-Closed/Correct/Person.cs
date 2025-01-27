namespace Open_Closed.Correct;


internal class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public virtual void Introduce()
    {
        Console.WriteLine($"Hello, I'm {FirstName} {LastName}");
    }
}

internal class Employee : Person
{
    public string JobTitle { get; set; }
    public override void Introduce()
    {
        Console.WriteLine($"Hello, I'm {FirstName} {LastName} ({JobTitle})");
    }
}


