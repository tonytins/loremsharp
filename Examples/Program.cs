using System;
using System.Diagnostics;
using LoremSharp;

namespace Examples
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Email: {Lorem.Email()}");
            Console.WriteLine($"Chance: {Lorem.Chance(1, 2)}");
            Console.WriteLine($"Words: {Lorem.Words(5)}");
            Console.WriteLine($"Sentence: {Lorem.Sentence(5, 25)}{Environment.NewLine}");

            Console.WriteLine("Change the source...");
            Source.Update("Alright stop collaborate and listen ice is back with my brand new invention something grabs a hold of me tightly flow like a harpoon daily and nightly will it ever stop yo I don't know turn off the lights and I'll glow");

            Console.WriteLine($"New sentence: {Lorem.Sentence(5, 25)}{Environment.NewLine}");
            Console.WriteLine("Press any key to exit...");

            if (!Debugger.IsAttached)
                Console.ReadKey();
        }
    }
}