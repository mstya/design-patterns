using System.Collections.Generic;

namespace DesignPatters.Specification.Lambda
{
    interface ILambdaFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ILambdaSpecification<T> spec);
    }
}