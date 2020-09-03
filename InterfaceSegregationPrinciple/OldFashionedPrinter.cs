using System;
namespace InterfaceSegregationPrinciple
{
    public class OldFashionedPrinter : IMachine
    {
        public void Print(Document d) => Console.WriteLine("Can Print");

        [Obsolete("Not supported", true)]
        public void Fax(Document d) => throw new System.NotImplementedException();
        
        public void Scan(Document d) { }
    }
}