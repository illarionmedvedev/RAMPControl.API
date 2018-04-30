namespace RAMPControl.API.Models
{
    public class DailyWorkComment
    {
        public int Id { get; set; }
        public string DateTime { get; set; }
        public string CommentHeading { get; set; }
        public string CommentText { get; set; }
    }
}