namespace DesignPatters.Specification.Plain
{
    interface ISpecification<T>
    {
        bool IsSatisfy(T t);
    }
}