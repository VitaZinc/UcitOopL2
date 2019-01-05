using Laba2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ship> ships = new List<Ship>();
            Ship lastochka = new Ship("Lastochka", new DateTime(2015, 7, 20));
            Ship kruzenshtern = new Ship("Ivan Kruzenshtern", new DateTime(1998, 1, 1));
            Ship dracula = new Ship("Graf Dracula", new DateTime(1700, 12, 02));
            ships.Add(lastochka);
            ships.Add(kruzenshtern);
            ships.Add(dracula);
            Customer ivan = new Customer("Ivan Ivanov", "1234567","ivanushka@mail.ru", PaymentType.Cash);
            Customer sergey = new Customer("Sergey Anonim", "55555555", "shnurov@bk.ru", PaymentType.Promises);
            List<Reservation>reservations = new List<Reservation>();
    
            Reservation reserv1 = new Reservation(ivan, lastochka, new Period(new DateTime(2019, 5, 10), new DateTime(2019, 5, 12)));
            Reservation reserv2 = new Reservation(sergey, lastochka, new Period(new DateTime(2019, 5, 10), new DateTime(2019, 5, 12)));
            
            if (reserv1.IsAvailableOnPeriod())
                reservations.Add(reserv1);
            if (reserv2.IsAvailableOnPeriod())
                reservations.Add(reserv2);



            foreach (var r in reservations)
                Console.WriteLine(r.Print());

            
            
        }


    }
}
