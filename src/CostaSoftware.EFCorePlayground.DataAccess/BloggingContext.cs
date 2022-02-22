using CostaSoftware.EFCorePlayground.DataAccess.Entities;
using CostaSoftware.EFCorePlayground.DataAccess.Entities.OneToOne;
using CostaSoftware.EFCorePlayground.DataAccess.TypeConfigurations;
using CostaSoftware.EFCorePlayground.DataAccess.TypeConfigurations.OneToOne;
using Microsoft.EntityFrameworkCore;

namespace CostaSoftware.EFCorePlayground.DataAccess
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Tenant> Tenants { get; set; }

        public BloggingContext(DbContextOptions<BloggingContext> options)
                    : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Blog>(new BlogEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<Post>(new PostEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration<Tenant>(new TenantEntityTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}