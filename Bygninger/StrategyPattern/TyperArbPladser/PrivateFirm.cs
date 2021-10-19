using StrategyPattern.DatabaseTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.TyperArbPladser
{
    class PrivateFirm : SuperArbejdsplads
    {
        public PrivateFirm()
        {
            flexdatabase = new MongoDB();
        }
        public void JegEr()
        {
            Console.WriteLine("Jeg er et privatfirma");
        }


    }
}
