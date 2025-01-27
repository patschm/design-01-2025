using CarParts;

namespace MainApp;

internal class CarBuilder
{
    private Car _car = new Car();
    public DoorBuilder<FrontDoor> AddFrontDoor()
    {
        var builder = new DoorBuilder<FrontDoor>();
        _car.Add(builder.Build());
        return builder;
    }
    public DoorBuilder<RearDoor> AddRearDoor()
    {
        var builder = new DoorBuilder<RearDoor>();
        _car.Add(builder.Build());
        return builder;
    }
    public WheelBuilder AddWheel()
    {
        var builder = new WheelBuilder();
        _car.Add(builder.Build());
        return builder;
    }
    public EngineBuilder AddEngine()
    {
        var builder = new EngineBuilder();
        _car.Add(builder.Build());
        return builder;
    }
    public CarBuilder AddTrunk()
    {
        _car.Add(new Trunk());
        return this;
    }
    public CarBuilder AddSteeringWheel()
    {
        _car.Add(new SteeringWheel());
        return this;
    }
    public LightBuilder<FrontLight> AddFrontLight()
    {
        var builder = new LightBuilder<FrontLight>();
        _car.Add(builder.Build());
        return builder;
    }
    public LightBuilder<TailLight> AddTailLight()
    {
        var builder = new LightBuilder<TailLight>();
        _car.Add(builder.Build());
        return builder;
    }

    public Car Build()
    {
        return _car;
    }
}
