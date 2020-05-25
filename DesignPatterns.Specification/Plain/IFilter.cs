using System.Collections.Generic;

namespace DesignPatters.Specification.Plain
{
    interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}