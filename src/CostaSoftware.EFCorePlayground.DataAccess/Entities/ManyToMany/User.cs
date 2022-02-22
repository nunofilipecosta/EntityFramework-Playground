namespace CostaSoftware.EFCorePlayground.DataAccess.Entities.ManyToMany
{
    public class User : Entity<int>
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public virtual ICollection<Depot>? Depots { get; set; }

        public User(int id) : base(id)
        {
        }
    }

}
