using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Figures_ASP.Net.Figures
{
    public class Triangle : BaseFigures
    {
        public override string FormatDescription { get { return "<podstawa a> <wysokość h>"; } set { } }
        double basisA, heightH;
        public override double Calculate()
        {
            return ( basisA * heightH ) / 2;
        }

        public override bool ParseParameters()
        {
            string[] parameters = Parameters.Split(' ');
            if (parameters.Length != 2)
                return false;
            else if (!double.TryParse(parameters[0], out basisA))
                return false;
            else if (!double.TryParse(parameters[1], out heightH))
                return false;
            return true;
        }
    }
}