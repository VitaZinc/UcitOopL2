using Laba2.Interfaces;

namespace Laba2.Classes
{
    class Human : IHuman
    {
        public string Name { get; }
        public string PhoneNumber { get; }
        public string Email { get; }
        public Human(string name, string phone, string email)
        {
            Name = name;
            PhoneNumber = phone;
            Email = email;
        }
        public override string ToString() => $"Имя: {Name}, Телефон: {PhoneNumber}, E-mail: {Email}";
    }
}
