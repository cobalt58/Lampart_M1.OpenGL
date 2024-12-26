using System;
using System.Collections.Generic;
using static glWinForm1.OpenGL;

namespace glWinForm1
{
    public class Circle : IShape2D
    {
        public double H { get; set; }
        public double K { get; set; }
        public double R { get; set; }

        private const int SEGMENTS = 100;

        public Circle(double h, double k, double r)
        {
            H = h;
            K = k;
            R = r;
        }

        public void Draw()
        {
            glColor3ub(255, 127, 80);  // колір
            glBegin(GL_LINE_LOOP);
            for (int i = 0; i <= SEGMENTS; i++)
            {
                double theta = 2.0 * Math.PI * i / SEGMENTS;
                double x = H + R * Math.Cos(theta);
                double y = K + R * Math.Sin(theta);
                glVertex2d(x, y);
            }
            glEnd();
        }

        public List<(double x, double y)> GetIntersections(double x1, double y1, double x2, double y2)
        {
            // Перетворимо задачу на знаходження t у рівнянні прямої
            double dx = x2 - x1;
            double dy = y2 - y1;

            // Коефіцієнти квадратного рівняння A t^2 + B t + C = 0
            double A = dx * dx + dy * dy;
            double B = 2 * (dx * (x1 - H) + dy * (y1 - K));
            double C = (x1 - H) * (x1 - H) + (y1 - K) * (y1 - K) - R * R;

            double D = B * B - 4 * A * C;  // дискримінант
            List<(double x, double y)> result = new List<(double x, double y)>();

            if (D < 0)
                return result;

            // Знаходимо два розв’язки
            double sqrtD = Math.Sqrt(D);
            double t1 = (-B - sqrtD) / (2 * A);
            double t2 = (-B + sqrtD) / (2 * A);

            // Перевіряємо, чи лежать ці точки на відрізку (0 <= t <= 1)
            if (t1 >= 0 && t1 <= 1)
            {
                double ix = x1 + t1 * dx;
                double iy = y1 + t1 * dy;
                result.Add((ix, iy));
            }
            if (t2 >= 0 && t2 <= 1)
            {
                double ix = x1 + t2 * dx;
                double iy = y1 + t2 * dy;
                result.Add((ix, iy));
            }

            return result;
        }
    }
}
