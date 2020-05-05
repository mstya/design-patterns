using DesignPatters.Specification.Models;

namespace DesignPatters.Specification.Plain
{
    class AndSpecification : ISpecification<User>
    {
        private readonly ISpecification<User> _s1;
        private readonly ISpecification<User> _s2;

        public AndSpecification(ISpecification<User> s1, ISpecification<User> s2)
        {
            _s1 = s1;
            _s2 = s2;
        }
        
        public bool IsSatisfy(User t)
        {
            return _s1.IsSatisfy(t) && _s2.IsSatisfy(t);
        }
    }
}