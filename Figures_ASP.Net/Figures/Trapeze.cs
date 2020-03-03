using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Figures_ASP.Net.Figures
{
    public class Trapeze : BaseFigures
    {
        public override string FormatDescription { get { return "<podstawa a> <podstawa b> <wysokość h>"; } set { } }
        double basisA, basisB, heightH;
        public override double Calculate()
        {
            return ((basisA + basisB) * heightH) / 2;
        }

        public override bool ParseParameters()
        {
            string[] parameters = Parameters.Split(' ');
            if (parameters.Length != 3)
                return false;
            else if (!double.TryParse(parameters[0], out basisA))
                return false;
            else if (!double.TryParse(parameters[1], out basisB))
                return false;
            else if (!double.TryParse(parameters[2], out heightH))
                return false;
            return true;
        }
    }
}