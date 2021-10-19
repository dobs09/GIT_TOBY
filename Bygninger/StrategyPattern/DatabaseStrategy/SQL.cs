using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.DatabaseTypes
{
    class SQL : IDatabase
    {
        public void database()
        {
            Console.WriteLine("Jeg er en lokaldatabase - god til store steder med egen infrastruktur");
        }
    }
}
