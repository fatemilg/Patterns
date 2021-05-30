using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.ChainOfResponsibility
{
    public class Customer
    {
        public int AccountValue { get; set; }
        public bool IsActive { get; set; }
        public int MaxDateValue { get; set; }
        public string Password { get; set; }
    }
}
