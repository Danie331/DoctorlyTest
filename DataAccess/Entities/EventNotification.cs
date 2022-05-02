using System;
using System.Collections.Generic;

namespace DataAccess.Entities
{
    public class EventNotification
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public bool Sent { get; set; }
        public DateTime DateSent { get; set; }

        public virtual Event Event { get; set; }
    }
}
