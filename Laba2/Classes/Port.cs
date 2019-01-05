using Laba2.Interfaces;
using System;

namespace Laba2.Classes
{
    class Port : IPort
    {
        public int MaxCapacity { get; }

        public void AddShip()
        {
            ;
        }

        public void RemoveShip()
        {
            throw new NotImplementedException();
        }

        public void ShowAllShips()
        {
            throw new NotImplementedException();
        }
    }
}
