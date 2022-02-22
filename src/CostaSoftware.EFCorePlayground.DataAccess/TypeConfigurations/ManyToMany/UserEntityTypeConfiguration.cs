using CostaSoftware.EFCorePlayground.DataAccess.Entities.ManyToMany;
using CostaSoftware.EFCorePlayground.DataAccess.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CostaSoftware.EFCorePlayground.DataAccess.TypeConfigurations.ManyToMany
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.IsEntity<User, int>();
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.FirstName).HasMaxLength(200);
            builder.Property(e => e.LastName).HasMaxLength(200);

            builder
                .HasMany<Depot>(e => e.Depots)
                .WithMany(e => e.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "Users_Depots",
                    j => j.HasOne<Depot>().WithMany().HasForeignKey("DepotId"),
                    j => j.HasOne<User>().WithMany().HasForeignKey("UserId"));
        }

    }
}
