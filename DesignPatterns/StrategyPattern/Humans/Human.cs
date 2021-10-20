using StrategyPattern.InterfaceStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Humans
{
    public abstract class Human 
    {
        public EatStrategy Eat { get; set; }
        public RunStrategy Run { get; set; }
        public void Menneske()
        {
            Console.WriteLine("Jeg er et menneske og det er bare dejligt");
        }
    }
}
