using System.Collections.Generic;

namespace Laba2.Classes
{

    class Reservations <T> : List<T> where T:Reservation
    {

        Reservation reservation { get; set; }


        public new void Add(T reservation)
        {
            if (reservation.IsAvailableOnPeriod())
                base.Add(reservation);
        }

    
    }
}
