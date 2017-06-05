using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootprint
{
    class Building : ICarbonFootprint
    {
        //constructor
        public Building(int squarefeet)
        {
            SquareFeet = squarefeet;
        }
        //properties
        private int sqft;
        public int SquareFeet
        {
            get { return sqft; }
            set
            {
                if (value >= 0)
                {
                    sqft = value;
                }
            }
        }
        //method
        public void CalcCarbonFootprint()
        {
            Console.WriteLine("The carbon footprint for a building of {0} square feet is :{1}",SquareFeet, SquareFeet * 134);
        }
    }
}
