using System.ComponentModel.DataAnnotations;

namespace Newbisoft.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string? First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? MobNumber { get; set; }
        public string Role { get; set; }

        public Users()
        {

        }
    }
}
