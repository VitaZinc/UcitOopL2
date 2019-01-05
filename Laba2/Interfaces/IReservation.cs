using Laba2.Classes;


namespace Laba2.Interfaces
{
    interface IReservation
    {
        Period Period { get; set; }
        Customer Customer { get; set; }
        Ship Ship { get; set; }
    }
}
