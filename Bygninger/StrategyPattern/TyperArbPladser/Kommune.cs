using StrategyPattern.DatabaseTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.TyperArbPladser
{
    class Kommune : SuperArbejdsplads

    {
        public Kommune()
        {
            flexdatabase = new SQL();
        }
        public void JegEr()
        {
            Console.WriteLine("Jeg er en kommune");
        }
    }
}
