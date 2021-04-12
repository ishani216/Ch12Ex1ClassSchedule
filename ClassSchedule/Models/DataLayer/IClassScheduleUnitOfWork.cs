﻿namespace ClassSchedule.Models
{
    interface IClassScheduleUnitOfWork
    {
        public Repository<Class> Classes { get; }

        public Repository<Teacher> Teachers { get; }

        public Repository<Day> Days { get; }

        public void Save();
    }
}
