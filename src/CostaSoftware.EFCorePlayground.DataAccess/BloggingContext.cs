using CostaSoftware.EFCorePlayground.DataAccess.Entities;
using CostaSoftware.EFCorePlayground.DataAccess.Entities.ManyToMany;
using CostaSoftware.EFCorePlayground.DataAccess.Entities.OneToOne;
using CostaSoftware.EFCorePlayground.DataAccess.Entities.Self;
using CostaSoftware.EFCorePlayground.DataAccess.TypeConfigurations;
using CostaSoftware.EFCorePlayground.DataAccess.TypeConfigurations.ManyToMany;
using CostaSoftware.EFCorePlayground.DataAccess.TypeConfigurations.OneToOne;
using CostaSoftware.EFCorePlayground.DataAccess.TypeConfigurations.Self;
using Microsoft.EntityFrameworkCore;

namespace CostaSoftware.EFCorePlayground.DataAccess
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Tenant> Tenants { get; set; }

        public DbSet<Depot> Depots { get; set; }

        public DbSet<User> Users{ get; set; }

        public DbSet<Employee> Employees { get; set; }

        public BloggingContext(DbContextOptions<BloggingContext> options)
                    : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Blog>(new BlogEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<Post>(new PostEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<Tenant>(new TenantEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<User>(new UserEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<Employee>(new EmployeeEntityTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}