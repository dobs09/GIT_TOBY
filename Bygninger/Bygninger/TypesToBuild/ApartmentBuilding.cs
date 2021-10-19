using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern_Bygninger.TypesToBuild
{
    class ApartmentBuilding : IBygninger
    {
        PropertyClass property = new PropertyClass();
        public void setColor()
        {
            property.Color = "Red";
            Console.WriteLine("it is a red building");
        }

        public void setHeight()
        {
            property.Height = 15;
            Console.WriteLine("it is 15 m tall");
        }

        public void setType()
        {
            property.Type = "Apartments";
            Console.WriteLine("It is an apartments complex");
        }
    }
}
