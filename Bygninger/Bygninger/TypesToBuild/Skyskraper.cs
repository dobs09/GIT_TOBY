using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern_Bygninger.TypesToBuild
{
    class Skyskraper : IBygninger
    {
        PropertyClass property = new PropertyClass();
        public void setColor()
        {
            property.Color = "Glass";
            Console.WriteLine("It is a Glass building");
        }

        public void setHeight()
        {
            property.Height = 325;
            Console.WriteLine("Height is 325m");
        }

        public void setType()
        {
            property.Type = "Skyskraper";
            Console.WriteLine("The type is a skyskraper");
        }
    }
}
