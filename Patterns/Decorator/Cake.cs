namespace Patterns.Decorator
{
    public class Cake : IBakery
    {
        public string Bake() { return "Cake baked"; }
        public double GetPrice() { return 2000; }
    }
}
