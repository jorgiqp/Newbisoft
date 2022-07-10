using System.ComponentModel.DataAnnotations;

namespace Newbisoft.Models
{
    public class Roles
    {
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; }
        public Roles()
        {

        }
    }
}
