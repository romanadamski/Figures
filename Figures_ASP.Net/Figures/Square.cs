using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Figures_ASP.Net.Figures
{
    public class Square : BaseFigures
    {
        public override string FormatDescription { get { return "<bok a>"; } set { } }
        double sideA;
        public override double Calculate()
        {
            return sideA * sideA;
        }

        public override bool ParseParameters()
        {
            if (!double.TryParse(Parameters, out sideA))
                return false;
            return true;
        }
    }
}