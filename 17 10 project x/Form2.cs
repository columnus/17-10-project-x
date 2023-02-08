using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _17_10_project_x
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        public event RadiusDelegate RadiusChanged;
        public delegate void RadiusDelegate(object sender, RadiusEventArgs e);
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0)
            RadiusChanged(sender, new RadiusEventArgs(trackBar1.Value*2+30 ));
        }
    }
}
