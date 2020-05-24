namespace ProgressManagerProject
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.alphaGradientPanel1 = new BlueActivity.Controls.AlphaGradientPanel();
            this.colorWithAlpha1 = new BlueActivity.Controls.ColorWithAlpha();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.alphaGradientPanel2 = new BlueActivity.Controls.AlphaGradientPanel();
            this.colorWithAlpha2 = new BlueActivity.Controls.ColorWithAlpha();
            this.colorWithAlpha3 = new BlueActivity.Controls.ColorWithAlpha();
            this.progressBarEx2 = new ProgressODoom.ProgressBarEx();
            this.plainBackgroundPainter1 = new ProgressODoom.PlainBackgroundPainter();
            this.plainBorderPainter1 = new ProgressODoom.PlainBorderPainter();
            this.barberPoleProgressPainter1 = new ProgressODoom.BarberPoleProgressPainter();
            this.progressBarEx1 = new ProgressODoom.ProgressBarEx();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alphaGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(108, 26);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "%";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(108, 121);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(307, 23);
            this.progressBar2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "%";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Items restantes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Items restantes:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(325, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "-";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(328, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "-";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "word:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(108, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 21);
            this.label12.TabIndex = 15;
            this.label12.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(109, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "-";
            // 
            // alphaGradientPanel1
            // 
            this.alphaGradientPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.alphaGradientPanel1.Border = true;
            this.alphaGradientPanel1.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.alphaGradientPanel1.Colors.Add(this.colorWithAlpha1);
            this.alphaGradientPanel1.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel1.CornerRadius = 5;
            this.alphaGradientPanel1.Corners = ((BlueActivity.Controls.Corner)((((BlueActivity.Controls.Corner.TopLeft | BlueActivity.Controls.Corner.TopRight) 
            | BlueActivity.Controls.Corner.BottomLeft) 
            | BlueActivity.Controls.Corner.BottomRight)));
            this.alphaGradientPanel1.Gradient = false;
            this.alphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.alphaGradientPanel1.GradientOffset = 1F;
            this.alphaGradientPanel1.GradientSize = new System.Drawing.Size(0, 0);
            this.alphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            this.alphaGradientPanel1.Grayscale = false;
            this.alphaGradientPanel1.Image = null;
            this.alphaGradientPanel1.ImageAlpha = 75;
            this.alphaGradientPanel1.ImagePadding = new System.Windows.Forms.Padding(5);
            this.alphaGradientPanel1.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight;
            this.alphaGradientPanel1.ImageSize = new System.Drawing.Size(48, 48);
            this.alphaGradientPanel1.Location = new System.Drawing.Point(35, 279);
            this.alphaGradientPanel1.Name = "alphaGradientPanel1";
            this.alphaGradientPanel1.Rounded = true;
            this.alphaGradientPanel1.Size = new System.Drawing.Size(365, 116);
            this.alphaGradientPanel1.TabIndex = 18;
            // 
            // colorWithAlpha1
            // 
            this.colorWithAlpha1.Alpha = 255;
            this.colorWithAlpha1.Color = System.Drawing.SystemColors.Control;
            this.colorWithAlpha1.Parent = this.alphaGradientPanel1;
            // 
            // progressBar3
            // 
            this.progressBar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar3.ForeColor = System.Drawing.Color.Silver;
            this.progressBar3.Location = new System.Drawing.Point(17, 69);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(313, 15);
            this.progressBar3.Step = 1;
            this.progressBar3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar3.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Power Green", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.Location = new System.Drawing.Point(243, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "%";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Power Green", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.Location = new System.Drawing.Point(14, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Procesado";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Power Green", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.Location = new System.Drawing.Point(14, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 16);
            this.label16.TabIndex = 11;
            this.label16.Text = "-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemainingTime.Font = new System.Drawing.Font("Power Green", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRemainingTime.Location = new System.Drawing.Point(189, 32);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(141, 13);
            this.lblRemainingTime.TabIndex = 12;
            this.lblRemainingTime.Text = "%";
            this.lblRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(105, 263);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 13);
            this.label18.TabIndex = 13;
            this.label18.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Power Green", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label17.Location = new System.Drawing.Point(14, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "Tiempo transcurrido";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Power Green", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label19.Location = new System.Drawing.Point(14, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 16);
            this.label19.TabIndex = 14;
            this.label19.Text = "Tiempo restante";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblElapsedTime.Font = new System.Drawing.Font("Power Green", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElapsedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblElapsedTime.Location = new System.Drawing.Point(195, 15);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(135, 13);
            this.lblElapsedTime.TabIndex = 15;
            this.lblElapsedTime.Text = "%";
            this.lblElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // alphaGradientPanel2
            // 
            this.alphaGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.alphaGradientPanel2.Border = true;
            this.alphaGradientPanel2.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.alphaGradientPanel2.Colors.Add(this.colorWithAlpha2);
            this.alphaGradientPanel2.Colors.Add(this.colorWithAlpha3);
            this.alphaGradientPanel2.ContentPadding = new System.Windows.Forms.Padding(0);
            this.alphaGradientPanel2.Controls.Add(this.progressBarEx2);
            this.alphaGradientPanel2.Controls.Add(this.lblElapsedTime);
            this.alphaGradientPanel2.Controls.Add(this.label19);
            this.alphaGradientPanel2.Controls.Add(this.label15);
            this.alphaGradientPanel2.Controls.Add(this.label17);
            this.alphaGradientPanel2.Controls.Add(this.label14);
            this.alphaGradientPanel2.Controls.Add(this.lblRemainingTime);
            this.alphaGradientPanel2.Controls.Add(this.label16);
            this.alphaGradientPanel2.Controls.Add(this.progressBar3);
            this.alphaGradientPanel2.CornerRadius = 7;
            this.alphaGradientPanel2.Corners = ((BlueActivity.Controls.Corner)((((BlueActivity.Controls.Corner.TopLeft | BlueActivity.Controls.Corner.TopRight) 
            | BlueActivity.Controls.Corner.BottomLeft) 
            | BlueActivity.Controls.Corner.BottomRight)));
            this.alphaGradientPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaGradientPanel2.Gradient = true;
            this.alphaGradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.alphaGradientPanel2.GradientOffset = 1F;
            this.alphaGradientPanel2.GradientSize = new System.Drawing.Size(0, 0);
            this.alphaGradientPanel2.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile;
            this.alphaGradientPanel2.Grayscale = false;
            this.alphaGradientPanel2.Image = null;
            this.alphaGradientPanel2.ImageAlpha = 75;
            this.alphaGradientPanel2.ImagePadding = new System.Windows.Forms.Padding(5);
            this.alphaGradientPanel2.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight;
            this.alphaGradientPanel2.ImageSize = new System.Drawing.Size(48, 48);
            this.alphaGradientPanel2.Location = new System.Drawing.Point(448, 38);
            this.alphaGradientPanel2.Name = "alphaGradientPanel2";
            this.alphaGradientPanel2.Rounded = true;
            this.alphaGradientPanel2.Size = new System.Drawing.Size(346, 135);
            this.alphaGradientPanel2.TabIndex = 20;
            // 
            // colorWithAlpha2
            // 
            this.colorWithAlpha2.Alpha = 255;
            this.colorWithAlpha2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(84)))));
            this.colorWithAlpha2.Parent = this.alphaGradientPanel2;
            // 
            // colorWithAlpha3
            // 
            this.colorWithAlpha3.Alpha = 255;
            this.colorWithAlpha3.Color = System.Drawing.Color.Black;
            this.colorWithAlpha3.Parent = this.alphaGradientPanel2;
            // 
            // progressBarEx2
            // 
            this.progressBarEx2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBarEx2.BackgroundPainter = this.plainBackgroundPainter1;
            this.progressBarEx2.BorderPainter = this.plainBorderPainter1;
            this.progressBarEx2.Font = new System.Drawing.Font("Power Green", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarEx2.ForeColor = System.Drawing.Color.Black;
            this.progressBarEx2.Location = new System.Drawing.Point(17, 104);
            this.progressBarEx2.MarqueePercentage = 25;
            this.progressBarEx2.MarqueeSpeed = 30;
            this.progressBarEx2.MarqueeStep = 1;
            this.progressBarEx2.Maximum = 100;
            this.progressBarEx2.Minimum = 0;
            this.progressBarEx2.Name = "progressBarEx2";
            this.progressBarEx2.ProgressPadding = 0;
            this.progressBarEx2.ProgressPainter = this.barberPoleProgressPainter1;
            this.progressBarEx2.ProgressType = ProgressODoom.ProgressType.Smooth;
            this.progressBarEx2.ShowPercentage = true;
            this.progressBarEx2.Size = new System.Drawing.Size(313, 15);
            this.progressBarEx2.TabIndex = 17;
            this.progressBarEx2.Value = 0;
            // 
            // plainBackgroundPainter1
            // 
            this.plainBackgroundPainter1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.plainBackgroundPainter1.GlossPainter = null;
            // 
            // plainBorderPainter1
            // 
            this.plainBorderPainter1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.plainBorderPainter1.RoundedCorners = false;
            this.plainBorderPainter1.Style = ProgressODoom.PlainBorderPainter.PlainBorderStyle.Flat;
            // 
            // barberPoleProgressPainter1
            // 
            this.barberPoleProgressPainter1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(44)))), ((int)(((byte)(128)))));
            this.barberPoleProgressPainter1.GlossPainter = null;
            this.barberPoleProgressPainter1.ProgressBorderPainter = this.plainBorderPainter1;
            // 
            // progressBarEx1
            // 
            this.progressBarEx1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBarEx1.BackgroundPainter = this.plainBackgroundPainter1;
            this.progressBarEx1.BorderPainter = this.plainBorderPainter1;
            this.progressBarEx1.Font = new System.Drawing.Font("Power Green", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarEx1.ForeColor = System.Drawing.Color.Black;
            this.progressBarEx1.Location = new System.Drawing.Point(105, 194);
            this.progressBarEx1.MarqueePercentage = 25;
            this.progressBarEx1.MarqueeSpeed = 30;
            this.progressBarEx1.MarqueeStep = 1;
            this.progressBarEx1.Maximum = 100;
            this.progressBarEx1.Minimum = 0;
            this.progressBarEx1.Name = "progressBarEx1";
            this.progressBarEx1.ProgressPadding = 0;
            this.progressBarEx1.ProgressPainter = this.barberPoleProgressPainter1;
            this.progressBarEx1.ProgressType = ProgressODoom.ProgressType.Smooth;
            this.progressBarEx1.ShowPercentage = true;
            this.progressBarEx1.Size = new System.Drawing.Size(313, 15);
            this.progressBarEx1.TabIndex = 16;
            this.progressBarEx1.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 419);
            this.Controls.Add(this.alphaGradientPanel1);
            this.Controls.Add(this.progressBarEx1);
            this.Controls.Add(this.alphaGradientPanel2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.alphaGradientPanel2.ResumeLayout(false);
            this.alphaGradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private BlueActivity.Controls.AlphaGradientPanel alphaGradientPanel1;
        private System.Windows.Forms.ProgressBar progressBar3;
        private BlueActivity.Controls.ColorWithAlpha colorWithAlpha1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private BlueActivity.Controls.AlphaGradientPanel alphaGradientPanel2;
        private BlueActivity.Controls.ColorWithAlpha colorWithAlpha2;
        private BlueActivity.Controls.ColorWithAlpha colorWithAlpha3;
        private ProgressODoom.ProgressBarEx progressBarEx1;
        private ProgressODoom.BarberPoleProgressPainter barberPoleProgressPainter1;
        private ProgressODoom.PlainBorderPainter plainBorderPainter1;
        private ProgressODoom.PlainBackgroundPainter plainBackgroundPainter1;
        private ProgressODoom.ProgressBarEx progressBarEx2;
        private System.Windows.Forms.Timer timer1;
    }
}

