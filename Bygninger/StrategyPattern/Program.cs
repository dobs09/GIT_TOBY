using StrategyPattern.TyperArbPladser;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateFirm firm = new PrivateFirm();
            firm.DatabaseBasic();
            firm.flexdatabase.database();
            firm.JegEr();

            Kommune kom = new Kommune();
            kom.DatabaseBasic();
            kom.flexdatabase.database();
            kom.JegEr();

            Remote rem = new Remote();
            firm.DatabaseBasic();
            firm.flexdatabase.database();
            firm.JegEr();
            
        }
    }
}
