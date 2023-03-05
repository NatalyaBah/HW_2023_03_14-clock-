using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_2023_03_14_clock_
{
    public partial class Form1 : Form
    {
        Graphics g2;
        Pen clockFace;
        Point A;
        Point B;
        Point C;
        Point D;

        static int increment = 5;
        

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            g2 = e.Graphics;
            clockFace = new Pen(Color.Black, 5);
            A = new Point(Size.Width / 2, Size.Height / 2);
            B = new Point((Size.Width / 2) - increment, (Size.Height / 2) - 80 + increment);
            C = new Point((Size.Width / 2) - increment, (Size.Height / 2) - 90 + increment);
            D = new Point((Size.Width / 2) - increment, (Size.Height / 2) - 100 + increment);            
            g2.DrawLine(new Pen(Brushes.Blue, 3), A, B);
            g2.DrawLine(new Pen(Brushes.Blue, 3), A, C);
            g2.DrawLine(new Pen(Brushes.Blue, 3), A, D);
            g2.DrawEllipse(clockFace, Size.Width / 2 - 100, Size.Height / 2 - 100, 200, 200);
            //смогла нарисовать кружок
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();            
            increment -= 5;            
        }

    }
}
