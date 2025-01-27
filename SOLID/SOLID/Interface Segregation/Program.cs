
using Interface_Segregation.Correct;
using Interface_Segregation.Incorrect;

namespace Interface_Segregation;

internal class Program
{
    static void Main(string[] args)
    {
        // Interfaces should not force classes to implement what they can't do.
        Incorrect();
        Correct();
    }

    private static void Incorrect()
    {
       var sprinters = new Incorrect.Sprinter[]{
           new Incorrect.Sprinter { FirstName = "Usain", LastName = "Bolt"},
           new Incorrect.Sprinter { FirstName = "Justin", LastName = "Gatlin"},
           new Incorrect.Sprinter { FirstName = "Andre", LastName = "de Grasse"},
       };

        Console.WriteLine("At the start are:");
        foreach (var sprinter in sprinters) sprinter.Introduce();
        Console.WriteLine("Starting the sprint:");
        foreach (var sprinter in sprinters) sprinter.Run();
    }

    private static void Correct()
    {
        var sprinters = new Incorrect.Sprinter[]{
           new Incorrect.Sprinter { FirstName = "Usain", LastName = "Bolt"},
           new Incorrect.Sprinter { FirstName = "Justin", LastName = "Gatlin"},
           new Incorrect.Sprinter { FirstName = "Andre", LastName = "de Grasse"},
       };

        Console.WriteLine("At the start are:");
        foreach (IIntroducable sprinter in sprinters) sprinter.Introduce();
        Console.WriteLine("Starting the sprint:");
        foreach (IRunable sprinter in sprinters) sprinter.Run();
    }
}
}
