using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.DatabaseTypes
{
    class MongoDB : IDatabase
    {
        public void database()
        {
            Console.WriteLine("Jeg er en mongoDB database - god til særlige relationelle datatyper som objekter");
        }
    }
}
