using StrategyPattern.Humans;
using StrategyPattern.LINQ_Mennesker;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Københavner køben = new Københavner("Jens", 29);
            køben.Person();
            køben.Run.ICanRun();
            køben.Eat.Spiser();
            Console.WriteLine("---------------------");

            Jyder jyde = new Jyder("Gitte", 49);
            jyde.Person();
            jyde.Run.ICanRun();
            jyde.Eat.Spiser();
            Console.WriteLine("---------------------");

            LINQ_Liste.HumanListe();
        }
    }
}
