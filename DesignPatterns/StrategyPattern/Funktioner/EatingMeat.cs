using StrategyPattern.InterfaceStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Funktioner
{
    public class EatingMeat : EatStrategy
    {
        public void Spiser()
        {
            Console.WriteLine("jeg er en fed kødspiser og det er bare dejligt");
        }
    }
}
