namespace Visitor_Pattern
{
    interface ITaxable
    {
        double GetCostWithTax(ITaxer taxer);
    }
}