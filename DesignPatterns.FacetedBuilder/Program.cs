using System;

namespace DesignPatterns.FacetedBuilder
{
    public class Person
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Code { get; set; }

        public string Position { get; set; }

        public override string ToString()
        {
            return $"{Street}, {City}, {Code} - {Position}";
        }
    }

    public class PersonBuilder
    {
        protected Person _person = new Person();

        public PersonAddressBuilder Address => new PersonAddressBuilder(_person);
        public PersonPositionBuilder Position => new PersonPositionBuilder(_person);
        
        public static implicit operator Person(PersonBuilder person)
        {
            return person._person;
        }
    }

    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            _person = person;
        }

        public PersonAddressBuilder SetStreet(string street)
        {
            _person.Street = street;
            return this;
        }

        public PersonAddressBuilder SetCity(string city)
        {
            _person.City = city;
            return this;
        }

        public PersonAddressBuilder SetCode(string code)
        {
            _person.Code = code;
            return this;
        }
    }

    public class PersonPositionBuilder : PersonBuilder
    {
        public PersonPositionBuilder(Person person)
        {
            _person = person;
        }

        public PersonPositionBuilder SetPosition(string position)
        {
            _person.Position = position;
            return this;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new PersonBuilder()
                .Address
                .SetCity("Kyiv")
                .SetCode("321123")
                .SetStreet("Khreshatik")
                .Position
                .SetPosition("SE");
            Console.WriteLine(person);
        }
    }
}