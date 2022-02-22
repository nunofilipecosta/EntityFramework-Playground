namespace CostaSoftware.EFCorePlayground.DataAccess.Entities.OneToOne
{
    public class TenantSettings : Entity<int>
    {
        public int OfflineTimeoutMinutes { get; set; }

        public int BreadcrumbsPrecision { get; set; }

        public string? SnapToRoadEngineApiKey { get; set; }

        public virtual Tenant? Tenant { get; set; }

        public TenantSettings(int id) : base(id)
        {
        }
    }
}
