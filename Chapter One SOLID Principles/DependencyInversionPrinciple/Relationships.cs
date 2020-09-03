using System;
using System.Linq;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    // public class Relationships // Violates DIP 
    // {
    //     public List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

    //     public void AddParentAndChild(Person parent, Person child)
    //     {
    //         relations.Add((parent, Relationship.Parent, child));
    //         relations.Add((child, Relationship.Child, parent));
    //     }
    // }
    public class Relationships : IRelationshipBrowser // low-level
    {
        // no longer public!
        private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();
        
        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations.Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent).Select(r => r.Item3);
        }
    }
}