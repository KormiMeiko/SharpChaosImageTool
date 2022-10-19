namespace SharpChaosImageTool
{
    partial class MainForm
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
            this.uTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.picSource = new System.Windows.Forms.PictureBox();
            this.picDest = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDest)).BeginInit();
            this.SuspendLayout();
            // 
            // uTextBox
            // 
            this.uTextBox.Location = new System.Drawing.Point(239, 12);
            this.uTextBox.Name = "uTextBox";
            this.uTextBox.Size = new System.Drawing.Size(93, 30);
            this.uTextBox.TabIndex = 0;
            this.uTextBox.Text = "3.8";
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(239, 48);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(93, 30);
            this.xTextBox.TabIndex = 1;
            this.xTextBox.Text = "0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parameter u (3.57≤u≤4):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parameter x (0<x<1):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Load image:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Choose image file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picSource
            // 
            this.picSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSource.Location = new System.Drawing.Point(12, 134);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(350, 350);
            this.picSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSource.TabIndex = 6;
            this.picSource.TabStop = false;
            // 
            // picDest
            // 
            this.picDest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDest.Location = new System.Drawing.Point(368, 134);
            this.picDest.Name = "picDest";
            this.picDest.Size = new System.Drawing.Size(350, 350);
            this.picDest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDest.TabIndex = 7;
            this.picDest.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(726, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "Process the image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(726, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(277, 34);
            this.button3.TabIndex = 9;
            this.button3.Text = "Save the processed image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(952, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 34);
            this.button4.TabIndex = 10;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 496);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.picDest);
            this.Controls.Add(this.picSource);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.uTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Chaos Image Tool";
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox uTextBox;
        private TextBox xTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private PictureBox picSource;
        private PictureBox picDest;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}