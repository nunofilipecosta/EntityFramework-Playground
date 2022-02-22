using CostaSoftware.EFCorePlayground.DataAccess.Entities.OneToOne;
using CostaSoftware.EFCorePlayground.DataAccess.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CostaSoftware.EFCorePlayground.DataAccess.TypeConfigurations.OneToOne
{
    public class TenantEntityTypeConfiguration : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {
            builder.IsEntity<Tenant, int>();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(200);
            builder.HasIndex(e => e.Code).IsUnique();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(2000);

            builder.Property(e => e.Contact).HasMaxLength(2000);
            builder.Property(e => e.Address).HasMaxLength(2000);
            builder.Property(e => e.LogoHighResUrl).HasMaxLength(500);
            builder.Property(e => e.LogoVectorUrl).HasMaxLength(500);

            builder.HasOne(e => e.TenantSettings)
                .WithOne(e => e.Tenant)
                .HasForeignKey<TenantSettings>(e => e.Id);
        }
    }
}
