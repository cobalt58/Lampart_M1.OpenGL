using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glWinForm1
{
    public partial class RenderControl
    {
        public class Figure13
        {
            private readonly (double x, double y)[] shapePoints = new[]
            {
                (-1.0, 2.0),
                (0.0, 2.0),
                (1.0, 1.0),
                (2.0, -1.0),
                (2.0, -2.0),
                (0.0, -1.0),
                (-1.0, 0.0)
            };

            private readonly (double x, double y)[] pointPoints = new[]
            {
                (4.0, 2.0),
                (5.0, 2.0),
                (6.0, 1.0),
                (7.0, -1.0),
                (7.0, -2.0),
                (5.0, -1.0),
                (4.0, 0.0)
            };

            public void Shape()
            {
                glLineWidth(2);
                glColor3d(0, 0, 0);
                glBegin(GL_LINES);

                for (int i = 0; i < shapePoints.Length; i++)
                {
                    var point1 = shapePoints[i];
                    var point2 = shapePoints[(i + 1) % shapePoints.Length];

                    glVertex2d(point1.x, point1.y);
                    glVertex2d(point2.x, point2.y);
                }

                glEnd();
            }

            public void Points()
            {
                glEnable(GL_POINT_SMOOTH);
                glPointSize(4);
                glColor3d(0, 0, 0);
                glBegin(GL_POINTS);

                foreach (var point in pointPoints)
                {
                    glVertex2d(point.x, point.y);
                }

                glEnd();
                glDisable(GL_POINT_SMOOTH);
            }
        }
    }
}
