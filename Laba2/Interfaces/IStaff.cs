using System;


namespace Laba2.Interfaces
{
    interface IStaff:IHuman
    {
        DateTime StartWorking { get; }
        int WagePerHour { get; set; }
        int GetExperienceYears(DateTime startWorking);
    }
}
