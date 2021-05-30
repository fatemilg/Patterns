namespace Patterns.Decorator
{

    public class Type1 : Decorator
    {
        private const string bakeType = " special baked type 1";
        public Type1(IBakery bakery) : base(bakery)
        {
            type = "Type 1";
            price = 2;
        }
        public override string Bake() { 
            return base.Bake() + bakeType;
        }
        public override double GetPrice()
        {
            return base.GetPrice() * price;
        }
    }

}
