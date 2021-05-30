using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FamilyTax.Entity
{
    public class Darman : IElementFamily
    {
        //public int WorkingHour = 8;
        //public int Wife = 1;
        //public int Children = 3;
        //public int OffDays = 6;
        //public int OverHours = 12;
        public void Accept(IElementFamilyVisitor visitor) => visitor.Visit(this);
    }
}
