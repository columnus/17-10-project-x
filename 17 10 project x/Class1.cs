﻿using System;
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
        protected int x, y;
        static Shape()
        {
            c = Color.Black;
            r = 15;
        }
        public Shape(int X, int Y, int R)
        {
            x = X;
            y = Y;
            r = R;

        }

        public abstract bool Isinside(int x, int y);
        public abstract void Draw(PaintEventArgs e);
    }
    class Square : Shape
    {

        public Square(int X, int Y, int R) : base(X, Y,R) { }
        public override void Draw(PaintEventArgs e)
        {
            Brush B = new SolidBrush(c);
            e.Graphics.FillRectangle(B, x, y, x + 2*r, y + 2*r);
        }
        public override bool Isinside(int xM, int yM)
        {
            if (Math.Sqrt(Math.Pow((x - xM), 2)) <= r && Math.Sqrt(Math.Pow((y - yM), 2)) <= r) return true;
            else return false;
            
        }
    }
    class Circle : Shape
    {

        public Circle(int X, int Y, int R) : base(X, Y,R) { }
        public override void Draw(PaintEventArgs e)
        {
            Brush B = new SolidBrush(c);
            e.Graphics.FillEllipse(B, x , x, y, y);
            
        }
        public override bool Isinside(int xM, int yM)
        {
            if (Math.Abs(xM - x) <= r && Math.Abs(yM - y) <= r) return true;
            else return false;
            
        }
    }
    
    class Triangle : Shape
    {
        public Triangle(int X, int Y, int R) : base(X, Y,R) { }
        public override void Draw(PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 3);
            Point point1 = new Point(x, y-r);
            Point point2 = new Point((int)(x - r * Math.Sqrt (3) /2), x+r/2);
            Point point3 = new Point((int)(x + r * Math.Sqrt(3) / 2), x+r/2);
            Point[] curvePoints =
                     {
                 point1,
                 point2,
                 point3
             };
            e.Graphics.DrawPolygon(blackPen, curvePoints);
        }

        
       
        public override bool Isinside(int xM, int yM)
        {
            int y1 = -y;

            if (2 * x + r * Math.Sqrt(3) < y1 && 2 * x + r * Math.Sqrt(3) < x && -2 * x + r * Math.Sqrt(3) < y1 && -2 * x + r * Math.Sqrt(3) > x  && y1 > 0)
            {
                return true;
                
            }
            else return false;
        }
    }
}