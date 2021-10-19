using System;
using System.Collections.Generic;
using System.Text;


namespace BuilderPattern_Bygninger.Builder
{
    class Build
    {
        public IBygninger bygninger {get; set;}

        public Build(IBygninger _bygninger)
        {
            bygninger = _bygninger;
        }

        public void CreateBuildings()
        {
            bygninger.setColor();
            bygninger.setHeight();
            bygninger.setType();
        }
        
        
    }
}
