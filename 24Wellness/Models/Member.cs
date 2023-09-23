using System.ComponentModel.DataAnnotations.Schema;

namespace _24Wellness.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Goals { get; set; }
    
        public string ScheduleId { get; set; }
       [ForeignKey("ScheduleId")]
        public Schedules Schedules { get; set; }

    }
}
