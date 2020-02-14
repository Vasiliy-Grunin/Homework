using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winForm
{
    public class Class1
    {
        private  static
            string x, y, z;
        public static void setx(string x1, string y1, string z1)
        {
            x = x1;
            y = y1;
            z = z1;
        }
        public static double Volue()
        {
            double height, length, width, volume;
            height = Double.Parse(x);
            length = Double.Parse(z);
            width = Double.Parse(y);
            volume = height * length * width;
            return volume;
        }
        public static double Mass()
        {
            double Mass,volume;
            double densite = 1.2041;
            volume = Volue();
            Mass = volume * densite;
            return Mass;
        }
    
    }
}
