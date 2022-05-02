using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Event
    {
        public Event()
        {
            EventAttendee = new HashSet<EventAttendee>();
            EventNotification = new HashSet<EventNotification>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual ICollection<EventAttendee> EventAttendee { get; set; }
        public virtual ICollection<EventNotification> EventNotification { get; set; }
    }
}
