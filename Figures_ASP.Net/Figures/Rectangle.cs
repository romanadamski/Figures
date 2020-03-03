using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Figures_ASP.Net.Figures
{
    public class Rectangle : BaseFigures
    {
        public override string FormatDescription { get { return "<bok a> <bok b>"; } set { } }
        double sideA, sideB;
        public override double Calculate()
        {
            return sideA * sideB;
        }

        public override bool ParseParameters()
        {
            string[] parameters = Parameters.Split(' ');
            if (parameters.Length != 2)
                return false;
            else if (!double.TryParse(parameters[0], out sideA))
                return false;
            else if (!double.TryParse(parameters[1], out sideB))
                return false;
            return true;
        }
    }
}