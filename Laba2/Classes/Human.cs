using Laba2.Interfaces;

namespace Laba2.Classes
{
    class Human : IHuman
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Human(string name, string phone, string email)
        {
            Name = name;
            PhoneNumber = phone;
            Email = email;
        }
        public virtual string Print()
        {
            return $"Имя: {Name}, Телефон: {PhoneNumber}, E-mail: {Email}";
        }
    }
}
