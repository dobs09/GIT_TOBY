using StrategyPattern.Humans;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Københavner køben = new Københavner();
            køben.Run.ICanRun();
            køben.Eat.Spiser();
            Console.WriteLine("---------------------");

            Jyder jyde = new Jyder();
            jyde.Run.ICanRun();
            jyde.Eat.Spiser();
            Console.WriteLine("---------------------");

        }
    }
}
