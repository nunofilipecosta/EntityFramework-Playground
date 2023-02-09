namespace CostaSoftware.EFCorePlayground.SamuraiApp.Domain;
public interface IAuditableEntity
{
    DateTime CreatedOnUtc { get;set;}

    DateTime LastModifiedOnUtc { get;set;}
}
