using System;
using System.Windows.Forms;

namespace _17_10_project_x
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            trackBar1.Value = 30;
        }
        public Form2(int position)
        {
            InitializeComponent();
            trackBar1.Value = position;
        }

        public delegate void RadiusDelegate(object sender, RadiusEventArgs e);
        public event RadiusDelegate RadiusChanged;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0)
                RadiusChanged(sender, new RadiusEventArgs(trackBar1.Value));

        }


    }
}
