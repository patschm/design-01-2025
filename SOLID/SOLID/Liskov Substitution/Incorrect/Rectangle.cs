namespace Liskov_Substitution.Incorrect;

internal class Rectangle: Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override double Area => Width * Height;
}
