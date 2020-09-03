using System;

namespace InterfaceSegregationPrinciple
{
    public class Printer : IPrinter
    {
        public void Print(Document d)
        {
            Console.WriteLine("Printer can Print");
        }
    }
}