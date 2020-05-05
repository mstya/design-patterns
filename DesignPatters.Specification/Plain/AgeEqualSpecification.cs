using DesignPatters.Specification.Models;

namespace DesignPatters.Specification.Plain
{
    class AgeEqualSpecification : ISpecification<User>
    {
        private readonly int _age;

        public AgeEqualSpecification(int age)
        {
            _age = age;
        }
        
        public bool IsSatisfy(User t)
        {
            return t.Age == _age;
        }
    }
}