using CostaSoftware.EFCorePlayground.SamuraiApp.Data;
using CostaSoftware.EFCorePlayground.SamuraiApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace CostaSoftware.EFCorePlayground.SamuraiApp.ConsoleUI;
internal static class Helper
{
    private static SamuraiContext _context = new();
    public static void GetSamurais(string text)
    {
        var samurais = _context.Samurais
            .TagWith(typeof(Helper) + "GetSamurais")
            .ToList();
        Console.WriteLine($"{text}: Samurai count is {samurais.Count}");
        foreach (var item in samurais)
        {
            Console.WriteLine(item.Name);
            foreach (var q in item.Quotes)
            {
                Console.WriteLine(q);
            }
        }
    }

    public static void AddSamurai(params string[] names)
    {
        foreach (var name in names)
        {
            var samurai = new Samurai { Name = name };
            _context.Samurais.Add(samurai);
        }
        
        _context.SaveChanges();
    }
}
