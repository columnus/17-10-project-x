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
    public partial class Form1 : Form
    {
       
        public static double VectorCos(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            int a = x1 - x2;
            int a1 = x3 - x2;
            int b = y1 - y2;
            int b1 = y3 - y2;
            return (a * a1 + b * b1) / ((Math.Sqrt(a * a + b * b) * Math.Sqrt(a1 * a1 + b1 * b1)));
        }
        List<Shape> figures = new List<Shape> { };
        string flag = "";
        bool IfIsInside = false;
        Pen P = new Pen(Color.Red, 5);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Refresh();
            if (toolStripMenuItem3.Checked == true) flag = "круг";
            if (e.Button == MouseButtons.Right)
            {
                IfIsInside = true;
                for (int j = 0; j < figures.Count; j++)
                {
                    if (figures[j].Isinside(e.X, e.Y))
                    {
                        figures.RemoveAt(j);
                        Invalidate();
                    }
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                IfIsInside = false;
                for (int j = 0; j < figures.Count; j++)
                {
                    if (figures[j].Isinside(e.X, e.Y))
                    {
                        IfIsInside = true;
                        figures[j].dragged = true;
                        figures[j].dx = figures[j].x - e.X;
                        figures[j].dy = figures[j].y - e.Y;
                    }
                }
                if (!IfIsInside)
                {
                    if (flag == "круг" && !IfIsInside)
                    {
                        figures.Add(new Circle(e.X, e.Y, 30, false));
                    }
                    else if (flag == "квадрат" && !IfIsInside)
                    {
                        figures.Add(new Square(e.X, e.Y, 30, false));
                    }
                    else if (flag == "треугольник" && !IfIsInside)
                    {
                        figures.Add(new Triangle(e.X, e.Y, 30, false));
                    }
                }


            }
            Refresh();
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < figures.Count; i++)
            {
                figures[i].Draw(e);
            }
            //bool upper;
            //bool lower;
            //double k;
            //double b;
            //for (int i = 0; i < figures.Count; i++)
            //{

            //    for (int j = i + 1; j < figures.Count; j++)
            //    {
            //        upper = false;
            //        lower = false;

            //        if (figures[i].x == figures[j].x)
            //        {
            //            for (int h = 0; h < figures.Count; h++)
            //                if (h!=i && h!=j)
            //                {
            //                    if (figures[h].x > figures[i].x) upper = true;
            //                    else lower = true;
            //                }
            //        }
            //        else
            //        {
            //            k = ((double)figures[j].y - figures[i].y) / ((double)figures[j].x - figures[i].x);
            //            b = figures[i].y - k * figures[i].x;
            //            for (int h = 0; h < figures.Count; h++)
            //            {
            //                if (figures[h] != figures[i] && figures[h] != figures[j])
            //                {
            //                    if (figures[h].y > k * figures[h].x + b)
            //                    {
            //                        upper = true;
            //                    }
            //                    else
            //                    {
            //                        lower = true;
            //                    }

            //                }

            //            }
            //        }
            //        if ((upper == false) || (lower == false))
            //        {
            //                e.Graphics.DrawLine(P, figures[i].x, figures[i].y, figures[j].x, figures[j].y);
            //        }
            //    }
            //}

            //JARVIS 


            

            if (figures.Count > 1)
            {
                int SecondInd = 0;
                for (int i = 0; i < figures.Count; i++)
                {
                    if (figures[i].x > figures[SecondInd].x)
                    {
                        SecondInd = i;
                    }
                }   
                Circle FirstPoint = new Circle(figures[SecondInd].x - 100, figures[SecondInd].y, 30, false);
                int ThirdInd = 2;
                double minCos = 1;
                for (int i = 0; i < figures.Count; i++)
                {
                    for (int j = 0; j < figures.Count; j++)
                    {
                        if (VectorCos(FirstPoint.x, FirstPoint.y,figures[SecondInd].x,figures[SecondInd].y,figures[j].x,figures[j].y) < minCos)
                        {
                            minCos = VectorCos(FirstPoint.x, FirstPoint.y, figures[SecondInd].x, figures[SecondInd].y, figures[j].x, figures[j].y);
                            ThirdInd = j;
                        }

                    }
                    e.Graphics.DrawLine(P, figures[SecondInd].x, figures[SecondInd].y, figures[ThirdInd].x, figures[ThirdInd].y);
                    minCos = 1;
                    FirstPoint.x = figures[SecondInd].x;
                    FirstPoint.y = figures[SecondInd].y;
                    SecondInd = ThirdInd;
                    ThirdInd = 0;
                }
            }
        }

    
        



        private void toolStripMenuItem3_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItem3.Checked == true)
            {
                toolStripMenuItem4.Checked = false;
                toolStripMenuItem5.Checked = false;
                flag = "круг";
            }

        }

        private void toolStripMenuItem4_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItem4.Checked == true)
            {
                toolStripMenuItem3.Checked = false;
                toolStripMenuItem5.Checked = false;
                flag = "квадрат";
            }

        }

        private void toolStripMenuItem5_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItem5.Checked == true)
            {
                toolStripMenuItem3.Checked = false;
                toolStripMenuItem4.Checked = false;
                flag = "треугольник";
            }

        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            bool DoRefresh = false;
            for (int i = 0; i < figures.Count; i++)
            {
                if (figures[i].dragged == true)
                {
                    DoRefresh = true;
                    figures[i].x = e.X;
                    figures[i].y = e.Y;
                    if (figures[i].Isinside(e.X, e.Y) == true)
                    {
                        figures[i].x += figures[i].dx;
                        figures[i].y += figures[i].dy;
                    }
                }
            }
            if (DoRefresh) Refresh();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Refresh();
            for (int i = 0; i < figures.Count; i++)
            {
                figures[i].dragged = false;
            }
        }


        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ans = colorDialog1.ShowDialog();
            if (ans == DialogResult.OK)
            {
                for (int i = 0; i < figures.Count; i++)
                {
                    figures[i].C = colorDialog1.Color;
                }
                Refresh();
                MessageBox.Show("Цвет изменен");
            }
        }
    }
}
