using CostaSoftware.EFCorePlayground.SamuraiApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CostaSoftware.EFCorePlayground.SamuraiApp.Data;
public class SamuraiContext : DbContext
{
    public DbSet<Samurai> Samurais { get; set; }

    public DbSet<Quote> Quotes { get; set; }

    public DbSet<Battle> Battles { get; set; }

    public DbSet<Horse> Horses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=EFCorePlaygroundDB-SamuraiDB;Trusted_Connection=True;MultipleActiveResultSets=true")
            //.LogTo(Console.WriteLine);
            //.LogTo(Console.WriteLine, new [] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information);
            .LogTo(Writer, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information).EnableSensitiveDataLogging();

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Samurai>()
            .HasMany(s => s.Battles)
            .WithMany(b => b.Samurais)
            .UsingEntity<BattleSamurai>(
                bs => bs.HasOne<Battle>().WithMany(),
                bs => bs.HasOne<Samurai>().WithMany())
            .Property(bs => bs.JoinedDate).HasDefaultValueSql("getdate()");

        base.OnModelCreating(modelBuilder);
    }


    private static void Writer(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
