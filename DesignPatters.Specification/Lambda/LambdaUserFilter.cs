using System.Collections.Generic;
using System.Linq;
using DesignPatters.Specification.Models;

namespace DesignPatters.Specification.Lambda
{
    class LambdaUserFilter : ILambdaFilter<User>
    {
        public IEnumerable<User> Filter(IEnumerable<User> items, ILambdaSpecification<User> spec)
        {
            return items.Where(spec.Condition);
        }
    }
}