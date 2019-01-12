using System;

namespace Laba2.Classes
{
    class Period
    {
        public DateTime From { get; }
        public DateTime To { get; }

        public Period(DateTime from, DateTime to)
        {
            if (from > to) throw new ArgumentException();
            From = from;
            To = to;
        }

        public bool HasCollision(Period period) => !(period.To < From || period.From > To);

        public override string ToString() => $"Период: с {From.ToString("d")} по {To.ToString("d")}";
    }

}
