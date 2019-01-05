using System.Collections.Generic;
using System.Linq;

namespace Laba2.Classes
{

    class Reservations <T> : List<T> where T:Reservation
    {

        Reservation reservation { get; set; }


        public bool TryAdd(T reservation)
        {
            if (IsAvailableOnPeriod(reservation))
            {
                base.Add(reservation);
                return true;
            }
            return false;
        }

        public bool IsAvailableOnPeriod(T reserv)
        {
            return this.All(r => !reserv.Period.HasCollision(reserv.Period)
                            && reserv.Ship == reservation.Ship);
        }

    }
}
