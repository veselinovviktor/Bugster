namespace Bugster.Data
{
    public class UserBoards
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int BoardId { get; set; }
        public Board Board { get; set; }
        public bool IsAuthorised { get; set; }
    }
}