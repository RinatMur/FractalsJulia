using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Fractals
{
    public partial class Form1 : Form
    {
        double x0;
        double xn;
        double y0;
        double yn;
        int k;
        Complex c;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawFractal();
        }
        private void startBut_Click(object sender, EventArgs e)
        {
             DrawFractal();
        }

        void DrawFractal()
        {
            if(!TakeParams())
            {
                MessageBox.Show("Неправильные параметры!!!");
                return;
            }    

            int height = 1080;

            double step = (yn - y0) / height;
            int width = (int)((xn - x0) / step);

            Bitmap bmp = new Bitmap(width, height);

            Graphics g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

            double x = x0;
            double y = yn;

            for (int i = 0; i < width; i++)
            {
                y = yn;

                for (int j = 0; j < height; j++)
                {
                    
                    if(IsJuliaSet(new Complex(x,y)))
                    {
                        bmp.SetPixel(i, j, Color.Black);
                    }

                    y -= step;
                }

                x += step;
            }

            pictureBox1.Image = bmp;
            pictureBox1.Refresh();

        }

        bool IsJuliaSet(Complex z)
        {

            int n = 0;

            while (z.Magnitude < 2.0 && n < k)
            {
                z = z * z + c;

                n++;
            }

            if (z.Magnitude <= 1.0)
            {
                return true;
            }

            return false;
        }
        bool TakeParams()
        {
            double cr;
            double ci;

            if (double.TryParse(x0tb.Text, out x0) &&
               double.TryParse(xntb.Text, out xn) &&
               double.TryParse(y0tb.Text, out y0) &&
               double.TryParse(yntb.Text, out yn) &&
               double.TryParse(rctb.Text, out cr) &&
               double.TryParse(ictb.Text, out ci) &&
               int.TryParse(ktb.Text, out k))
            {
                c = new Complex(cr, ci);

                return true;
            }

            return false;
        }


    }
}
