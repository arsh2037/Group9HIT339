using System.ComponentModel.DataAnnotations.Schema;

namespace _24Wellness.Models
{
    public class Coach
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        // Navigation properties
        public string  ScheduleId { get; set; }
        [ForeignKey("ScheduleId")]
        public Schedules Schedules { get; set; }
    }
}
