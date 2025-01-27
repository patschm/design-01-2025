namespace Dependency_Inversion.Correct;

internal class ACME
{
    private readonly IContract worker;

    public ACME(IContract worker)
    {
        this.worker = worker;
    }

    public void StartProducing()
    {
        Console.WriteLine("ACME Starts producing:");
        worker.Working();
    }
}
