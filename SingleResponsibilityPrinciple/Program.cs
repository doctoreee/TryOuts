using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today.");
            j.AddEntry("I ate a bug.");

            PersistenceManager manager = new PersistenceManager();
            manager.SaveToFile(j, @"C:\Users\icagr\Desktop\temp.txt", true);            
        }
    }
}
