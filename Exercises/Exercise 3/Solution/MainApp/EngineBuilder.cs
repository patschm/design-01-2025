using CarParts;

namespace MainApp;

internal class EngineBuilder
{
    private Engine _engine = new Engine();

    public EngineBuilder AddCylinder(int nr = 1)
    {
        for(int i = 0;i < nr; i++)
            _engine.Add(new Cylinder());    
        return this;
    }
    public EngineBuilder AddOilFilter()
    {
        _engine.Add(new OilFilter());
        return this;
    }
    public Engine Build()
    {
        return _engine;
    }
}
