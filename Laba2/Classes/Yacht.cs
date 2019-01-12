using Laba2.Interfaces;
using System;
using Laba2.Enums;


namespace Laba2.Classes
{

    class Yacht : Ship, IYacht
    {

        YachtTypes CoolnessType { get; set; }

        public Yacht(string name, DateTime constructionYear, YachtTypes type) : base(name, constructionYear)
        {
            CoolnessType=type;
        }


    }
}
