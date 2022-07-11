using System.ComponentModel.DataAnnotations;

namespace Newbisoft.Models
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }
        public string? Topic { get; set; }
        public byte? Photo { get; set; }
        public string Link { get; set; }
        public DateTime CreationDate { get; set; }

        public override string ToString()
        {
            return CreationDate.ToString("g");
        }

        public Article()
        {

        }
    }
}
