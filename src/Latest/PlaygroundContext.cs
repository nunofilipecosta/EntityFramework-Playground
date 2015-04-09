namespace Latest
{
    using System.Data.Entity;

    /// <summary>
    /// The playground context.
    /// </summary>
    public class PlaygroundContext : DbContext, IDbContext
    {
        public IDbSet<Courses> Courses { get; set; }
    }
}