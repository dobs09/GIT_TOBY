using StrategyPattern.InterfaceStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Funktioner
{
    class EatingVegetar : EatStrategy
    {
        public void Spiser()
        {
            Console.WriteLine("Jeg elsker dyr, så jeg spiser kun vegetar mad");
        }
    }
}
