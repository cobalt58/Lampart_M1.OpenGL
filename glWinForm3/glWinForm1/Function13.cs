using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glWinForm1
{
    public partial class RenderControl
    {
        internal class Function13
        {
            private FirstFunc firstFunc = new FirstFunc();
            private SecondFunc secondFunc = new SecondFunc();

            public double Calculate(double x, byte choice)
            {
                return choice switch
                {
                    1 => firstFunc.Calculate(x),
                    2 => secondFunc.Calculate(x),
                    _ => 0
                };
            }

            public (double, double) CalculateY(double XMin, double XMax, double points, double YMin, double YMax, byte choice)
            {
                MathFunction currentFunction = choice switch
                {
                    1 => firstFunc,
                    2 => secondFunc,
                    _ => firstFunc
                };

                return currentFunction.GetYRange(XMin, XMax, points);
            }

            public void Graph(double XMin, double XMax, double points, double YMin, double YMax, byte choice)
            {
                glLineWidth(2);
                glColor3ub(255, 127, 80);
                glBegin(GL_LINE_STRIP);
                double prevY = double.NaN;
                double x = XMin;
                double step = (XMax - XMin) / (points - 1);
                double y = Calculate(x, choice);
                glVertex2d(x, y);

                for (int i = 1; i < points; i++)
                {
                    prevY = y;
                    x = XMin + i * step;
                    y = Calculate(x, choice);

                    if (!double.IsNaN(prevY) && Math.Abs(y - prevY) > 1.0)
                    {
                        glEnd();
                        glBegin(GL_LINE_STRIP);
                        continue;
                    }

                    glVertex2d(x, y);
                    if ((prevY * y) <= 0 && prevY != 0)
                    {
                        glEnd();
                        CrossingX(prevY, x, step, y);
                        glBegin(GL_LINE_STRIP);
                        glColor3ub(255, 127, 80);
                        glVertex2d(x, y);
                    }
                }
                glEnd();
            }

            private void CrossingX(double prevY, double x, double step, double y)
            {
                glPointSize(5);
                glColor3d(1, 0, 0);
                glBegin(GL_POINTS);
                glVertex2d(x - step / 2, (prevY + y) / 2);
                glEnd();
            }
        }
    }
}
