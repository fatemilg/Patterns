using System.Collections.Generic;
using System.Text;

namespace Patterns.Strategy
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
