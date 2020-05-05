using System;
using DesignPatters.Specification.Models;

namespace DesignPatters.Specification.Lambda
{
    class LambdaAndSpecification : ILambdaSpecification<User>
    {
        private readonly ILambdaSpecification<User> _s1;
        private readonly ILambdaSpecification<User> _s2;

        public LambdaAndSpecification(
            ILambdaSpecification<User> s1,
            ILambdaSpecification<User> s2)
        {
            _s1 = s1;
            _s2 = s2;
        }

        public Func<User, bool> Condition => t => _s1.Condition(t) && _s2.Condition(t);
    }
}