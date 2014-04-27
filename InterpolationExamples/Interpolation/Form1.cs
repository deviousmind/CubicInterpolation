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
        private bool ExampleChanged { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawImageButton_Click(object sender, EventArgs e)
        {
            if(!ExampleChanged)
            {
                DrawFirstExample();               
            }
            else
            {
                DrawSecondExample();
            }
        }
              
        private void BicubicButton_Click(object sender, EventArgs e)
        {
            if(!ExampleChanged)
            {
                RedrawFirstExample();
            }
            else
            {
                RedrawSecondExample();
            }
           
        }
        
        private void UpscaleButton_Click(object sender, EventArgs e)
        {
            var original = Images.Image;
            var scale = 2;
            Bitmap newimg = new Bitmap(original.Width * scale, original.Height * scale);

            using (Graphics g = Graphics.FromImage(newimg))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.DrawImage(original, new Rectangle(Point.Empty, newimg.Size));
            }

            Images.Image = newimg;
        }
        
        private void RotateButton_Click(object sender, EventArgs e)
        {
            var image = Images.Image;
            var offset = new PointF(100, 100);
            var angle = 15;

            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);
            rotatedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(offset.X, offset.Y);
                g.RotateTransform(angle);
                g.TranslateTransform(-offset.X, -offset.Y);
                g.DrawImage(image, new PointF(0, 0));
            }

            Images.Image = rotatedImage;

        }
        
        private void SwitchExample_Click(object sender, EventArgs e)
        {
            if(!ExampleChanged)
            {
                SwitchExample.Text = "Example 1";
            }
            else
            {
                SwitchExample.Text = "Example 2";
            }
            ExampleChanged = !ExampleChanged;
            UpscaleButton.Visible = !ExampleChanged;
            RotateButton.Visible = ExampleChanged;
        }

        private void DrawPrimary(Graphics g, int scale, int row)
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

        private void DrawSecondary(Graphics g, int scale, int row)
        {
            g.FillRectangle(Brushes.LawnGreen, 0 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.Gold, scale, scale * row, scale, scale);
            g.FillRectangle(Brushes.LawnGreen, 2 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.Gold, 3 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.LawnGreen, 4 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.Gold, 5 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.LawnGreen, 6 * scale, row * scale, scale, scale);
            g.FillRectangle(Brushes.Gold, 7 * scale, row * scale, scale, scale);
        }

        private void DrawFirstExample()
        {
            Bitmap image = new Bitmap(8, 8);
            using (Graphics g = Graphics.FromImage(image))
            {
                DrawPrimary(g, 1, 0);
                DrawSecondary(g, 1, 1);
                DrawPrimary(g, 1, 2);
                DrawSecondary(g, 1, 3);
                DrawPrimary(g, 1, 4);
                DrawSecondary(g, 1, 5);
                DrawPrimary(g, 1, 6);
                DrawSecondary(g, 1, 7);
            }

            Images.Image = image;
        }

        private void DrawSecondExample()
        {
            Bitmap image = new Bitmap(200, 400);
                using (Graphics g = Graphics.FromImage(image))
                {
                    var pen = new Pen(Brushes.Black, 2f);
                    var rectangle = new Rectangle(100, 100, 50, 80);
                    g.DrawRectangle(pen, rectangle);
                }

                Images.Image = image;
        }
        
        private void RedrawFirstExample()
        {
            var original = Images.Image;
            var scale = 2;
            Bitmap newimg = new Bitmap(original.Width * scale, original.Height * scale);

            using (Graphics g = Graphics.FromImage(newimg))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
                g.DrawImage(original, new Rectangle(Point.Empty, newimg.Size));
            }

            Images.Image = newimg;
        }

        private void RedrawSecondExample()
        {
            var image = Images.Image;
            var offset = new PointF(100, 100);
            var angle = 15;

            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);
            rotatedImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bicubic;
                g.TranslateTransform(offset.X, offset.Y);
                g.RotateTransform(angle);
                g.TranslateTransform(-offset.X, -offset.Y);
                g.DrawImage(image, new PointF(0, 0));
            }

            Images.Image = rotatedImage;
        }
    }
}
