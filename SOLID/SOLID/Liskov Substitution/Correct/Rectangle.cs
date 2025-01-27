namespace Liskov_Substitution.Correct;

internal class Rectangle: Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override double Area => Width * Height;
}
