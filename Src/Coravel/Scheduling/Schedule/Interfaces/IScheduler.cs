using System;

namespace Coravel.Scheduling.Schedule.Interfaces
{
    public interface IScheduler
    {
        IScheduleInterval Schedule(Action actionToSchedule);
    }
}