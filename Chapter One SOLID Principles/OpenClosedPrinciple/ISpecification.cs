using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}