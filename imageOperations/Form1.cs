using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageOperations
{
    public partial class Form1 : Form
    {

        Bitmap bmp = new Bitmap(800, 500);
        Boolean flagBitmap = false;
        Boolean flagGrayScale = false;
        Boolean flagUploadImage = false;

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
                flagUploadImage = true;
                this.Refresh();
            }
            catch
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                flagUploadImage = false;
            }
        }

        void grayScale()
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
            flagGrayScale = true;
            flagBitmap = false;
            pictureBox.Image = bmp;
        }

        private void buttonGrayScale_Click(object sender, EventArgs e)
        {
            if (flagUploadImage == true)
            {
                using (WaitForm frm = new WaitForm(grayScale))
                {
                    frm.ShowDialog(this);
                }

                this.Refresh();
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void bitmap()
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
            flagGrayScale = false;
            pictureBox.Image = bmp;
        }

        private void buttonBitmap_Click(object sender, EventArgs e)
        {
            if (flagUploadImage == true)
            {
                using (WaitForm frm = new WaitForm(bitmap))
                {
                    frm.ShowDialog(this);
                }
                this.Refresh();
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void reset()
        {
            bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);
            pictureBox.Image = bmp;
            flagGrayScale = false;
            flagBitmap = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (flagUploadImage == true)
            {
                using (WaitForm frm = new WaitForm(reset))
                {
                    frm.ShowDialog(this);
                }

                this.Refresh();
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void pikselPos()
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
        }

        private void buttonPikselPos_Click(object sender, EventArgs e)
        {
            if (flagUploadImage == true)
            {
                using (WaitForm frm = new WaitForm(pikselPos))
                {
                    frm.ShowDialog(this);
                }

                this.Refresh();
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void pikselNeg()
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
        }

        private void buttonPikselNeg_Click(object sender, EventArgs e)
        {
            if (flagUploadImage == true)
            {
                using (WaitForm frm = new WaitForm(pikselNeg))
                {
                    frm.ShowDialog(this);
                }

                this.Refresh();
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (flagUploadImage == true)
            {
                if (flagBitmap == false)
                {
                    MessageBox.Show("Please click the bitmap button first");
                }
                else
                {
                    using (WaitForm frm = new WaitForm(erosion))
                    {
                        frm.ShowDialog(this);
                    }
                    pictureBox.Image = bmp;
                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDilation_Click(object sender, EventArgs e)
        {
            if (flagUploadImage == true)
            {
                if (flagBitmap == false)
                {
                    MessageBox.Show("Please click the bitmap button first");
                }
                else
                {
                    using (WaitForm frm = new WaitForm(dilation))
                    {
                        frm.ShowDialog(this);
                    }
                    pictureBox.Image = bmp;
                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void opening()
        {
            erosion();
            dilation();
            pictureBox.Image = bmp;
        }

        private void buttonOpening_Click(object sender, EventArgs e)
        {
            if (flagUploadImage == true)
            {
                if (flagBitmap == false)
                {
                    MessageBox.Show("Please click the bitmap button first");
                }
                else
                {
                    using (WaitForm frm = new WaitForm(opening))
                    {
                        frm.ShowDialog(this);
                    }

                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void closing()
        {
            dilation();
            erosion();
            pictureBox.Image = bmp;
        }

        private void buttonClosing_Click(object sender, EventArgs e)
        {
            if (flagUploadImage == true)
            {
                if (flagBitmap == false)
                {
                    MessageBox.Show("Please click the bitmap button first");
                }
                else
                {
                    using (WaitForm frm = new WaitForm(closing))
                    {
                        frm.ShowDialog(this);
                    }

                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void symetry()
        {
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width / 2; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    Color tmp = bmp.GetPixel(bmp.Width - x - 1, y);
                    bmp.SetPixel(x, y, tmp);
                    bmp.SetPixel(bmp.Width - x - 1, y, c);
                }
            }
            pictureBox.Image = bmp;
        }

        private void buttonSymmetry_Click(object sender, EventArgs e)
        {
            if (flagUploadImage == true)
            {
                using (WaitForm frm = new WaitForm(symetry))
                {
                    frm.ShowDialog(this);
                }

                this.Refresh();
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (flagUploadImage == true)
            {
                if (flagBitmap == false)
                {
                    MessageBox.Show("Please click the bitmap button first");
                }
                else
                {
                    int[,] convulationMatris = { { -1, -1, -1 }, { -1, 8, -1 }, { -1, -1, -1 } };

                    //Since the object in the 'Using' function could not get the parameter value and 
                    //a 'Void' value was required, another method that returned a 'Void' value was created and 
                    //the required object was created and directed to the 'Using' function.

                    void routing (){

                        convulationAndLaplacian(convulationMatris);
                    }
                        
                    using (WaitForm frm = new WaitForm(routing))
                    {
                        frm.ShowDialog(this);
                    }

                    pictureBox.Image = bmp;
                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonLaplacian_Click(object sender, EventArgs e)
        {
            if (flagUploadImage == true)
            {
                if (flagBitmap == false)
                {
                    MessageBox.Show("Please click the bitmap button first");
                }
                else
                {
                    int[,] laplacianMatris = { { 1, 1, 1 }, { 1, -8, 1 }, { 1, 1, 1 } };

                    //Since the object in the 'Using' function could not get the parameter value and 
                    //a 'Void' value was required, another method that returned a 'Void' value was created and 
                    //the required object was created and directed to the 'Using' function.

                    void routing()
                    {

                        convulationAndLaplacian(laplacianMatris);
                    }

                    using (WaitForm frm = new WaitForm(routing))
                    {
                        frm.ShowDialog(this);
                    }

                    pictureBox.Image = bmp;
                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void gradient()
        {
            int gradient;
            int[,] bmpMatris = new int[bmp.Height, bmp.Width];
            int[,] gradientMatris = { { 0, 1 }, { 1, 0 } };

            for (int y = 1; y < bmp.Height - 2; y++)
            {
                for (int x = 1; x < bmp.Width - 2; x++)
                {

                    gradient = gradientMatris[0, 0] * bmp.GetPixel(x, y).R +
                               gradientMatris[0, 1] * bmp.GetPixel(x + 1, y).R +
                               gradientMatris[1, 0] * bmp.GetPixel(x, y + 1).R +
                               gradientMatris[1, 1] * bmp.GetPixel(x + 1, y + 1).R;

                    if (gradient > 255) bmpMatris[y, x] = 255;
                    else if (gradient < 0) bmpMatris[y, x] = 0;
                    else bmpMatris[y, x] = gradient;
                }
            }

            for (int x = 1; x < (bmp.Width - 2); x++)
            {
                for (int y = 1; y < (bmp.Height - 2); y++)

                    if (bmpMatris[y, x] == 0)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else bmp.SetPixel(x, y, Color.FromArgb(bmpMatris[y, x], bmpMatris[y, x], bmpMatris[y, x]));
            }
             pictureBox.Image = bmp;
        }

        private void buttonGradient_Click(object sender, EventArgs e)
        {
            if (flagUploadImage == true)
            {
                if (flagGrayScale == false)
                {
                    MessageBox.Show("Please click the Gray Scale button first");
                }
                else
                {
                    using (WaitForm frm = new WaitForm(gradient))
                    {
                        frm.ShowDialog(this);
                    }

                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private double[] average()
        {
            Color cl;
            double value = 0;
            double piksels = 0;
            for (int x = 0; x < bmp.Height; x++)
            {
                for (int y = 0; y < bmp.Width; y++)
                {
                    cl = bmp.GetPixel(y, x);
                    value += cl.R; 
                    piksels++;
                }
            }
            double avarage = Convert.ToDouble(value / piksels);
            double[] values = { avarage, piksels };
            return values;
        }


        private double standardDeviation()
        {
            double avarage = average()[0], piksels = average()[1];
            double value = 0, standartDeviation = 0;
            Color cl;
            double squaresOfDifference = 0;
            for (int x = 0; x < bmp.Height; x++)
            {
                for (int y = 0; y < bmp.Width; y++)
                {
                    cl = bmp.GetPixel(y, x);
                    squaresOfDifference += Math.Pow(Convert.ToDouble(cl.R) - avarage, 2);

                }
            }
            value = avarage / piksels - 1;
            return standartDeviation = Math.Sqrt(avarage);
        }

        void Deviation()
        {
            //standardDeviation();
            int difference = Math.Abs(Convert.ToInt32(average()[0] - standardDeviation()));
            int sum = Math.Abs(Convert.ToInt32(average()[0] + standardDeviation()));

            for (int x = 0; x < bmp.Height; x++)
            {
                for (int y = 0; y < bmp.Width; y++)
                {
                    Color c = bmp.GetPixel(y, x);

                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    if ((r + g + b) / 3 < sum)
                    {
                        if (r <= 225) r += 30;
                        else r = 255;

                        if (g <= 225) g += 30;
                        else g = 255;

                        if (b <= 225) b += 30;
                        else b = 255;
                    }

                    if ((r + g + b) / 3 < difference)
                    {
                        if (r >= 30) r -= 30;
                        else r = 0;

                        if (g >= 30) g -= 30;
                        else g = 0;

                        if (b >= 30) b -= 30;
                        else b = 0;
                    }
                    bmp.SetPixel(y, x, Color.FromArgb(r, g, b));
                }
            }
            pictureBox.Image = bmp;
        }

        private void buttonStandartDefination_Click(object sender, EventArgs e)
        {
            if (flagUploadImage == true)
            {
                if (flagGrayScale == false)
                {
                    MessageBox.Show("Please click the Gray Scale button first");
                }
                else
                {
                    using (WaitForm frm = new WaitForm(Deviation))
                    {
                        frm.ShowDialog(this);
                    }

                    MessageBox.Show("Average = " + Convert.ToInt32(average()[0]).ToString() + "\n" +
                        "Standard Deviation = " + Convert.ToInt32(standardDeviation()).ToString() + "\n" +
                        "Difference (avarange - Deviation) = " + Convert.ToInt32(average()[0] - standardDeviation()) + "\n" +
                        "Sum (avarange + Deviation) = " + Convert.ToInt32(average()[0] + standardDeviation()),
                        "Standart Deviation Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please add a photo", "Image Upload Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }   
}
//  Batuhan Güneş  
//  201513171055