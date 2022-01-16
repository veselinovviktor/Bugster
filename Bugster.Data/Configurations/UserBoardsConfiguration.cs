using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bugster.Data
{
    internal class UserBoardsConfiguration : IEntityTypeConfiguration<UserBoards>
    {
        public void Configure(EntityTypeBuilder<UserBoards> builder)
        {
            builder.HasKey(x => new { x.UserId, x.BoardId });

            builder.HasOne(x => x.Board)
                .WithMany(x => x.UserBoards)
                .HasForeignKey(x => x.BoardId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.User)
                .WithMany(x => x.UserBoards)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}