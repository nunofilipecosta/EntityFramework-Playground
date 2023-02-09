// See https://aka.ms/new-console-template for more information
using CostaSoftware.EFCorePlayground.SamuraiApp.ConsoleUI;

Console.WriteLine("Hello, World!");

//Helper.GetSamurais("Before Add:");
Helper.AddSamurai("Test 1", "Test 2", "Test 3", "Test 4");
Helper.GetSamurais("After Add");
Console.Write("Press any key ...");
Console.ReadKey();