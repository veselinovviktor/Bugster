using System.ComponentModel.DataAnnotations;

namespace Bugster.Data
{
    public class Issue
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        public IssueStatus Status { get; set; }

        public IssuePriority Priority { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int BoardId { get; set; }

        public Board Board { get; set; }
    }
}