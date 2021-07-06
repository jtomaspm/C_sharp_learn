using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLearn
{
    public partial class FormWindow : Form
    {
        public Graphics G { get; set; }
        public FormWindow()
        {
            InitializeComponent();
        }

        private void FormWindow_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("PAINT");
            G = e.Graphics;

           

        }

        private void FormWindow_Load(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Black, 30);
            Size s = new Size(100, 100);
            Point[] glande = { new Point(250, 500),  new Point(300, 580), new Point(350, 500) };
            Console.WriteLine("LOAD");
            this.Paint += (sendr, eArg) =>
            {
                G.DrawEllipse(p, new Rectangle(new Point(200, 200), s));
                G.DrawEllipse(p, new Rectangle(new Point(300, 200), s));
                G.DrawRectangle(p, new Rectangle(new Point(250,300), new Size(100, 200)));
                G.DrawCurve(p, glande, 1.4969F);
            };
            this.Visible = true;
            this.SetDesktopLocation(200,200);
            this.Activate();
            
        }

        private Bitmap ToBitMap(Graphics g)
        {
            return new Bitmap(800, 600, g);
        }
    }
}
