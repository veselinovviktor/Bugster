using System.ComponentModel.DataAnnotations;

namespace Bugster.Data
{
    public class Document
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Content { get; set; } = "Blank document";

        public int BoardId { get; set; }
        public Board Board { get; set; }
    }
}