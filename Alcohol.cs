namespace Visitor_Pattern
{
    public class Alcohol: Good, ITaxable
    {
        public Alcohol(double cost) : base(cost)
        {
        }

        public override double GetCostWithTax(ITaxer taxVisitor)
        {
            return taxVisitor.ApplyTax(this);
        }
    }
}