using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FamilyTax.Hub
{
    public class Hub
    {
        private readonly IList<IElementFamily> _elements;

        public Hub()
        {
            _elements = new List<IElementFamily>();
        }

        public void Attach(IElementFamily element)
        {
            _elements.Add(element);
        }

        public void Detach(IElementFamily element)
        {
            _elements.Remove(element);
        }

        public void Execute(IElementFamilyVisitor visitor)
        {
            foreach (var element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
