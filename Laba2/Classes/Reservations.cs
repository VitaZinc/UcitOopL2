using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba2.Classes
{

    class Reservations <T> : List<T> where T:Reservation
    {

        Reservation Reservation { get; }

        public bool TryAdd(T reservation)
        {
            base.Add(reservation);
            if (IsAvailableOnPeriod(reservation))
            {
                return true;
            }
            return false;
        }

        public bool IsAvailableOnPeriod(T reservation) 
        {
            var reservationsInPeriod = from r in this
                                       where r.Ship == reservation.Ship
                                       && (!reservation.Period.HasCollision(reservation.Period))
                                       select r;

            return reservationsInPeriod.Any() ? false : true;

            ////return this.Any(r =>
            //reservation.Ship == Reservation.Ship &&
            //!reservation.Period.HasCollision(Reservation.Period));

        }

        //public bool IsAvailableOnDate(Ship ship, DateTime date)
        //{
        //    return !this.Any(r => Reservation.Ship == ship
        //    && Reservation.Period.From <= date
        //    && Reservation.Period.To >= date);
        //}

    }
}
