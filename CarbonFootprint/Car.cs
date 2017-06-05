using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CarbonFootprint
{
    class Car : ICarbonFootprint
    { 
        //constructor
        public Car(double gals)
        {
            Gallons = gals;
        }
        //properties
        private double gallons;

        public double Gallons
        {
            get { return gallons; }
            set
            {
                if (value >= 0)
                {
                    gallons = value;
                }
            }
        }
        //method
        public void CalcCarbonFootprint()
        {
            Console.WriteLine("The carbon footprint for a car that has used {0} gallons of fuel is : {1}",Gallons, Gallons * 20);
        }
    }
}
