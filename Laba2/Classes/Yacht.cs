using Laba2.Interfaces;
using System;


namespace Laba2.Classes
{

    class Yacht : Ship, IYacht
    {
        public enum YachtType
        {
            Basic,
            Comfort,
            Gorgeous,
            Unbelievable,
            BillGeytsYacht
        }

        YachtType CoolnessType { get; set; }

        public Yacht(string name, DateTime constructionYear, YachtType type) : base(name, constructionYear)
        {
            CoolnessType=type;
        }


    }
}
