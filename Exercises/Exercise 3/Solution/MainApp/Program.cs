using CarParts;
using System.Globalization;

namespace MainApp
{
    internal class Program
    {
        static CultureInfo nl = new CultureInfo("nl-NL");

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var car = AssembleCar();
            Console.WriteLine($"{car.ManufactorTime.Days} days to produce");
            Console.WriteLine($"Price: {car.CostPrice.ToString("C", nl)}");
        }

        private static Car AssembleCar()
        {
            var builder = new CarBuilder();
            builder.AddFrontLight().AddLight().AddLight();
            builder.AddTailLight().AddLight();
            for (int i = 0; i < 2; i++)
                builder.AddFrontDoor().AddHandleBar().AddHinge().AddHinge();
            for (int i = 0; i < 2; i++)
                builder.AddRearDoor().AddHandleBar().AddHinge().AddHinge();
            for (int i = 0;i < 4;i++)
                builder.AddWheel().AddDiskBrake().AddWheelBolt(4).AddHubCap();
            builder.AddSteeringWheel();
            builder.AddTrunk();
            builder.AddEngine().AddCylinder(6).AddOilFilter();

            return builder.Build();
        }
    }
}