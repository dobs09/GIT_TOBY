using StrategyPattern.DatabaseTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.TyperArbPladser
{
    class Remote : SuperArbejdsplads
    {
        public Remote()
        {
            flexdatabase = new AzureSQL();
        }

        public void JegEr()
        {
            Console.WriteLine("Jeg er en remote arbejdsplads");
        }
    }
}
