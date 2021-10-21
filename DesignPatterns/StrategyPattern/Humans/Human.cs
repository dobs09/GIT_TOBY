using StrategyPattern.InterfaceStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Humans
{
    public abstract class Human 
    {
        public string Navn { get; set; }
        public int Alder { get; set; }
        public EatStrategy Eat { get; set; }
        public RunStrategy Run { get; set; }
        public Human(string _Navn, int _Alder)
        {
            Navn = _Navn;
            Alder = _Alder;

        }
        public void Menneske()
        {
            Console.WriteLine("Jeg er et menneske og det er bare dejligt");
        }
    }
}
