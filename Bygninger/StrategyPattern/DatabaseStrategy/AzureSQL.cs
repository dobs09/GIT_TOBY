using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.DatabaseTypes
{
    class AzureSQL : IDatabase
    {
        public void database()
        {
            Console.WriteLine("jeg er er cloud database gode til remote arbejdspladser");
        }
    }
}
