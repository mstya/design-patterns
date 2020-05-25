using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.FunctionalBuilder
{
    public class Person
    {
        public string Name { get; set; }
        public string Position { get; set; }
        
    }

    public abstract class FunctionalBuilder<TSubject, TSelf>
        where TSelf : FunctionalBuilder<TSubject, TSelf>
        where TSubject : new()
    {
        private readonly List<Func<TSubject, TSubject>> actions = new List<Func<TSubject, TSubject>>();
        
        public TSubject Build() 
            => actions.Aggregate(new TSubject(), (person, func) => func(person));
        
        public TSelf Do(Action<TSubject> action)
            => Add(action);
        
        private TSelf Add(Action<TSubject> action)
        {
            actions.Add(x =>
            {
                action(x);
                return x;
            });
            return (TSelf) this; 
        }
    }

    public sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
    {
        public PersonBuilder SetName(string name)
            => Do(x => x.Name = name);
    }
    
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder SetPosition(this PersonBuilder builder, string position)
            => builder.Do(x => x.Position = position);
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonBuilder()
                .SetName("Vasya")
                .SetPosition(".NET").Build();

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Position);
        }
    }
}