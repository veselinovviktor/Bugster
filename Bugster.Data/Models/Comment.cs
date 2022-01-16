using System;
using System.ComponentModel.DataAnnotations;

namespace Bugster.Data
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }

        public DateTime Created { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}