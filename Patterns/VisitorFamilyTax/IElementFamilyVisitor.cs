using Patterns.FamilyTax.Entity;

namespace Patterns.FamilyTax
{
    public interface IElementFamilyVisitor
    {
        void Visit(Darman darman);
        void Visit(Dandan dandan);
        void Visit(Para para);
    }
}