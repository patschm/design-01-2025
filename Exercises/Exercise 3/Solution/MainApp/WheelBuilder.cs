using CarParts;

namespace MainApp;

internal class WheelBuilder
{
    private Wheel _wheel = new Wheel();

    public WheelBuilder AddDiskBrake()
    {
        _wheel.Add(new DiskBrake());
        return this;
    }
    public WheelBuilder AddWheelBolt(int nr = 1)
    {
        for(int i = 0; i < nr; i++)
            _wheel.Add(new WheelBolt());
        return this;
    }
    public WheelBuilder AddHubCap()
    {
        _wheel.Add(new HubCap());
        return this;
    }
    public Wheel Build()
    {
        return _wheel;
    }
}
