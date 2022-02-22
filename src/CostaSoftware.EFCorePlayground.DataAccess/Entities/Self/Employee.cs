namespace CostaSoftware.EFCorePlayground.DataAccess.Entities.Self
{
    public class Employee : Entity<int>
    {
        public string? Name { get; set; }

        public int SupervisorId { get; set; }

        public virtual Employee? Supervisor { get; set; }

        public Employee(int id) : base(id)
        {
        }
    }
}
