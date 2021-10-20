using StrategyPattern.Funktioner;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Humans
{
    class Jyder : Human
    {
        public Jyder()
        {
            Eat = new EatingVegetar();
            Run = new RunSlow();
        }
    }
}
