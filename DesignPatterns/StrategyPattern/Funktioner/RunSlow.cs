using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Funktioner
{
    class RunSlow : RunStrategy
    {
        public void ICanRun()
        {
            Console.WriteLine("Jeg løber langsomt, fordi jeg er bollefed");
        }
    }
}
