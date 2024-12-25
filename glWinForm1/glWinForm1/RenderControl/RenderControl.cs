using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace glWinForm1
{
    public partial class RenderControl : OpenGL
    {
      
        public RenderControl()
        {
           InitializeComponent();
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
            glViewport(0, 0, Width, Height);
            
            // Налаштовуємо 2D проєкцію (лівий, правий, нижній, верхній)
            gluOrtho2D(-3, 10, -4, 4);

            Grid grid = new Grid();
            grid.DrawGrid();

            Figure13 figure = new Figure13();
            figure.Shape();
            figure.Points();
        }
    }
}