using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace _17_10_project_x
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void DrawGraphics()
        {
            GraphPane pane = zedGraphControl1.GraphPane;
            PointPairList list = new PointPairList();
            pane.Title.Text = "График сравнения";
            pane.XAxis.Title.Text = "Количество вершин";
            pane.YAxis.Title.Text = "Счет";
            pane.CurveList.Clear();

        }
    }
}
