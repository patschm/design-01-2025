namespace Open_Closed.Incorrect;

// This might break existing code
internal class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public void Introduce()
    {
        // Version 1: Initial version
        //Console.WriteLine($"Hello, I'm {FirstName} {LastName}");

        // Version 2: Modified to accomomdate the age
        Console.WriteLine($"Hello, I'm {FirstName} {LastName} ({JobTitle})");
    }

    // Version 2: Added later
    public string JobTitle { get; set; }
    
}
