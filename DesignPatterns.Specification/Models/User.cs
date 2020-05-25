namespace DesignPatters.Specification.Models
{
    class User
    {    
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public User(string name, int age, Gender gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        
        public override string ToString()
        {
            return $"- {Name} - {Age} - {Gender}";
        }
    }
}