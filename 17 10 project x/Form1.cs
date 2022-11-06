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

        List<Shape> circles = new List<Shape> { };
        List<Shape> squares = new List<Shape> { };
        List<Shape> triangles = new List<Shape> { };
        string flag = "";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Refresh();
            //if (treg.Isinside(MousePosition.X, MousePosition.Y) == true) tb.Text = "ТОЧКА ПОПАЛА В ТРЕУГОЛЬНИК";

        }

        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (flag == "круг")
            {
                circles.Add (new Circle(MousePosition.X, MousePosition.Y, 20));
                for (int i = 0; i < circles.Count; i++)  circles[i].Draw(e);
            }
            else if (flag == "квадрат")
            {
                squares.Add(new Square(MousePosition.X, MousePosition.Y, 20));
                for (int i = 0; i < squares.Count; i++) squares[i].Draw(e);
            }
            else if (flag == "треугольник")
            {
                triangles.Add(new Triangle(MousePosition.X, MousePosition.Y, 20));
                for (int i = 0; i < triangles.Count; i++) triangles[i].Draw(e);
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
            else flag = "не выбрано";
        }

        private void toolStripMenuItem4_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItem4.Checked == true)
            {
                toolStripMenuItem3.Checked = false;
                toolStripMenuItem5.Checked = false;
                flag = "квадрат";
            }
            else flag = "не выбрано";
        }

        private void toolStripMenuItem5_CheckedChanged(object sender, EventArgs e)
        {
            if (toolStripMenuItem5.Checked == true)
            {
                toolStripMenuItem3.Checked = false;
                toolStripMenuItem4.Checked = false;
                flag = "треугольник";
            }
            else flag = "не выбрано";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
