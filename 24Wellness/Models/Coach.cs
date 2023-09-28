using System.ComponentModel.DataAnnotations.Schema;

namespace TennisWeb.Models
{
    public class Coach
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        // Navigation properties
        public string ScheduleId { get; set; }
        [ForeignKey("ScheduleId")]
        public string Schedules { get; set; }
    }
}
