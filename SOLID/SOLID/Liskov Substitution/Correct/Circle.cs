namespace Liskov_Substitution.Correct;

internal class Circle : Shape
{
    public int Radius { get; set; }
    public override double Area  => Math.PI * Math.Pow(Radius, 2);
}
