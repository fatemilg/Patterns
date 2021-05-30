﻿namespace Patterns.ChainOfResponsibility
{
    public class CheckActive : TransferMoney
    {
        public CheckActive(TransferMoney successor) : base(successor)
        {
        }
        public override ResponseContext Execute(RequestContext requestContext)
        {
            if (requestContext.FromCustomer.IsActive)
            {
                return (_successor.Execute(requestContext));
            }
            else
            {
                return (new ResponseContext()
                {
                    Message = "Acount Is Inactive",
                });
            }
        }
    }
}
