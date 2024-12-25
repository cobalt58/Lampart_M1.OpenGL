using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glWinForm1
{
    internal class FirstFunc: MathFunction
    {
        public override double Calculate(double x)
        {
            return (Math.Abs(Math.Cos(0.5 * x + 1)) * Math.Cos(x)) / Math.Abs(Math.Cos(x + 0.01));
        }

        public override (double min, double max) GetYRange(double xMin, double xMax, double points)
        {
            double min = double.MaxValue;
            double max = double.MinValue;
            double step = (xMax - xMin) / (points - 1);

            for (int i = 0; i < points; i++)
            {
                double x = xMin + i * step;
                double y = Calculate(x);

                if (!double.IsNaN(y) && !double.IsInfinity(y))
                {
                    min = Math.Min(min, y);
                    max = Math.Max(max, y);
                }
            }

            return (min, max);
        }
    }
}

