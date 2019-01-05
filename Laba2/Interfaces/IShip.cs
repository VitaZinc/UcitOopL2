using System;
using Laba2.Classes;


namespace Laba2.Interfaces
{
    interface IShip
    {
        string Name { get; }
        DateTime ConstructionYear { get; }
        int GetAge(DateTime constructionYear);
    } 

}
