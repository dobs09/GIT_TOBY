using StrategyPattern.Funktioner;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Humans
{
    public class Københavner : Human
    {
        public Københavner(string navn, int alder) : base(navn, alder)
        {
            

            Eat = new EatingVegetar();
            Run = new RunFast();
        }

        public void Person()
        {
            Console.WriteLine("Jeg hedder {0}, og jeg er {1} år gammel", Navn, Alder);
        }
    }
}
