﻿
namespace SchedulerDomainModels
{
    public class Attendee
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }
}
