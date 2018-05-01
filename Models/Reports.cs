using System;

namespace RAMPControl.API.Models
{
    public class Reports
    {
        public int Id {get; set;}
        public DateTime DateTime { get; set; }
        public string ReportHeading { get; set; }
        public string ReportText { get; set; }
        public string CreatedBy { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }
    }
}