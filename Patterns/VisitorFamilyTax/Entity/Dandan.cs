using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FamilyTax.Entity
{
    public class Dandan : IElementFamily
    {
        public void Accept(IElementFamilyVisitor visitor) => visitor.Visit(this);
    }
}
