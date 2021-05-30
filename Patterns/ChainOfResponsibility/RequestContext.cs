namespace Patterns.ChainOfResponsibility
{
    public class RequestContext
    {
        public string Password { get; set; }
        public int Value { get; set; }
        public Customer FromCustomer { get; set; }
        public Customer ToCustomer { get; set; }
    }
}