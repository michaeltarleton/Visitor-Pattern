namespace Visitor_Pattern
{
    public abstract class Good
    {
        public double Cost { get; set; }

        public Good(double cost)
        {
            Cost = cost;
        }

        public abstract double GetCostWithTax(ITaxer taxVisitor);
    }
}