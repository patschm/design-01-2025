using CarParts;

namespace MainApp;

internal class LightBuilder<T> where T : Component, new()
{
    private T _light = new T();

    public LightBuilder<T> AddLight()
    {

        _light.Add(new Light());
        return this;
    }
    public T Build()
    {
        return _light;
    }
}
