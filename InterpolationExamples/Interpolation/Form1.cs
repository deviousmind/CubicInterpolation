using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpolation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawImageButton_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(8, 8);
            using (Graphics g = Graphics.FromImage(image))
            {
                drawPrimary(g, 1, 0);
                drawSecondary(g, 1, 1);
                drawPrimary(g, 1, 2);
                drawSecondary(g, 1, 3);
                drawPrimary(g, 1, 4);
                drawSecondary(g, 1, 5);
                drawPrimary(g, 1, 6);
                drawSecondary(g, 1, 7);
            }

            Images.Image = image;
        }
              
        private void BicubicButton_Click(object sender, EventArgs e)
        {
            var original = Images.Image;
            var scale = 10;
            Bitmap newimg = new Bitmap(original.Width * scale, original.Height * scale);

            using(Graphics g = Graphics.FromImage(newimg))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
                g.DrawImage(original, new Rectangle(Point.Empty, newimg.Size));
            }

            Images.Image = newimg;
        }

        private void UpscaleButton_Click(object sender, EventArgs e)
        {
            var original = Images.Image;
            var scale = 10;
            Bitmap newimg = new Bitmap(original.Width * scale, original.Height * scale);

            using (Graphics g = Graphics.FromImage(newimg))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(original, new Rectangle(Point.Empty, newimg.Size));
            }

            Images.Image = newimg;
        }

        private void drawPrimary(Graphics g, int scale, int row)
        {
            g.FillRectangle(Brushes.DeepSkyBlue, 0 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.LawnGreen, scale, scale * row, scale, scale);
            g.FillRectangle(Brushes.DeepSkyBlue, 2 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.LawnGreen, 3 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.DeepSkyBlue, 4 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.LawnGreen, 5 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.DeepSkyBlue, 6 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.LawnGreen, 7 * scale, row * scale, scale, scale);
        }

        private void drawSecondary(Graphics g, int scale, int row)
        {
            g.FillRectangle(Brushes.MediumVioletRed, 0 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.Gold, scale, scale * row, scale, scale);
            g.FillRectangle(Brushes.MediumVioletRed, 2 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.Gold, 3 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.MediumVioletRed, 4 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.Gold, 5 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.MediumVioletRed, 6 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.Gold, 7 * scale, row * scale, scale, scale);
        }

    }
}
