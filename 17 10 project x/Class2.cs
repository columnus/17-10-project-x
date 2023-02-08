using System;
using System.Collections.Generic;
using System.Text;

namespace _17_10_project_x
{
   
    public class RadiusEventArgs
    {
        public int Radius;
        public RadiusEventArgs()
        {
            Radius = 30;
        }
        public RadiusEventArgs(int n)
        {
            Radius = n;
        }
    }
   
}
