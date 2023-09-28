using System.ComponentModel.DataAnnotations;

namespace TennisWeb.Models
{
    public class IdentityRoles
    {
        [Required]
        public string Name { get; set; }

        public string Role { get; set; }
        public int Id { get; set; }
    }
}
