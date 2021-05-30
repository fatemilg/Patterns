namespace Patterns.ChainOfResponsibility
{
    public class CheckPassword : TransferMoney
    {
        public CheckPassword(TransferMoney successor) : base(successor)
        {
        }
        public override ResponseContext Execute(RequestContext requestContext)
        {
            if (requestContext.FromCustomer.Password == requestContext.Password)
            {
                return (_successor.Execute(requestContext));
            }
            else
            {
                return (new ResponseContext()
                {
                    Message = "incorrect password",
                });
            }
        }
    }
}
