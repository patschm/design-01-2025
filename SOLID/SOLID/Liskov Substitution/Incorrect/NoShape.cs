namespace Liskov_Substitution.Incorrect;

internal class NoShape : Shape
{
    // This breaks Liskov since Area has no meaning for NoShape. Therefore we cannot
    // substitute is everywhere for it's base class.
    public override double Area => throw new NotImplementedException();
}
