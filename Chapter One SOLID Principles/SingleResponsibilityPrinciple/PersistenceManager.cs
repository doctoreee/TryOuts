using System;
using System.IO;

namespace SingleResponsibilityPrinciple
{
    public class PersistenceManager
    {
        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || !File.Exists(filename))
                File.WriteAllText(filename, journal.ToString());
        }
    }
}