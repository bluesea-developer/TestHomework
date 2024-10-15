using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorWindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //BufferedGraphicsContext current = BufferedGraphicsManager.Current; //(1)
            ////BufferedGraphics bg;

            //bg = current.Allocate(this.CreateGraphics(), this.DisplayRectangle); //(2)
            //Graphics g = bg.Graphics;//(3)
            //随机 宽400 高400
            Bitmap bt = new Bitmap(400, 400);
            Graphics bg = Graphics.FromImage(bt);
            System.Random rnd = new Random();
            int x, y, w, h, r, i;
            for (i = 0; i < 10000; i++)
            {
                x = rnd.Next(400);
                y = rnd.Next(400);
                r = rnd.Next(20);
                w = rnd.Next(10);
                h = rnd.Next(10);
                bg.DrawEllipse(Pens.Blue, x, y, w, h);
            }
            this.CreateGraphics().DrawImage(bt, new Point(0, 0));
            //bg.Render();//(4)
            //            //bg.Render(this.CreateGraphics());
            //bg.Dispose();//(5)


            //float w = 20f;
            //float h = 20f;

            //float zoom = 1.0f;

            //RectangleF rect1 = new RectangleF(0, 0, w * zoom, h * zoom);

            //Color c1 = Color.FromArgb(255, 128, 128);
            //Color c2 = Color.FromArgb(255, 255, 128);
            //Color c3 = Color.FromArgb(128, 255, 128);
            //Color c4 = Color.FromArgb(0, 255, 128);
            //Color c5 = Color.FromArgb(128, 255, 255);
            //Color c6 = Color.FromArgb(0, 128, 255);
            //Color c7 = Color.FromArgb(255, 128, 192);
            //Color c8 = Color.FromArgb(255, 128, 255);
            //Color c9 = Color.FromArgb(255, 0, 0);
            //Color c10 = Color.FromArgb(255, 255, 0);

            //List<Color> cList = new List<Color>();

            //cList.Add(c1);
            //cList.Add(c2);
            //cList.Add(c3);
            //cList.Add(c4);
            //cList.Add(c5);
            //cList.Add(c6);
            //cList.Add(c7);
            //cList.Add(c8);
            //cList.Add(c9);
            //cList.Add(c10);

            //Random random = new Random();

            //for (int i = 0; i < 200; i++)
            //{
            //    for (int j = 0; j < 50; j++)
            //    {
            //        RectangleF tempRect = new RectangleF(j * w * zoom, i * h * zoom, w * zoom, h * zoom);

            //        int randomIndex = random.Next(cList.Count);

            //        Color tc1 = cList[randomIndex];

            //        //Thread.Sleep(200);

            //        randomIndex = random.Next(cList.Count);

            //        Color tc2 = cList[randomIndex];


            //        LinearGradientBrush brush = new LinearGradientBrush(
            //        tempRect,
            //        tc1,
            //        tc2,
            //        LinearGradientMode.Horizontal);

            //        e.Graphics.FillRectangle(brush, tempRect);
            //    }
            //}





            //base.OnPaint(e);


        }
    }
}
