namespace Single_Responsibility.Incorrect;

// This class Violates Single Responsibility
internal class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hello, I'm {FirstName} {LastName}");
    }

    // Doesn't belong to this class!!!
    public void Save()
    {
        Console.WriteLine($"Saving {FirstName} {LastName} to database");
    }
    public void Load()
    {
        Console.WriteLine("Load person to database");
    }
}
