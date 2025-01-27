namespace Single_Responsibility.Correct;

internal class PersonRepository
{
    public void Save(Person p)
    {
        Console.WriteLine($"Saving {p.FirstName} {p.LastName} to database");
    }
    public Person Load()
    {
        Console.WriteLine("Load person to database");
        return new Person { FirstName = "Jan", LastName = "Pieters" };
    }
}
