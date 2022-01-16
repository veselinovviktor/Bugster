using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bugster.Data
{
    public class Board
    {
        public Board()
        {
            UserBoards = new HashSet<UserBoards>();
            Issues = new HashSet<Issue>();
            Documents = new HashSet<Document>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public IEnumerable<UserBoards> UserBoards { get; set; }

        public IEnumerable<Issue> Issues { get; set; }

        public IEnumerable<Document> Documents { get; set; }
    }
}