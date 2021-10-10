using System;

namespace Lesson_2_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your favourite mode of transport?");
            var transport = Console.ReadLine();
            Console.WriteLine("Pick an out of the way travel destination");
            var destination = Console.ReadLine();
            Console.WriteLine("Pick an adverb e.g. playfully, sadly");
            var adverb = Console.ReadLine();
            Console.WriteLine("Pick a plural noun");
            var noun = Console.ReadLine();
            Console.WriteLine("What's your favourite mythical creature?");
            var mythicalCreature = Console.ReadLine();
            Console.WriteLine("Pick a superpower");
            var superpower = Console.ReadLine();



            Console.WriteLine($"{name.Trim()} went on a quest to find the last {mythicalCreature.Trim().ToLower()} of {destination.Trim()}.");
            Console.WriteLine($"{name.Trim()} took the {transport.Trim().ToLower()} to {destination.Trim()} and was sitting {adverb.Trim().ToLower()}");
            Console.WriteLine($"by themself, when suddenly hundreds of {noun.Trim().ToLower()} appeared");
            Console.WriteLine($"and used their secret power of {superpower.Trim().ToLower()}. {name.Trim()} was so surprised");
            Console.WriteLine($"that they forgot all about their quest, got the next {transport.Trim().ToLower()} home");
            Console.WriteLine($"and lived happily ever after.");
        }
    }
}
