namespace Visitor_Pattern
{
    internal class TaxVisitor : ITaxer
    {
        public double ApplyTax(Essential essential)
        {
            return essential.Cost * 1.0;
        }

        public double ApplyTax(NonEssential nonEssential)
        {
            return nonEssential.Cost * 1.0825;
        }

        public double ApplyTax(Alcohol alcohol)
        {
            return alcohol.Cost * 1.25;
        }
    }
}