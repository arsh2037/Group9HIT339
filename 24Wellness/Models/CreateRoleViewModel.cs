using System.ComponentModel.DataAnnotations;

namespace TennisWeb.Models
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
