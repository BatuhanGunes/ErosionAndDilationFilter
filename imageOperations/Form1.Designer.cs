namespace imageOperations
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.labelResolution = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.numericTreshold2 = new System.Windows.Forms.NumericUpDown();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonBitmap = new System.Windows.Forms.Button();
            this.buttonGrayScale = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonPikselNeg = new System.Windows.Forms.Button();
            this.buttonPikselPos = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonStandartDefination = new System.Windows.Forms.Button();
            this.buttonGradient = new System.Windows.Forms.Button();
            this.buttonLaplacian = new System.Windows.Forms.Button();
            this.buttonConvulation = new System.Windows.Forms.Button();
            this.buttonSymmetry = new System.Windows.Forms.Button();
            this.buttonErosion = new System.Windows.Forms.Button();
            this.buttonOpening = new System.Windows.Forms.Button();
            this.buttonClosing = new System.Windows.Forms.Button();
            this.buttonDilation = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTreshold2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftPanel.Controls.Add(this.labelResolution);
            this.leftPanel.Controls.Add(this.label10);
            this.leftPanel.Controls.Add(this.pictureBox);
            this.leftPanel.Location = new System.Drawing.Point(12, 12);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(1104, 744);
            this.leftPanel.TabIndex = 0;
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(73, 10);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(32, 13);
            this.labelResolution.TabIndex = 2;
            this.labelResolution.Text = "0 X 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Resolution :";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 500);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxFileName);
            this.panel1.Controls.Add(this.buttonUploadImage);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(1122, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 125);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(0, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "File Location :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Enabled = false;
            this.textBoxFileName.Location = new System.Drawing.Point(3, 73);
            this.textBoxFileName.Multiline = true;
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(222, 41);
            this.textBoxFileName.TabIndex = 2;
            this.textBoxFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.Location = new System.Drawing.Point(43, 29);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(138, 23);
            this.buttonUploadImage.TabIndex = 1;
            this.buttonUploadImage.Text = "Upload Image";
            this.buttonUploadImage.UseVisualStyleBackColor = true;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Image Upload Operations";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.numericTreshold2);
            this.panel2.Controls.Add(this.buttonReset);
            this.panel2.Controls.Add(this.buttonBitmap);
            this.panel2.Controls.Add(this.buttonGrayScale);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(1122, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 153);
            this.panel2.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(24, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "Treshold :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericTreshold2
            // 
            this.numericTreshold2.Location = new System.Drawing.Point(112, 59);
            this.numericTreshold2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericTreshold2.Name = "numericTreshold2";
            this.numericTreshold2.Size = new System.Drawing.Size(85, 20);
            this.numericTreshold2.TabIndex = 20;
            this.numericTreshold2.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(13, 115);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(200, 24);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonBitmap
            // 
            this.buttonBitmap.Location = new System.Drawing.Point(13, 85);
            this.buttonBitmap.Name = "buttonBitmap";
            this.buttonBitmap.Size = new System.Drawing.Size(200, 24);
            this.buttonBitmap.TabIndex = 12;
            this.buttonBitmap.Text = "Bitmap";
            this.buttonBitmap.UseVisualStyleBackColor = true;
            this.buttonBitmap.Click += new System.EventHandler(this.buttonBitmap_Click);
            // 
            // buttonGrayScale
            // 
            this.buttonGrayScale.Location = new System.Drawing.Point(13, 29);
            this.buttonGrayScale.Name = "buttonGrayScale";
            this.buttonGrayScale.Size = new System.Drawing.Size(200, 24);
            this.buttonGrayScale.TabIndex = 11;
            this.buttonGrayScale.Text = "Gray Scale";
            this.buttonGrayScale.UseVisualStyleBackColor = true;
            this.buttonGrayScale.Click += new System.EventHandler(this.buttonGrayScale_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(222, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Gray Scale/Bitmap Operations";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBox7);
            this.panel3.Controls.Add(this.buttonExit);
            this.panel3.Location = new System.Drawing.Point(1122, 685);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 71);
            this.panel3.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(3, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(222, 20);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "Information";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(13, 35);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(199, 24);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.buttonPikselNeg);
            this.panel4.Controls.Add(this.buttonPikselPos);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Location = new System.Drawing.Point(1122, 302);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 66);
            this.panel4.TabIndex = 4;
            // 
            // buttonPikselNeg
            // 
            this.buttonPikselNeg.Location = new System.Drawing.Point(115, 29);
            this.buttonPikselNeg.Name = "buttonPikselNeg";
            this.buttonPikselNeg.Size = new System.Drawing.Size(95, 24);
            this.buttonPikselNeg.TabIndex = 23;
            this.buttonPikselNeg.Text = "Set Piksel -";
            this.buttonPikselNeg.UseVisualStyleBackColor = true;
            this.buttonPikselNeg.Click += new System.EventHandler(this.buttonPikselNeg_Click);
            // 
            // buttonPikselPos
            // 
            this.buttonPikselPos.Location = new System.Drawing.Point(14, 29);
            this.buttonPikselPos.Name = "buttonPikselPos";
            this.buttonPikselPos.Size = new System.Drawing.Size(95, 24);
            this.buttonPikselPos.TabIndex = 22;
            this.buttonPikselPos.Text = "Set Piksel +";
            this.buttonPikselPos.UseVisualStyleBackColor = true;
            this.buttonPikselPos.Click += new System.EventHandler(this.buttonPikselPos_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(222, 20);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "Brightness Operations";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.buttonStandartDefination);
            this.panel5.Controls.Add(this.buttonGradient);
            this.panel5.Controls.Add(this.buttonLaplacian);
            this.panel5.Controls.Add(this.buttonConvulation);
            this.panel5.Controls.Add(this.buttonSymmetry);
            this.panel5.Controls.Add(this.buttonErosion);
            this.panel5.Controls.Add(this.buttonOpening);
            this.panel5.Controls.Add(this.buttonClosing);
            this.panel5.Controls.Add(this.buttonDilation);
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Location = new System.Drawing.Point(1122, 374);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(232, 305);
            this.panel5.TabIndex = 5;
            // 
            // buttonStandartDefination
            // 
            this.buttonStandartDefination.Location = new System.Drawing.Point(14, 269);
            this.buttonStandartDefination.Name = "buttonStandartDefination";
            this.buttonStandartDefination.Size = new System.Drawing.Size(200, 24);
            this.buttonStandartDefination.TabIndex = 31;
            this.buttonStandartDefination.Text = "Standart Defination";
            this.buttonStandartDefination.UseVisualStyleBackColor = true;
            this.buttonStandartDefination.Click += new System.EventHandler(this.buttonStandartDefination_Click);
            // 
            // buttonGradient
            // 
            this.buttonGradient.Location = new System.Drawing.Point(14, 239);
            this.buttonGradient.Name = "buttonGradient";
            this.buttonGradient.Size = new System.Drawing.Size(200, 24);
            this.buttonGradient.TabIndex = 30;
            this.buttonGradient.Text = "Gradient";
            this.buttonGradient.UseVisualStyleBackColor = true;
            this.buttonGradient.Click += new System.EventHandler(this.buttonGradient_Click);
            // 
            // buttonLaplacian
            // 
            this.buttonLaplacian.Location = new System.Drawing.Point(13, 179);
            this.buttonLaplacian.Name = "buttonLaplacian";
            this.buttonLaplacian.Size = new System.Drawing.Size(200, 24);
            this.buttonLaplacian.TabIndex = 29;
            this.buttonLaplacian.Text = "Laplacian";
            this.buttonLaplacian.UseVisualStyleBackColor = true;
            this.buttonLaplacian.Click += new System.EventHandler(this.buttonLaplacian_Click);
            // 
            // buttonConvulation
            // 
            this.buttonConvulation.Location = new System.Drawing.Point(14, 149);
            this.buttonConvulation.Name = "buttonConvulation";
            this.buttonConvulation.Size = new System.Drawing.Size(200, 24);
            this.buttonConvulation.TabIndex = 28;
            this.buttonConvulation.Text = "Convulation";
            this.buttonConvulation.UseVisualStyleBackColor = true;
            this.buttonConvulation.Click += new System.EventHandler(this.buttonConvulation_Click);
            // 
            // buttonSymmetry
            // 
            this.buttonSymmetry.Location = new System.Drawing.Point(14, 209);
            this.buttonSymmetry.Name = "buttonSymmetry";
            this.buttonSymmetry.Size = new System.Drawing.Size(200, 24);
            this.buttonSymmetry.TabIndex = 27;
            this.buttonSymmetry.Text = "Inverse Symmetry";
            this.buttonSymmetry.UseVisualStyleBackColor = true;
            this.buttonSymmetry.Click += new System.EventHandler(this.buttonSymmetry_Click);
            // 
            // buttonErosion
            // 
            this.buttonErosion.Location = new System.Drawing.Point(14, 29);
            this.buttonErosion.Name = "buttonErosion";
            this.buttonErosion.Size = new System.Drawing.Size(200, 24);
            this.buttonErosion.TabIndex = 26;
            this.buttonErosion.Text = "Erosion";
            this.buttonErosion.UseVisualStyleBackColor = true;
            this.buttonErosion.Click += new System.EventHandler(this.buttonErosion_Click);
            // 
            // buttonOpening
            // 
            this.buttonOpening.Location = new System.Drawing.Point(14, 89);
            this.buttonOpening.Name = "buttonOpening";
            this.buttonOpening.Size = new System.Drawing.Size(200, 24);
            this.buttonOpening.TabIndex = 24;
            this.buttonOpening.Text = "Opening";
            this.buttonOpening.UseVisualStyleBackColor = true;
            this.buttonOpening.Click += new System.EventHandler(this.buttonOpening_Click);
            // 
            // buttonClosing
            // 
            this.buttonClosing.Location = new System.Drawing.Point(14, 119);
            this.buttonClosing.Name = "buttonClosing";
            this.buttonClosing.Size = new System.Drawing.Size(200, 24);
            this.buttonClosing.TabIndex = 23;
            this.buttonClosing.Text = "Closing";
            this.buttonClosing.UseVisualStyleBackColor = true;
            this.buttonClosing.Click += new System.EventHandler(this.buttonClosing_Click);
            // 
            // buttonDilation
            // 
            this.buttonDilation.Location = new System.Drawing.Point(14, 59);
            this.buttonDilation.Name = "buttonDilation";
            this.buttonDilation.Size = new System.Drawing.Size(200, 24);
            this.buttonDilation.TabIndex = 22;
            this.buttonDilation.Text = "Dilation";
            this.buttonDilation.UseVisualStyleBackColor = true;
            this.buttonDilation.Click += new System.EventHandler(this.buttonDilation_Click);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(222, 20);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Filter Operations";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTreshold2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonBitmap;
        private System.Windows.Forms.Button buttonGrayScale;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericTreshold2;
        private System.Windows.Forms.Button buttonPikselPos;
        private System.Windows.Forms.Button buttonPikselNeg;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonSymmetry;
        private System.Windows.Forms.Button buttonErosion;
        private System.Windows.Forms.Button buttonOpening;
        private System.Windows.Forms.Button buttonClosing;
        private System.Windows.Forms.Button buttonDilation;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonConvulation;
        private System.Windows.Forms.Button buttonLaplacian;
        private System.Windows.Forms.Button buttonStandartDefination;
        private System.Windows.Forms.Button buttonGradient;
    }
}

