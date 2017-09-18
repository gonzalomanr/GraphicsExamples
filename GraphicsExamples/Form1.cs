using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExamples
{
    public partial class RamsLogo : Form
    {
        public RamsLogo()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Blue, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Green);


            //Change color
            drawPen.Color = Color.Red;
            drawBrush.Color = Color.Lime;

            formGraphics.Clear(Color.Gray);


            //drawPen.Color = Color.FromArgb(150, 150, 0, 0);
            // drawBrush.Color = Color.FromArgb(160, 255, 0, 0);

            //Rectangle code
            drawBrush.Color = Color.LightBlue;
            formGraphics.FillRectangle(drawBrush, 40, 35, 200, 200);
            drawPen.Color = Color.White;
            formGraphics.DrawRectangle(drawPen, 40, 35, 200, 200);

            //Ellipse code
            drawBrush.Color = Color.Blue;
            formGraphics.FillEllipse(drawBrush, 72, 67, 135, 135);
            drawPen.Color = Color.LightGray;
            formGraphics.DrawEllipse(drawPen, 72, 67, 135, 135);

           

            //Font
            drawBrush.Color = Color.Black;
            //Graphics fg = this.CreateGraphics();
            Font drawFont = new Font("Palatino Linotype", 20, FontStyle.Regular);

            drawBrush.Color = Color.Blue;

            //"R" code
            formGraphics.TranslateTransform(65, 65);
            formGraphics.RotateTransform(320);
            formGraphics.DrawString("R", drawFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();

            //"A" code
            formGraphics.TranslateTransform(190, 45);
            formGraphics.RotateTransform(40);
            formGraphics.DrawString("A", drawFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();

            //"M" code
            formGraphics.TranslateTransform(220, 202);
            formGraphics.RotateTransform(140);
            formGraphics.DrawString("M", drawFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();

            //"S" code
            Font sFont = new Font("Palatino Linotype", 22, FontStyle.Regular);
            formGraphics.TranslateTransform(80, 220);
            formGraphics.RotateTransform(225);
            formGraphics.DrawString("S", sFont, drawBrush, new Rectangle());
            formGraphics.ResetTransform();

            //Big "C" Shadow code
            drawBrush.Color = Color.Black;
            Font cShadowFont = new Font("Linux Biolinum G", 110, FontStyle.Regular);
            formGraphics.DrawString("C", cShadowFont, drawBrush, 59, 52);

            //Big "C" code
            drawBrush.Color = Color.LightGray;
            Font cFont = new Font("Linux Biolinum G", 110, FontStyle.Regular);
            formGraphics.DrawString("C", cFont, drawBrush, 57, 50);

        }

    }
}
