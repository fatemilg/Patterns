namespace Patterns.Decorator
{
    public class Bread : IBakery
    {
        public string Bake() { return "Bread baked"; }
        public double GetPrice() { return 100; }
    }
}
