
namespace Dependency_Inversion.Correct;

internal class Helene : IContract
{
    public void Working()
    {
        Works();
    }

    internal void Works()
    {
        Console.WriteLine("Helene is working");
    }
}