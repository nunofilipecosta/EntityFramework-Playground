namespace Latest
{
    using System.Data.Entity;

    public interface IDbContext
    {
        IDbSet<Courses> Courses { get; set; }
    }
}