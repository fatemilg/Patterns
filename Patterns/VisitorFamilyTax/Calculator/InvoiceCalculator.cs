using Patterns.FamilyTax.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FamilyTax.Calculator
{
    class InvoiceCalculator : IElementFamilyVisitor
    {
        public void Visit(Darman darman)
        {
            Console.WriteLine("invoice for darman is " + 7777);
        }

        public void Visit(Dandan dandan)
        {
            Console.WriteLine("invoice for dandan is " + 8888);
        }

        public void Visit(Para para)
        {
            Console.WriteLine("invoice for para is " + 9999);
        }
    }
}
