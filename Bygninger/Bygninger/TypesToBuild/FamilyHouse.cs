using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern_Bygninger.TypesToBuild
{
    class FamilyHouse : IBygninger
    {
        PropertyClass property = new PropertyClass();
        public void setColor()
        {
            property.Color = "yellow";
            Console.WriteLine("it is a Yellow house");
        }

        public void setHeight()
        {
            property.Height = 6;
            Console.WriteLine("it is 6m tall");

        }

        public void setType()
        {
            property.Type = "House";
            Console.WriteLine(" and it is a family House");
        }
    }
}
