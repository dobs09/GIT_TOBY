using StrategyPattern.Funktioner;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Humans
{
    class Jyder : Human
    {
        public Jyder(string navn, int alder) : base(navn, alder)
        {
            Eat = new EatingMeat();
            Run = new RunSlow();
        }

        public void Person()
        {
            Console.WriteLine("Jeg hedder {0}, og jeg er {1} år gammel", Navn, Alder);
        }
    }
}
