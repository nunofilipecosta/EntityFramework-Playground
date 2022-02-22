using CostaSoftware.EFCorePlayground.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CostaSoftware.EFCorePlayground.DataAccess.TypeConfigurations
{
    public class BlogEntityTypeConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasKey(e => e.BlogId);
            builder.Property(e => e.BlogId).ValueGeneratedOnAdd();
        }
    }
}
