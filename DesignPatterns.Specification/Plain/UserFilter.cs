using System.Collections.Generic;
using DesignPatters.Specification.Models;

namespace DesignPatters.Specification.Plain
{
    class UserFilter : IFilter<User>
    {
        public IEnumerable<User> Filter(IEnumerable<User> users, ISpecification<User> spec)
        {
            foreach (var user in users)
            {
                if (spec.IsSatisfy(user))
                {
                    yield return user;
                }
            }
        }
    }
}