using System;
using System.Collections.Generic;

namespace glWinForm1
{
    public interface IShape2D
    {
        void Draw();
        List<(double x, double y)> GetIntersections(double x1, double y1, double x2, double y2);
    }
}
