using Patterns.FamilyTax.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FamilyTax.Calculator
{
    class TaxCalculator : IElementFamilyVisitor
    {
        public void Visit(Darman darman)
        {
            Console.WriteLine("tax for darman is " + 1000);
        }

        public void Visit(Dandan dandan)
        {
            Console.WriteLine("tax for dandan is " + 2000);
        }

        public void Visit(Para para)
        {
            Console.WriteLine("tax for para is " + 3000);
        }
    }
}
