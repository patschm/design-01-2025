namespace Dependency_Inversion;

internal class Program
{
    static void Main(string[] args)
    {
        // Components should depend on abstractions, not on concretions
        Incorrect();
        Correct();
    }

    private static void Incorrect()
    {
        var jim = new Incorrect.Jim();
        var helene = new Incorrect.Helene();

        var acme = new Incorrect.ACME(jim);
        //acme = new Incorrect.ACME(helene); // Doesn't work. ACME depends on a concretion (Jim)
    }

    private static void Correct()
    {
        var jim = new Correct.Jim();
        var helene = new Correct.Helene();

        var acme = new Correct.ACME(jim);
        acme = new Correct.ACME(helene); // Works because ACME depends on abstractions

    }
}
