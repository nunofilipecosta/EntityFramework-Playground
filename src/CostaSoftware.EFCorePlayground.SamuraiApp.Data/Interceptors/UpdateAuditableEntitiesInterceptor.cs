using CostaSoftware.EFCorePlayground.SamuraiApp.Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CostaSoftware.EFCorePlayground.SamuraiApp.Data.Interceptors;
internal class UpdateAuditableEntitiesInterceptor : SaveChangesInterceptor
{
    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        var dbContext = eventData.Context;
        if(dbContext is null)
        {
            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }

        IEnumerable<EntityEntry<IAuditableEntity>> entries = dbContext.ChangeTracker.Entries<IAuditableEntity>();

        foreach (var entry in entries)
        {
            if(entry.State == Microsoft.EntityFrameworkCore.EntityState.Added)
            {
                entry.Property(e => e.CreatedOnUtc).CurrentValue = DateTime.UtcNow;
                entry.Property(e => e.LastModifiedOnUtc).CurrentValue = DateTime.UtcNow;
            }

            if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Modified)
            {
                entry.Property(e => e.LastModifiedOnUtc).CurrentValue = DateTime.UtcNow;
            }
        }

        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }
}
