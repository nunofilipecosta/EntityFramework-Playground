using CostaSoftware.EFCorePlayground.DataAccess.Entities.Self;
using CostaSoftware.EFCorePlayground.DataAccess.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CostaSoftware.EFCorePlayground.DataAccess.TypeConfigurations.Self
{
    public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.IsEntity<Employee, int>();

            builder.HasOne(e => e.Supervisor)
                .WithMany()
                .HasForeignKey(e => e.SupervisorId)
                .IsRequired(false);
        }
    }
}
