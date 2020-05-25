using System;
using DesignPatters.Specification.Models;

namespace DesignPatters.Specification.Lambda
{
    class LambdaGenderEqualSpecification : ILambdaSpecification<User>
    {
        private readonly Gender _gender;

        public LambdaGenderEqualSpecification(Gender gender)
        {
            _gender = gender;
        }
        
        public Func<User, bool> Condition => t => t.Gender == _gender;
    }
}