﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPA_Zkouska
{
    public class ChemMath
    {
        public static double ToMolarAmount(double weight, double molarMass)
        {
            return weight / molarMass;
        }

        public static double ToMolarConcentration(double molarAmount, double volume)
        {
            return molarAmount / volume;
        }

    }
}
