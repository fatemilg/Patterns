namespace Patterns.Decorator
{
    public abstract partial class Decorator : IBakery
    {
        private readonly IBakery _bakery;
        protected string type = "N/A";
        protected double price = -1;

        public Decorator(IBakery bakery)
        {
            _bakery = bakery;
        }
        public virtual string Bake()
        {
            return _bakery.Bake();
        }
        public virtual double GetPrice()
        {
            return _bakery.GetPrice();
        }
    }
}
