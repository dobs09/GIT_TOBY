using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern.LINQ_Mennesker
{
    public class LINQ_Liste
    {
        public string name { get; set; }
        public int alder { get; set; }
        public string country { get; set; }

        public static void HumanListe()
        {
            ArrayList humanlist = new ArrayList()
            {
                new LINQ_Liste { name = "Mogens", country = "Uganda", alder = 81 },
                new LINQ_Liste { name = "Jørgen", country = "Egypten", alder = 79 },
                new LINQ_Liste { name = "Svend", country = "Ghana", alder = 89 },
                new LINQ_Liste { name = "Gitte", country = "Botswana", alder = 67 },
                new LINQ_Liste { name = "Ulla", country = "Congo", alder = 58 }
            };

            var enumHumanList = humanlist.OfType<LINQ_Liste>();

            var oldHuman = from human in enumHumanList
                           where human.alder > 60
                           select human;
            foreach (var person in oldHuman){
                Console.WriteLine("{0} er {1} år gammel og bor i {2}", person.name, person.alder, person.country);
            }
        }
        
    }
}
