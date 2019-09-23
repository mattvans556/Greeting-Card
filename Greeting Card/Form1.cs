using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greeting_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object PathPen { get; private set; }
        public Pen DrawPen { get; private set; }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen Drawpen = new Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            g.Clear(Color.Black);
            g.DrawRectangle(Drawpen, 30, 30, 100, 200);
            g.FillRectangle(drawBrush, 30, 30, 100, 200);



            //on screen
            g.Clear(Color.Chocolate);
            g.DrawRectangle(DrawRectangle, 0, 0, 100, 100);
            g.FillRectangle(FillRectangle, 0, 0, 100, 100);

            //Frame 1

        }
    }
}
