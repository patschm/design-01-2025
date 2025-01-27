namespace Dependency_Inversion.Incorrect;

internal class ACME
{
    private readonly Jim worker;

    public ACME(Jim worker)
    {
        this.worker = worker;
    }

    public void StartProducing()
    {
        Console.WriteLine("ACME Starts producing:");
        worker.DoWork();
    }
}
