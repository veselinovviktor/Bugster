using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bugster.Data
{
    public class BoardConfiguration : IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> board)
        {
            board.HasMany(x => x.Documents)
                .WithOne(x => x.Board)
                .HasForeignKey(x => x.BoardId);
        }
    }
}