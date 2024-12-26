using System;
using System.Collections.Generic;
using static glWinForm1.OpenGL;

namespace glWinForm1
{
    public class HorizontalHyperbola : IShape2D
    {
        public double H { get; set; }
        public double K { get; set; }
        public double A { get; set; }
        public double B { get; set; }

        // Наскільки далеко малювати гілки гіперболи
        private const double TMax = 5.0;
        private const double Step = 0.1;

        public HorizontalHyperbola(double h, double k, double a, double b)
        {
            H = h;
            K = k;
            A = a;
            B = b;
        }

        public void Draw()
        {
            glColor3ub(255, 127, 80);

            // Права гілка
            glBegin(GL_LINE_STRIP);
            for (double t = -TMax; t <= TMax; t += Step)
            {
                double x = H + A * Math.Cosh(t);
                double y = K + B * Math.Sinh(t);
                glVertex2d(x, y);
            }
            glEnd();

            // Ліва гілка (змінюємо знак)
            glBegin(GL_LINE_STRIP);
            for (double t = -TMax; t <= TMax; t += Step)
            {
                double x = H - A * Math.Cosh(t);
                double y = K - B * Math.Sinh(t);
                glVertex2d(x, y);
            }
            glEnd();
        }

        public List<(double x, double y)> GetIntersections(double x1, double y1, double x2, double y2)
        {
            // Переводимо відрізок у локальні координати (щоб центр гіперболи був у (0,0))
            x1 -= H; y1 -= K;
            x2 -= H; y2 -= K;

            double dx = x2 - x1;
            double dy = y2 - y1;

            // Коефіцієнти рівняння для x^2/a^2 - y^2/b^2 = 1
            // У параметричному вигляді x(t) = x1 + t*dx, y(t) = y1 + t*dy
            double A_ = (dx * dx) / (A * A) - (dy * dy) / (B * B);
            double B_ = 2 * ((x1 * dx) / (A * A) - (y1 * dy) / (B * B));
            double C_ = (x1 * x1) / (A * A) - (y1 * y1) / (B * B) - 1;

            List<(double x, double y)> result = new List<(double x, double y)>();
            double D = B_ * B_ - 4 * A_ * C_;
            if (D < 0) return result;

            double sqrtD = Math.Sqrt(D);
            double t1 = (-B_ - sqrtD) / (2 * A_);
            double t2 = (-B_ + sqrtD) / (2 * A_);

            if (t1 >= 0 && t1 <= 1)
            {
                double ix = x1 + t1 * dx + H;
                double iy = y1 + t1 * dy + K;
                result.Add((ix, iy));
            }
            if (t2 >= 0 && t2 <= 1)
            {
                double ix = x1 + t2 * dx + H;
                double iy = y1 + t2 * dy + K;
                result.Add((ix, iy));
            }

            return result;
        }
    }
}
