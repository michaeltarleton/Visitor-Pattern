namespace Visitor_Pattern
{
    public class Essential : Good, ITaxable
    {
        public Essential(double cost) : base(cost)
        {
        }

        public override double GetCostWithTax(ITaxer taxVisitor)
        {
            return taxVisitor.ApplyTax(this);
        }
    }
}