namespace CostaSoftware.EFCorePlayground.DataAccess.Entities.ManyToMany
{
    public class Depot : Entity<int>
    {
        public string? Code { get; set; }

        public string? DisplayName { get; set; }

        public virtual ICollection<User>? Users { get; set; }

        public Depot(int id) : base(id)
        {
        }
    }
}
