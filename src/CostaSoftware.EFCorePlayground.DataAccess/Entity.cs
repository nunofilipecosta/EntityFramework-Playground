namespace CostaSoftware.EFCorePlayground.DataAccess
{
    public class Entity<TKey>
    {
        public Entity(TKey id)
        {
            Id = id;
        }

        // EF convention requires that the Id property must have an explicitly declared private set:
        // https://docs.microsoft.com/en-us/ef/core/modeling/constructors#read-only-properties
        public TKey Id { get; private set; }
    }
}
