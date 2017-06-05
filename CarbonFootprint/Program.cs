using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootprint
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarbonFootprint[] myCarbonFootprint = new ICarbonFootprint[3];

            myCarbonFootprint[0] = new Bicycle();
            myCarbonFootprint[1] = new Building(2500);
            myCarbonFootprint[2] = new Car(15);

            foreach (ICarbonFootprint element in myCarbonFootprint)
            {
                element.CalcCarbonFootprint();
            }
   
         }
     }
}

