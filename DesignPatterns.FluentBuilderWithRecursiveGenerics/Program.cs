using System;

namespace DesignPatterns.FluentBuilderWithRecursiveGenerics
{
    class Person
    {
        public string Name { get; set; }
        public string Position { get; set; }
        
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }

        public class Builder : PersonNameAndPositionBuilder<Builder>
        {
            
        }

        public static Builder New => new Builder();
    }

    abstract class PersonBuilder 
    {
        protected Person _person = new Person();

        public Person Build()
        {
            return _person;
        }
    }
    
    class PersonNameBuilder<TSelf> : PersonBuilder
        where TSelf : PersonNameBuilder<TSelf>
    {
        public TSelf WithName(string name)
        {
            _person.Name = name;
            return (TSelf) this;
        }
    }

    class PersonNameAndPositionBuilder<TSelf> : PersonNameBuilder<PersonNameAndPositionBuilder<TSelf>>
        where TSelf : PersonNameAndPositionBuilder<TSelf>
    {
        public TSelf WithPosition(string position)
        {
            _person.Position = position;
            return (TSelf) this;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.New.WithPosition(".net lead").WithName("Pes").Build();
            Console.WriteLine(person);
        }
    }
}