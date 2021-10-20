using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Funktioner
{
    class RunFast : RunStrategy
    {
        public void ICanRun()
        {
            Console.WriteLine("Jeg løber bare tæske hurtigt, mand!!!!");
        }
    }
}
