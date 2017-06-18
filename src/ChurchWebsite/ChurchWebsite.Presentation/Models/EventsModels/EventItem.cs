namespace ChurchWebsite.Presentation.Models.EventsModels
{
    using System;

    public class EventItem
    {
        public long RecordId { get; set; }
        public string EventText { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventDateExpiry { get; set; }
    }
}
