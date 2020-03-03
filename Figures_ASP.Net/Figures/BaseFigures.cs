using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Figures_ASP.Net.Figures
{
    public abstract class BaseFigures
    {
        public string Name { get { return GetType().Name; } }
        public abstract string FormatDescription { get; set; }
        public string Parameters { get; set; }
        public string Result { get { return GetResult().ToString("N2"); } }
        double GetResult()
        {
            if (ParseParameters())
                return Calculate();
            return 0;
        }
        public abstract double Calculate();
        public abstract bool ParseParameters();
    }
}