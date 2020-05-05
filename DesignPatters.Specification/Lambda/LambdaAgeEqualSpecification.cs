using System;
using DesignPatters.Specification.Models;

namespace DesignPatters.Specification.Lambda
{
    class LambdaAgeEqualSpecification : ILambdaSpecification<User>
    {
        private readonly int _age;

        public LambdaAgeEqualSpecification(int age)
        {
            _age = age;
        }
        
        public Func<User, bool> Condition => t => t.Age == _age;

    }

}