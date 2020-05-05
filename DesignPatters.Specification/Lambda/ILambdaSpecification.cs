using System;
using DesignPatters.Specification.Models;

namespace DesignPatters.Specification.Lambda
{
    interface ILambdaSpecification<T>
    {
        Func<User, bool> Condition { get; }
    }
}