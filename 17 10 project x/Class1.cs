﻿using System;
using System.Drawing;
using System.Windows.Forms;


namespace _17_10_project_x
{
    [Serializable]
    public abstract class Shape
    {
        public static Color c = Color.Black;
        public static int r = 30;
        public int x, y;
        [NonSerialized]
        public bool dragged;
        [NonSerialized]
        public int dx = 0;
        [NonSerialized]
        public int dy = 0;
        [NonSerialized]
        public bool DrawLine = false;
        public Shape()
        {
            c = Color.Black;
            r = 30;
        }
        public Shape(int X, int Y, int R, bool Dragged)
        {
            x = X;
            y = Y;
            r = R;
            dragged = Dragged;
        }
        public Color C
        {
            get { return c; }
            set { c = value; }
        }
        public int R
        {
            get { return r; }
            set { r = value; }
        }
        public abstract bool Isinside(int x, int y);
        public abstract void Draw(PaintEventArgs e);
    }
    [Serializable]
    class Circle : Shape
    {

        public Circle(int X, int Y, int R, bool Dragged) : base(X, Y, R, Dragged) { }
        public override void Draw(PaintEventArgs e)
        {
            Brush B = new SolidBrush(c);
            e.Graphics.FillEllipse(B, x - r, y - r, 2 * r, 2 * r);

        }
        public override bool Isinside(int xM, int yM)
        {
            double l = Math.Sqrt(Math.Pow(xM - x, 2) + Math.Pow(yM - y, 2));
            if (l <= r) return true;
            else return false;

        }
    }
    [Serializable]
    class Square : Shape
    {

        public Square(int X, int Y, int R, bool Dragged) : base(X, Y, R, Dragged) { }
        public override void Draw(PaintEventArgs e)
        {
            Brush B = new SolidBrush(c);
            int d = (int)(r * 2 / Math.Sqrt(2));
            e.Graphics.FillRectangle(B, x - d / 2, y - d / 2, d, d);
        }
        public override bool Isinside(int xM, int yM)
        {
            int d = (int)(r * 2 / Math.Sqrt(2));
            if (Math.Abs(x - xM) <= d / 2 && Math.Abs(y - yM) <= d / 2) return true;
            else return false;
        }
    }
    [Serializable]
    class Triangle : Shape
    {

        public Triangle(int X, int Y, int R, bool Dragged) : base(X, Y, R, Dragged) { }

        public override void Draw(PaintEventArgs e)
        {
            Brush br = new SolidBrush(c);
            Point[] curvePoints = new Point[3];
            curvePoints[0] = new Point(x, y - r);
            curvePoints[1] = new Point(x + (int)(r * Math.Sqrt(3) / 2), y + r / 2);
            curvePoints[2] = new Point(x - (int)(r * Math.Sqrt(3) / 2), y + r / 2);
            e.Graphics.FillPolygon(br, curvePoints);
        }



        public override bool Isinside(int X, int Y)
        {
            Point[] curvePoints = new Point[3];
            curvePoints[0] = new Point(x, y - r);
            curvePoints[1] = new Point(x + (int)(r * Math.Sqrt(3) / 2), y + r / 2);
            curvePoints[2] = new Point(x - (int)(r * Math.Sqrt(3) / 2), y + r / 2);
            if (Y >= y - r && Y <= y + r / 2 && X >= x - (int)(r * (Math.Sqrt(3) / 2)) && X <= x + (int)(r * (Math.Sqrt(3) / 2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
