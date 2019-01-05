using Laba2.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Laba2.Classes
{

    class Reservation : IReservation
    {
        public Period Period { get; set; }
        public Customer Customer { get; set; }
        public Ship Ship { get; set; }

        public Reservation(Customer client, Ship ship, Period period)
        {
            Customer = client;
            Ship = ship;
            Period = period;
        }

        public List<Reservation> GetReservatons()
        {
            return new List<Reservation>();

        }

        public bool IsAvailableOnPeriod()
        {
            List<Reservation> reservations = GetReservatons();
            var reservationsInPeriod = from reservation in reservations
                                       where reservation.Ship == Ship
                                       && (!Period.HasCollision(Period))
                                       select reservation;

            return reservationsInPeriod.Any() ? false : true;
        }
        public string Print()
        {
            return $"{Customer.Print()}, {Ship.Print()}, {Period.Print()}";
        }



    }
}
