using System;

namespace Visitor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup the visitor

            ITaxer taxMan = new TaxVisitor();

            // Setup the visitables

            Good milk = new Essential(3.00);
            Good donut = new NonEssential(2.00);
            Good wine = new Alcohol(10);

            // Print out the new cost * taxes

            Console.WriteLine($"Milk: {milk.GetCostWithTax(taxMan).ToString("C")}");
            Console.WriteLine($"Donut: {donut.GetCostWithTax(taxMan).ToString("C")}");
            Console.WriteLine($"Wine: {wine.GetCostWithTax(taxMan).ToString("C")}");
        }
    }
}
