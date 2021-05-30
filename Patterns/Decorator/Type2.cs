namespace Patterns.Decorator
{

    public class Type2 : Decorator
    {
        private const string bakeType = " special baked type 2";
        public Type2(IBakery bakery) : base(bakery)
        {
            type = "Type 2";
            price = 4;
        }
        public override string Bake()
        {
            return base.Bake() + bakeType;
        }

        public override double GetPrice()
        {
            return base.GetPrice() * price;
        }
    }

}
