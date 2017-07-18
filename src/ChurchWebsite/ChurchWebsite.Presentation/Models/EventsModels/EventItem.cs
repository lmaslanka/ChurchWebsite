namespace ChurchWebsite.Presentation.Models.EventsModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class EventItem
    {
        public long RecordId { get; set; }

        [Display(Name = "Event Title")]
        public string EventTitle { get; set; }

        [Display(Name = "Event Description")]
        public string EventText { get; set; }

        [Display(Name = "Event Date")]
        public DateTime EventDate { get; set; }

        [Display(Name = "Event Expiry Date")]
        public DateTime EventDateExpiry { get; set; }
    }
}
