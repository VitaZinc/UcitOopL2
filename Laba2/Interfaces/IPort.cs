using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.Interfaces
{
    interface IPort
    {
        int MaxCapacity { get; }
        void AddShip();
        void RemoveShip();
        void ShowAllShips();
    }
}
