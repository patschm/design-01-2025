namespace CarParts;

public class Door: Part
{
    public HandleBar? Handle;
    public Hinge[] Hinges = new Hinge[2];

    public Door()
         : base(400, TimeSpan.FromHours(4))
    {

    }
}
