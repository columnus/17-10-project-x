using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _17_10_project_x
{
    abstract class Shape
    {
        protected static Color c;
        protected static int r;
        public int x, y;
        public bool dragged;
        static Shape()
        {
            c = Color.Black;
            r = 15;
        }
        public Shape(int X, int Y, int R, bool Dragged)
        {
            x = X;
            y = Y;
            r = R;
            dragged = Dragged;
        }

        public abstract bool Isinside(int x, int y);
        public abstract void Draw(PaintEventArgs e);
    }
    class Square : Shape
    {

        public Square(int X, int Y, int R, bool Dragged) : base(X, Y, R, Dragged) { }
        public override void Draw(PaintEventArgs e)
        {
            Brush B = new SolidBrush(c);
            int d = (int)(r * 2 / Math.Sqrt(2));
            e.Graphics.FillRectangle(B, x - d / 2, y - d, d, d);

        }
        public override bool Isinside(int xM, int yM)
        {
            int d = (int)(r * 2 / Math.Sqrt(2));

            if (Math.Sqrt(Math.Pow((x - xM), 2)) <= r && Math.Sqrt(Math.Pow((y - yM), 2)) <= r) return true;
            else return false;

        }
    }
    class Circle : Shape
    {

        public Circle(int X, int Y, int R, bool Dragged) : base(X, Y, R, Dragged) { }
        public override void Draw(PaintEventArgs e)
        {
            Brush B = new SolidBrush(c);
            e.Graphics.FillEllipse(B, x - r, y - 2 * r, 2 * r, 2 * r);

        }
        public override bool Isinside(int xM, int yM)
        {
            double l = Math.Sqrt(Math.Pow(xM - x, 2) + Math.Pow(yM - y, 2));
            if (l <= r) return true;
            else return false;

        }
    }

    class Triangle : Shape
    {
        public Point[] curvePoints = new Point[3];
        public Triangle(int X, int Y, int R, bool Dragged) : base(X, Y, R, Dragged)
        {
            curvePoints[0] = new Point(x, y - R);
            curvePoints[1] = new Point(x + (int)(R * Math.Sqrt(3) / 2), y + R / 2);
            curvePoints[2] = new Point(x - (int)(R * Math.Sqrt(3) / 2), y + R / 2);
        }
        
        public override void Draw(PaintEventArgs e)
        {
            Brush br = new SolidBrush(Color.Black);
            e.Graphics.FillPolygon(br, curvePoints);

        }



        public override bool Isinside(int X, int Y)
        {
            int a = (curvePoints[0].X - x) * (curvePoints[1].Y - curvePoints[0].Y) - (curvePoints[1].X - curvePoints[0].X) * (curvePoints[0].Y - y);
            int b = (curvePoints[1].X - x) * (curvePoints[2].Y - curvePoints[1].Y) - (curvePoints[2].X - curvePoints[1].X) * (curvePoints[1].Y - y);
            int c = (curvePoints[2].X - x) * (curvePoints[0].Y - curvePoints[2].Y) - (curvePoints[0].X - curvePoints[2].X) * (curvePoints[2].Y - y);
            return (a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0);
        }
    }
}
