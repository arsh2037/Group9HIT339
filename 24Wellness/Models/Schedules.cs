namespace TennisWeb.Models
{
    public class Schedules
    {
        public int ScheduleId { get; set; }
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }

        // Foreign key for Coach
        public int CoachId { get; set; }
        public virtual Coach Coach { get; set; }

        // Many-to-many relationship between Member and Schedule
        public virtual ICollection<Member> EnrolledMembers { get; set; }
    }
}
