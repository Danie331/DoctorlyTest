using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class Attendee
    {
        public Attendee()
        {
            EventAttendee = new HashSet<EventAttendee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<EventAttendee> EventAttendee { get; set; }
    }
}
