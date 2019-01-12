using Laba2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba2.Classes
{

    class Reservation : IReservation
    {
        public Period Period { get; }
        public Customer Customer { get;}
        public Ship Ship { get; }
        
        public Reservation(Customer client, Ship ship, Period period)
        {
            Customer = client;
            Ship = ship;
            Period = period;
        }

        
        public override string ToString()
        {
            return $"{Customer.ToString()}, {Ship.ToString()}, {Period.ToString()}";
        }



    }
}
