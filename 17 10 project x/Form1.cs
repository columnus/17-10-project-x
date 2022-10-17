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

        List<Shape> shapes = new List<Shape> { };
        Circle krug = new Circle(60, 60);
        Square kvad = new Square(120, 120);
        Triangle treg = new Triangle(100, 100);
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            krug.Draw(e);
            kvad.Draw(e);
            treg.Draw(e);
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

        }
        
    }
}
