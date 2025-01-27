namespace Liskov_Substitution;

internal class Program
{
    static void Main(string[] args)
    {
        // Every sub/child class should be substitutable for their base/parent class.
        Incorrect();
        Correct();
    }

    private static void Incorrect()
    {
        Incorrect.Shape[] shapes = [
            new Incorrect.Circle { Radius = 50},
            new Incorrect.Rectangle { Height = 100, Width=200},
            new Incorrect.NoShape()
            ];

        var totalArea = 0D;
        foreach (var shape in shapes)
        {
            totalArea += shape.Area;
        }
        Console.WriteLine(totalArea);
    }

    private static void Correct()
    {
        Correct.Shape[] shapes = [
            new Correct.Circle { Radius = 50},
            new Correct.Rectangle { Height = 100, Width=200}
            ];

        var totalArea = 0D;
        foreach (var shape in shapes)
        {
            totalArea += shape.Area;
        }
        Console.WriteLine(totalArea);
    }
}
