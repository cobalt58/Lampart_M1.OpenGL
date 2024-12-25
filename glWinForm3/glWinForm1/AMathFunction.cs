using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glWinForm1
{
    public abstract class MathFunction
    {
        public abstract double Calculate(double x);
        public abstract (double min, double max) GetYRange(double xMin, double xMax, double points);
    }

}