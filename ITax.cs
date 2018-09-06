namespace Visitor_Pattern
{
    public interface ITaxer
    {
        double ApplyTax(Essential essential);
        double ApplyTax(NonEssential nonEssential);
        double ApplyTax(Alcohol alcohol);
    }
}