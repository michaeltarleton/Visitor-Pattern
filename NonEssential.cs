namespace Visitor_Pattern
{
    public class NonEssential: Good, ITaxable
    {
        public NonEssential(double cost) : base(cost)
        {
        }

        public override double GetCostWithTax(ITaxer taxVisitor)
        {
            return taxVisitor.ApplyTax(this);
        }
    }
}