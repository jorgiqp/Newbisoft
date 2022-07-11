using System.ComponentModel.DataAnnotations;

namespace Newbisoft.Models
{
    public class Comments
    {
        [Key]
        public int ComId { get; set; }
        public string User { get; set; }
        public string ComText { get; set; }
        public DateTime CreationDate { get; set; }
        public string ArticleId { get; set; }
        public override string ToString()
        {
            return CreationDate.ToString("g");
        }
        public Comments()
        {

        }
    }
}
