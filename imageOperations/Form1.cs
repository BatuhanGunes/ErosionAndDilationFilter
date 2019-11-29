using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageOperations
{
    public partial class Form1 : Form
    {

        Bitmap bmp = new Bitmap(800, 500);
        Boolean flagBitmap = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    //TurnOff Aplication
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                pictureBox.ImageLocation = openFileDialog1.FileName;
                bmp = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
                textBoxFileName.Text = openFileDialog1.FileName;
                labelResolution.Text = pictureBox.Height.ToString() + " X " + pictureBox.Width.ToString();

                this.Refresh();
            }
            catch
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }


        private void buttonGrayScale_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                // bmp refresh
                bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);

                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);

                        int r = c.R;
                        int g = c.G;
                        int b = c.B;
                        int avg = (r + g + b) / 3;
                        bmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                    }
                }
                pictureBox.Image = bmp;
                this.Refresh();
            }
        }

        private void buttonBitmap_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                // bmp refresh
                bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);
                int treshold = Convert.ToInt32(numericTreshold2.Text);
                

                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);

                        int r = c.R;
                        int g = c.G;
                        int b = c.B;
                        int avg = (r + g + b) / 3;

                        if (avg >= treshold)
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }
                        else
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        }
                    }
                }
                flagBitmap = true;
                pictureBox.Image = bmp;
                this.Refresh();
            }       
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);
                pictureBox.Image = bmp;
                this.Refresh();
            }
        }

        private void buttonPikselPos_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);

                        int r = c.R;
                        int g = c.G;
                        int b = c.B;

                        if (r <= 225) r += 30;
                        else r = 255;

                        if (g <= 225) g += 30;
                        else g = 255;

                        if (b <= 225) b += 30;
                        else b = 255;

                        bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }
                pictureBox.Image = bmp;
                this.Refresh();
            }
        }

        private void buttonPikselNeg_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);

                        int r = c.R;
                        int g = c.G;
                        int b = c.B;

                        if (r >= 30) r -= 30;
                        else r = 0;

                        if (g >= 30) g -= 30;
                        else g = 0;

                        if (b >= 30) b -= 30;
                        else b = 0;
                                        
                        bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                    }
                }
                pictureBox.Image = bmp;
                this.Refresh();
            }
        }
        
        private void erosion()
        {
            int[,] bmpMatris = new int[bmp.Height, bmp.Width];
            int b1, b2, b3, b4;
            Color c;

            for (int y = 1; y < bmp.Height - 1; y++)
            {
                for (int x = 1; x < bmp.Width - 1; x++)
                {
                    c = bmp.GetPixel(x, y);
                    c = bmp.GetPixel(x - 1, y);
                    b1 = c.R;
                    c = bmp.GetPixel(x + 1, y);
                    b2 = c.R;
                    c = bmp.GetPixel(x, y - 1);
                    b3 = c.R;
                    c = bmp.GetPixel(x, y + 1);
                    b4 = c.R;

                    if (b1 == 255 && b2 == 255 && b3 == 255 && b4 == 255)
                    {
                        bmpMatris[y, x] = 255;
                    }

                    else
                    {
                        bmpMatris[y, x] = 0;
                    }
                }
            }

            for (int y = 1; y < bmp.Height - 1; y++)
            {
                for (int x = 1; x < bmp.Width - 1; x++)
                {
                    if (bmpMatris[y, x] == 255)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                }
            }
        }

        private void dilation()
        {
            int[,] bmpMatris = new int[bmp.Height, bmp.Width];
            int b1, b2, b3, b4;
            Color c;

            for (int y = 1; y < bmp.Height - 1; y++)
            {
                for (int x = 1; x < bmp.Width - 1; x++)
                {
                    c = bmp.GetPixel(x, y);
                    c = bmp.GetPixel(x - 1, y);
                    b1 = c.R;
                    c = bmp.GetPixel(x + 1, y);
                    b2 = c.R;
                    c = bmp.GetPixel(x, y - 1);
                    b3 = c.R;
                    c = bmp.GetPixel(x, y + 1);
                    b4 = c.R;

                    if (b1 == 255 || b2 == 255 || b3 == 255 || b4 == 255)
                    {
                        bmpMatris[y, x] = 255;
                    }

                    else
                    {
                        bmpMatris[y, x] = 0;
                    }
                }
            }

            for (int y = 1; y < bmp.Height - 1; y++)
            {
                for (int x = 1; x < bmp.Width - 1; x++)
                {
                    if (bmpMatris[y, x] == 255)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                }
            }
        }

        private void buttonErosion_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                if (flagBitmap == false)
                {
                    MessageBox.Show("Please click the bitmap button first");
                }
                else
                {
                    erosion();
                    pictureBox.Image = bmp;
                    this.Refresh();
                }
            }
        }

        private void buttonDilation_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                if (flagBitmap == false)
                {
                    MessageBox.Show("Please click the bitmap button first");
                }
                else
                {
                    dilation();
                    pictureBox.Image = bmp;
                    this.Refresh();
                }
            }
        }

        private void buttonOpening_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                if (flagBitmap == false)
                {
                    MessageBox.Show("Please click the bitmap button first");
                }
                else
                {
                    erosion();
                    dilation();
                    pictureBox.Image = bmp;
                    this.Refresh();
                }
            }
        }

        private void buttonClosing_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                if (flagBitmap == false)
                {
                    MessageBox.Show("Please click the bitmap button first");
                }
                else
                {
                    dilation();
                    erosion();
                    pictureBox.Image = bmp;
                    this.Refresh();
                }
            }
        }

        private void buttonSymmetry_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width/2; x++)
                    {
                        Color c = bmp.GetPixel(x, y);
                        Color tmp = bmp.GetPixel(bmp.Width - x - 1, y);
                        bmp.SetPixel(x, y, tmp);
                        bmp.SetPixel(bmp.Width - x - 1, y, c);
                    }
                }
                pictureBox.Image = bmp;
                this.Refresh();
            }
        }

        private void convulationAndLaplacian(int[,] filter)
        {
            Color c;
            int convulation;
            int[,] bmpMatris = new int[bmp.Height, bmp.Width];
            
            int b1, b2, b3, b4, b5, b6, b7, b8, b9;

            for (int y = 1; y < bmp.Height - 2; y++)
            {
                for (int x = 1; x < bmp.Width - 2; x++)
                {
                        c = bmp.GetPixel(x - 1, y - 1);
                        b1 = c.R;
                        c = bmp.GetPixel(x, y - 1);
                        b2 = c.R;
                        c = bmp.GetPixel(x + 1, y - 1);
                        b3 = c.R;
                        c = bmp.GetPixel(x - 1, y);
                        b4 = c.R;
                        c = bmp.GetPixel(x + 1, y);
                        b5 = c.R;
                        c = bmp.GetPixel(x, y);
                        b6 = c.R;
                        c = bmp.GetPixel(x - 1, y + 1);
                        b7 = c.R;
                        c = bmp.GetPixel(x, y + 1);
                        b8 = c.R;
                        c = bmp.GetPixel(x + 1, y + 1);
                        b9 = c.R;

                        convulation = filter[0, 0] * b1 + filter[0, 1] * b2 + filter[0, 2] * b3 +
                                           filter[1, 0] * b4 + filter[1, 1] * b5 + filter[1, 2] * b6 +
                                           filter[2, 0] * b7 + filter[2, 1] * b8 + filter[2, 2] * b9;

                        if (convulation > 255) bmpMatris[y, x] = 255;
                        else if (convulation < 0) bmpMatris[y, x] = 0;
                        else bmpMatris[y, x] = convulation;   
                }
            }

            for (int y = 1; y < bmp.Height - 2; y++)
            {
                for (int x = 1; x < bmp.Width - 2; x++)
                {
                    if (bmpMatris[y, x] == 255)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                }
            }
        }

        private void buttonConvulation_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                if (flagBitmap == false)
                {
                    MessageBox.Show("Please click the bitmap button first");
                }
                else
                {
                    int[,] convulationMatris = { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };
                    convulationAndLaplacian(convulationMatris);
                    pictureBox.Image = bmp;
                    this.Refresh();
                }
            }
        }
        
        private void buttonLaplacian_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                if (flagBitmap == false)
                {
                    MessageBox.Show("Please click the bitmap button first");
                }
                else
                {
                    int[,] laplacianMatris = { { 1, 1, 1 }, { 1, -8, 1 }, { 1, 1, 1 } };
                    convulationAndLaplacian(laplacianMatris);
                    pictureBox.Image = bmp;
                    this.Refresh();
                }
            }
        }
    }
}
//  Batuhan Güneş  
//  201513171055