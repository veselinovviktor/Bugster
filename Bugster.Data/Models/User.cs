using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bugster.Data
{
    public class User
    {
        public User()
        {
            Issues = new HashSet<Issue>();
            UserBoards = new HashSet<UserBoards>();
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(10)]
        public string Password { get; set; }

        public IEnumerable<Issue> Issues { get; set; }

        public IEnumerable<UserBoards> UserBoards { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
    }
}