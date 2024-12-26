using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static glWinForm1.OpenGL;

namespace glWinForm1
{
    public partial class RenderControl : OpenGL
    {
        // Тепер тут зберігається поточна фігура (коло / гіпербола).
        public IShape2D CurrentShape { get; set; }

        // Межі області малювання
        private double margin = 10.0;

        // Дані для відрізка
        public double XStart { get; set; }
        public double YStart { get; set; }
        public double XEnd { get; set; }
        public double YEnd { get; set; }
        public bool DrawLine { get; set; } = false;

        public RenderControl()
        {
            InitializeComponent();
            this.MouseClick += RenderControl_MouseClick;
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
            glViewport(0, 0, Width, Height);

            // Ортонормальне проєціювання
            gluOrtho2D(-margin, margin, -margin, margin);

            // Малюємо сітку та осі
            Grid(-margin, margin, -margin, margin);
            Axis(-margin, margin, -margin, margin);

            // Малюємо поточну фігуру, якщо вона задана
            CurrentShape?.Draw();

            // Якщо користувач клацнув двічі і є відрізок – малюємо його
            if (DrawLine)
            {
                glColor3ub(0, 0, 0);
                glBegin(GL_LINES);
                glVertex2d(XStart, YStart);
                glVertex2d(XEnd, YEnd);
                glEnd();

                // Знаходимо точки перетину з поточною фігурою
                var points = CurrentShape?.GetIntersections(XStart, YStart, XEnd, YEnd);

                if (points != null && points.Count > 0)
                {
                    glColor3d(1, 0, 0);
                    glPointSize(4);
                    glBegin(GL_POINTS);
                    foreach (var p in points)
                    {
                        glVertex2d(p.x, p.y);
                    }
                    glEnd();
                }
            }
        }

        private void RenderControl_MouseClick(object sender, MouseEventArgs e)
        {
            double viewportSize = (Width > Height) ? Height : Width;
            double xOffset = (Width > Height) ? (Width - Height) / 2.0 : 0;
            double yOffset = (Width > Height) ? 0 : (Height - Width) / 2.0;

            // Переводимо піксельні координати в Normalized Device Coordinates (-1..1)
            double normalizedX = (e.X - xOffset) / viewportSize * 2.0 - 1.0;
            // Увага, для Y йде «дзеркало»:
            double normalizedY = -((e.Y - yOffset) / viewportSize * 2.0 - 1.0);

            // Тепер маштабуємо під нашу margin
            double x = normalizedX * margin;
            double y = normalizedY * margin;

            if (e.Button == MouseButtons.Left)
            {
                // Перша точка відрізка
                XStart = x;
                YStart = y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                // Друга точка відрізка
                XEnd = x;
                YEnd = y;
                DrawLine = true;
            }

            Invalidate();
        }

        private void Grid(double xMin, double xMax, double yMin, double yMax)
        {
            glLineWidth(0.3f);
            glColor3d(0.5, 0.5, 0.5);
            glBegin(GL_LINES);
            for (double i = xMin; i <= xMax; i++)
            {
                glVertex2d(i, yMin);
                glVertex2d(i, yMax);
            }
            for (double i = yMin; i <= yMax; i++)
            {
                glVertex2d(xMin, i);
                glVertex2d(xMax, i);
            }
            glEnd();
        }

        private void Axis(double xMin, double xMax, double yMin, double yMax)
        {
            glLineWidth(2);
            glColor3d(0, 0, 0);
            glBegin(GL_LINES);
            glVertex2d(xMin, 0);
            glVertex2d(xMax, 0);
            glVertex2d(0, yMin);
            glVertex2d(0, yMax);
            glEnd();
        }
    }
}
