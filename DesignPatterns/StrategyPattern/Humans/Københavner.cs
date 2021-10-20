using StrategyPattern.Funktioner;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Humans
{
    class Københavner : Human
    {
        public Københavner()
        {
            Eat = new EatingVegetar();
            Run = new RunFast();
        }
    }
}
