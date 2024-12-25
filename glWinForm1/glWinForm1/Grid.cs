using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glWinForm1
{
    public partial class RenderControl
    {
        internal class Grid
        {
            public void DrawGrid()
            {
                glLineWidth(1);
                glEnable(GL_LINE_STIPPLE);
                glLineStipple(5, 0xAAAA);
                glColor3d(255, 255, 255);
                glBegin(GL_LINES);

                // 6. Малюємо вертикальні лінії від -1 до 8 (по x),
                //    при цьому y йде від -3 до 3 (дві точки, які утворюють вертикальну лінію).
                for (int i = -1; i <= 8; i++)
                {
                    glVertex2d(i, -3);           // Перша вершина (x = i, y = -3)
                    glVertex2d(i, 3);            // Друга вершина (x = i, y = 3)
                                                 // Разом це дає вертикальну лінію від (i, -3) до (i, 3).
                }

                // 7. Малюємо горизонтальні лінії від -2 до 2 (по y),
                //    при цьому x йде від -2 до 9 (дві точки, що утворюють горизонтальну лінію).
                for (int j = -2; j <= 2; j++)
                {
                    glVertex2d(-2, j);           // Перша вершина (x = -2, y = j)
                    glVertex2d(9, j);            // Друга вершина (x = 9,  y = j)
                                                 // Разом це дає горизонтальну лінію від (-2, j) до (9, j).
                }

                glEnd();
                glDisable(GL_LINE_STIPPLE);
            }
        }
    }
}
