namespace Patterns.ChainOfResponsibility
{
    public class FinalTransfer : TransferMoney
    {
        public FinalTransfer(TransferMoney successor) : base(successor)
        {
        }
        public override ResponseContext Execute(RequestContext requestContext)
        {
            requestContext.FromCustomer.AccountValue -= requestContext.Value;
            requestContext.ToCustomer.AccountValue += requestContext.Value;
            return (new ResponseContext()
            {
                Message = $"Transfer Complete--- FromCustomerAccount:{requestContext.FromCustomer.AccountValue}-----ToCustomerAccount:{ requestContext.ToCustomer.AccountValue}"
            });
        }
    }
}
