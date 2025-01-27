namespace Dependency_Inversion.Correct;

internal class Jim: IContract
{
    public void Working()
    {
        DoWork();
    }

    internal void DoWork()
    {
        Console.WriteLine("Jim is doing the work");
    }
}