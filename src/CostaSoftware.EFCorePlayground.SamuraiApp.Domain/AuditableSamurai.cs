namespace CostaSoftware.EFCorePlayground.SamuraiApp.Domain;

public sealed class AuditableSamurai : IAuditableEntity
{
    public DateTime CreatedOnUtc { get; set ; }
    public DateTime LastModifiedOnUtc { get ; set; }
}
