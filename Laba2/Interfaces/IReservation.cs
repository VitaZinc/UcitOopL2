using Laba2.Classes;


namespace Laba2.Interfaces
{
    interface IReservation
    {
        Period Period { get; }
        Customer Customer { get; }
        Ship Ship { get; }
    }
}
