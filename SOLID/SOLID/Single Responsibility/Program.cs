namespace Single_Responsibility;

internal class Program
{
    static void Main(string[] args)
    {
        // Single Responsibility says that a class/entity should only be responsible for one thing.
        Incorrect();
        Correct();
    }
    private static void Incorrect()
    {
        var p1 = new Incorrect.Person { FirstName = "Jan", LastName = "Pieters" };
        p1.Introduce();
        p1.Save();
        
    }
    private static void Correct()
    {
        var p1 = new Correct.Person { FirstName = "Jan", LastName = "Pieters" };
        p1.Introduce();
        var repo = new Correct.PersonRepository();
        repo.Save(p1);
    }

   
}
