using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public void AddEntry(string entry)
        {
            entries.Add($"{++count}: {entry}");
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }
    }
}