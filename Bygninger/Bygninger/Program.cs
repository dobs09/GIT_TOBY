using BuilderPattern_Bygninger.Builder;
using BuilderPattern_Bygninger.TypesToBuild;
using System;

namespace BuilderPattern_Bygninger
{
    class Program
    {
        static void Main(string[] args)
        {
            var skybuilding = new Build(new Skyskraper());
            skybuilding.CreateBuildings();
            Console.WriteLine("_________________________");
            var apartmentbuilding = new Build(new ApartmentBuilding());
            apartmentbuilding.CreateBuildings();
            Console.WriteLine("_________________________");
            var familyhouse = new Build(new FamilyHouse());
            familyhouse.CreateBuildings();
            Console.WriteLine("_________________________");
        }
    }
}
