using CarParts;

namespace MainApp;

internal class DoorBuilder<T> where T : Component, new()
{
    private T _door = new T();

    public DoorBuilder<T> AddHinge()
    {
        _door.Add(new Hinge());
        return this;
    }
    public DoorBuilder<T> AddHandleBar()
    {
        _door.Add(new HandleBar());
        return this;
    }
    public T Build()
    {
        return _door;
    }
}
