namespace Patterns.FamilyTax
{
    public interface IElementFamily
    {
        void Accept(IElementFamilyVisitor visitor);
    }
}