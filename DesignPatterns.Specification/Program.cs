using System;
using DesignPatters.Specification.Lambda;
using DesignPatters.Specification.Models;
using DesignPatters.Specification.Plain;

namespace DesignPatters.Specification
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = {
                new User("Vasya", 30, Gender.Male),
                new User("Katya", 28, Gender.Female),
                new User("Anya", 28, Gender.Female),
                new User("Ivan", 27, Gender.Male),
                new User("Petr", 27, Gender.Male)
            };
            
            UserFilter filter = new UserFilter();
            
            Console.WriteLine("Filter by age:");
            foreach (var user in filter.Filter(users, new AgeEqualSpecification(28)))
            {
                Console.WriteLine(user);
            }

            Console.WriteLine();
            Console.WriteLine("Filter by gender:");
            foreach (var user in filter.Filter(users, new GenderEqualSpecification(Gender.Male)))
            {
                Console.WriteLine(user);
            }
            
            Console.WriteLine();
            Console.WriteLine("Filter by age and gender:");
            foreach (var user in filter.Filter(users, 
                new AndSpecification(
                    new AgeEqualSpecification(27),
                    new GenderEqualSpecification(Gender.Male))))
            {
                Console.WriteLine(user);
            }

            Console.WriteLine();
            Console.WriteLine("*** Lambda specification ***");
            LambdaUserFilter lambdaFilter = new LambdaUserFilter();
            
            Console.WriteLine("Lambda filter by age:");
            foreach (var user in lambdaFilter.Filter(users, new LambdaAgeEqualSpecification(28)))
            {
                Console.WriteLine(user);
            }
            
            Console.WriteLine();
            Console.WriteLine("Lambda filter by gender:");
            foreach (var user in lambdaFilter.Filter(users, new LambdaGenderEqualSpecification(Gender.Male)))
            {
                Console.WriteLine(user);
            }
            
            Console.WriteLine();
            Console.WriteLine("Filter by age and gender:");
            foreach (var user in lambdaFilter.Filter(users, 
                new LambdaAndSpecification(
                    new LambdaAgeEqualSpecification(27),
                    new LambdaGenderEqualSpecification(Gender.Male))))
            {
                Console.WriteLine(user);
            }
        }
    }
}