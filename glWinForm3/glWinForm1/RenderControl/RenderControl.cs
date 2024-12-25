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
        protected MathFunction currentFunction; 

        Function13 function13 = new Function13();
        public double points = 100;
        public bool showY { get; set; } = false;
        public double XMin { get; set; } = -3.0;
        public double XMax { get; set; } = 3.0;
        public double YMin { get; set; } = -3.0;
        public double YMax { get; set; } = 3.0;
        public byte choice { get; set; } = 1;

        private byte functionChoice = 1;

        public RenderControl()
        {
           InitializeComponent();
           InitializeFunction(functionChoice);
        }

        protected void InitializeFunction(byte choice)
        {
            currentFunction = choice switch
            {
                1 => new FirstFunc(),
                2 => new SecondFunc(),
                _ => new FirstFunc()
            };
        }

        public void SetFunction(byte choice)
        {
            functionChoice = choice;
            InitializeFunction(choice);
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClearColor(1, 1, 1, 1);
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
            glViewport(0, 0, Width, Height);

            if (!showY)
                (YMin, YMax) = function13.CalculateY(XMin, XMax, points, YMin, YMax, choice);
            YMax = Math.Min(YMax, 100);
            YMin = Math.Max(YMin, -100);
            gluOrtho2D(XMin, XMax, YMin, YMax);

            Grid(XMin, XMax, YMin, YMax);
            Axis(XMin, XMax, YMin, YMax);
            function13.Graph(XMin, XMax, points, YMin, YMax,  choice);
        }

        public void Grid(double XMin, double XMax, double YMin, double YMax)
        {
            glLineWidth(0.3f);
            glColor3d(0, 0, 0);
            glBegin(GL_LINES);
            for (double i = XMin; i <= XMax; i++)
            {
                glVertex2d(i, YMin);
                glVertex2d(i, YMax);
            }
            for (double i = YMin; i <= YMax; i++)
            {
                glVertex2d(XMin, i);
                glVertex2d(XMax, i);
            }
            glEnd();
        }

        public void Axis(double xMin, double xMax, double yMin, double yMax)
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