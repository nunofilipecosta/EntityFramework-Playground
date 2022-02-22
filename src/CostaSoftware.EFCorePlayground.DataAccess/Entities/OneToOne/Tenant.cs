namespace CostaSoftware.EFCorePlayground.DataAccess.Entities.OneToOne
{
    public class Tenant : Entity<int>
    {
        public string? Code { get; set; }

        public string? Name { get; set; }

        public string? Contact { get; set; }

        public string? Address { get; set; }

        public string? LogoHighResUrl { get; set; }

        public string? LogoVectorUrl { get; set; }

        public virtual TenantSettings TenantSettings { get; set; }

        public Tenant(int id) : base(id)
        {
        }
    }
}
