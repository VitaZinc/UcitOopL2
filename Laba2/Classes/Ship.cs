 using Laba2.Interfaces;
using System;

namespace Laba2.Classes
{
    class Ship : IShip
    {
        public string Name { get; set; }
        public DateTime ConstructionYear { get; set; }
        public bool IsReseved { get; set; }

        public Ship(string name, DateTime constructionYear)
        {
            Name = name;
            ConstructionYear = constructionYear;
        }

        public int GetAge(DateTime constructionYear)
        {
            int age = DateTime.Now.Year - constructionYear.Year;
            if (DateTime.Now.Month < constructionYear.Month ||
                (DateTime.Now.Month == constructionYear.Month &&
                DateTime.Now.Day < constructionYear.Day))
            {
                age--;
            }
            return age;
        }

        public string Print()
        {
             return $"Корабль: {Name}, Год производства: {ConstructionYear.Year}";
        }


    
    }
}
