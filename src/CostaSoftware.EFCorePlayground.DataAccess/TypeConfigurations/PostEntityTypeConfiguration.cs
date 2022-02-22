using CostaSoftware.EFCorePlayground.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CostaSoftware.EFCorePlayground.DataAccess.TypeConfigurations
{
    public class PostEntityTypeConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(e => e.PostId);
            builder.Property(e => e.PostId).ValueGeneratedOnAdd(); 
        }
    }
}
