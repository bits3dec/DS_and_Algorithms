﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Bridges
{
    public class MyCityComparer : IComparer<CityPair>
    {
        //Sorts the city pair based on the south points
        //If southern points are equal then sort based on northern points
        public int Compare(CityPair a, CityPair b)
        {
            if (a.x_South == b.x_South)
                return a.x_North - b.x_North;

            return a.x_South - b.x_South;
        }
    }
}
