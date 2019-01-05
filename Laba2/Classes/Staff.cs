using Laba2.Interfaces;
using System;


namespace Laba2.Classes
{
    class Staff : Human, IStaff
    {

        public DateTime StartWorking { get; set; }
        public int WagePerHour { get; set; }

        public Staff(string name, string phone, string email, DateTime startWorking, int wagePerHour) : base(name, phone, email)
        {

            StartWorking = startWorking;
            WagePerHour = wagePerHour;
        }

        public override string Print()
        {
            return $"{base.Print()}, Работает с: {StartWorking}, З/п в час: {WagePerHour}";
        }

        public int GetExperienceYears(DateTime startWorking)
        {
            int yearsWorked = DateTime.Now.Year - startWorking.Year;
            return yearsWorked;
        }

    }
}
