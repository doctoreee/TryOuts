using System;
using System.Linq;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    public class Research
    {
        // public Research(Relationships relationships) // Violates DIP : Depends on implementation of Relationships
        // {
        //     // high-level: find all of John's children
        //     var relations = relationships.Relations;
        //     foreach (var r in relations.Where(x => x.Item1.Name == "John" && x.Item2 == Relationship.Parent))
        //     {
        //         Console.WriteLine($"John has a child called {r.Item3.Name}");
        //     }
        // }
        public Research(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called {p.Name}");
            }
        }
    }
}