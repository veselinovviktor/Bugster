using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bugster.Data
{
    internal class IssueConfiguration : IEntityTypeConfiguration<Issue>
    {
        public void Configure(EntityTypeBuilder<Issue> issue)
        {
            issue.HasOne(a => a.User)
                .WithMany(x => x.Issues)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            issue.HasOne(x => x.Board)
                .WithMany(x => x.Issues)
                .HasForeignKey(x => x.BoardId)
                .OnDelete(DeleteBehavior.NoAction); ;
        }
    }
}