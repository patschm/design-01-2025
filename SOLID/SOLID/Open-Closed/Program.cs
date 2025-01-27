namespace Open_Closed;

internal class Program
{
    static void Main(string[] args)
    {
        // Entities/classes should be open for extension but closed for modification
        Incorrect();
        Correct();
    }

    private static void Incorrect()
    {
        var p1 = new Incorrect.Person { FirstName = "Jan", LastName = "Keizer",JobTitle="Developer" };
        p1.Introduce();
    }

    private static void Correct()
    {
        var p1 = new Correct.Person { FirstName = "Jan", LastName = "Keizer"};
        p1.Introduce();

        var p2 = new Correct.Employee { FirstName = "Jan", LastName = "Keizer", JobTitle="Developer" };
        p2.Introduce();
    }
}
