using _002.Enums;
using _002.Validation;
using System;
using System.Collections.Generic;

namespace _002.Entities
{
    public class Book
    {
        protected Book()
        {
            this.Id = Guid.NewGuid();
        }
        public Book(Room room, DateTime startTime, DateTime endDate)
        {
            ValidatorHelper.EnsureIsNotNull(room, "");
            ValidatorHelper.EnsureTimeIsGreaterOrEqualThan(startTime, room.StartTime, "");
            ValidatorHelper.EnsureTotalHourIsLessThan(startTime.Hour, endDate.Hour, 2, "");
            ValidatorHelper.EnsureDateIsGreaterOrEqualThan(startTime, DateTime.Now, "");
            ValidatorHelper.EnsureTimeIsLessOrEqualThan(endDate, room.EndTime, "");
            ValidatorHelper.EnsureDayOfWeekIsNotWeekend(startTime, "");

            this.Id = Guid.NewGuid();
            this.Room = room;
            this.Status = EBookStatus.InProgress;
            this.StartTime = startTime;
            this.EndTime = endDate;
        }

        public Guid Id { get; private set; }
        public Room Room { get; private set; }
        public EBookStatus Status { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }

        public void Confirm(IList<DateTime> holidays, IList<DateTime> booksForThisPeriod)
        {
            ValidatorHelper.EnrureListDontHaveDate(holidays, this.StartTime, "Error");
            ValidatorHelper.EnrureListDontHaveDateAndTime(booksForThisPeriod, this.StartTime, "Error");

            if (this.Status != EBookStatus.InProgress)
                throw new Exception("Error");

            this.Status = EBookStatus.Reserved;
        }

        public void MarkAsInProgress()
        {
            this.Room.MarkAsInUse();
            this.Status = EBookStatus.InUse;
        }

        public void Cancel()
        {
            if ((this.StartTime - DateTime.Now).Hours < 2)
                throw new Exception("Error");

            this.Status = EBookStatus.Canceled;
        }

        public void MarkAsCompleted()
        {
            this.Status = EBookStatus.Completed;
        }
    }
}
