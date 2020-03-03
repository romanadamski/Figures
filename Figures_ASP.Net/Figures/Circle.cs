using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Figures_ASP.Net.Figures
{
    public class Circle : BaseFigures
    {
        public override string FormatDescription { get { return "<promień r>"; } set { } }
        double radiusR;
        public override double Calculate()
        {
            return Math.PI * Math.Pow(radiusR, 2);
        }

        public override bool ParseParameters()
        {
            if (!double.TryParse(Parameters, out radiusR))
                return false;
            return true;
        }
    }
}