using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glWinForm1
{
    internal class SecondFunc : MathFunction
    {
        public override double Calculate(double x)
        {
            return (Math.Cos(Math.PI * x / 2) * Math.Cos(Math.Abs(Math.PI * x))) / Math.Abs(Math.Sin(Math.PI * x));
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
