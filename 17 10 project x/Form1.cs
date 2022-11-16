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
    public partial class Form1 : Form
    {

        List<Shape> figures = new List<Shape> { };
        string flag = "";
        bool IfIsInside = false;
        int dx;
        int dy;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Refresh();
            if (e.Button == MouseButtons.Right)
            {
                IfIsInside = true;
                for (int j = 0; j < figures.Count; j++)
                {
                    if (figures[j].Isinside(MousePosition.X, MousePosition.Y))
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
                    if (figures[j].Isinside(MousePosition.X, MousePosition.Y))
                    {
                        IfIsInside = true;
                        figures[j].dragged = true;
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

            if (flag == "круг"&& !IfIsInside)
            {
                figures.Add (new Circle(MousePosition.X, MousePosition.Y, 20, false));
                
            }
            else if (flag == "квадрат" && !IfIsInside)
            {
                figures.Add(new Square(MousePosition.X, MousePosition.Y, 20, false));
                
            }
            else if (flag == "треугольник" && !IfIsInside)
            {
                figures.Add(new Triangle(MousePosition.X, MousePosition.Y, 20, false));
                
            }
            
            
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < figures.Count; i++)
            {
                if (figures[i].dragged == true)
                {
                    figures[i].x = MousePosition.X;
                    figures[i].y = MousePosition.Y;
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Refresh();
            for (int i = 0; i < figures.Count; i++) figures[i].dragged = false;

        }

       
    }
}
