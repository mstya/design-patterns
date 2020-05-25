using DesignPatters.Specification.Models;

namespace DesignPatters.Specification.Plain
{
    class GenderEqualSpecification : ISpecification<User>
    {
        private readonly Gender _gender;

        public GenderEqualSpecification(Gender gender)
        {
            _gender = gender;
        }
        
        public bool IsSatisfy(User t)
        {
            return t.Gender == _gender;
        }
    }
}