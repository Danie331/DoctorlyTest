using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public partial class EventAttendee
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int AttendeeId { get; set; }
        public bool ConfirmationReceived { get; set; }

        public virtual Attendee Attendee { get; set; }
        public virtual Event Event { get; set; }
    }
}
