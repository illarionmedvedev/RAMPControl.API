using System;

namespace RAMPControl.API.Dtos
{
    public class UserForListDto
    {
        public int Id {get; set;}
        public DateTime DateTime { get; set; }
        public string ReportHeading { get; set; }
        public string ReportText { get; set; }
        public string CreatedBy { get; set; }
    }
}