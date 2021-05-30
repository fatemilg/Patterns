using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.ChainOfResponsibility
{
    public abstract class TransferMoney
    {
        protected readonly TransferMoney _successor;
        public TransferMoney(TransferMoney successor)
        {
            _successor = successor;
        }
        public abstract ResponseContext Execute(RequestContext requestContext);
    }
}
