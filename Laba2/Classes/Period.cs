using System;

namespace Laba2.Classes
{
    class Period
    {
        DateTime From { get; }
        DateTime To { get; }

        public Period(DateTime from, DateTime to)
        {
            if (from > to) throw new ArgumentException();
            From = from;
            To = to;
        }

        public bool HasCollision(Period period)
        {
            return From >= period.To || To <= period.From;
        }


        public string Print()
        {

            return "period in progress";
        }
    }

}
