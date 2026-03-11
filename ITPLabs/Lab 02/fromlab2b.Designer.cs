namespace Lab_02
{
    partial class fromlab2b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fromlab2b));
            label1 = new Label();
            groupBox1 = new GroupBox();
            P3 = new PictureBox();
            P4 = new PictureBox();
            P2 = new PictureBox();
            P1 = new PictureBox();
            choose4 = new RadioButton();
            choose3 = new RadioButton();
            choose2 = new RadioButton();
            choose1 = new RadioButton();
            lblResult = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)P3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)P1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 50);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter your name here:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(P3);
            groupBox1.Controls.Add(P4);
            groupBox1.Controls.Add(P2);
            groupBox1.Controls.Add(P1);
            groupBox1.Controls.Add(choose4);
            groupBox1.Controls.Add(choose3);
            groupBox1.Controls.Add(choose2);
            groupBox1.Controls.Add(choose1);
            groupBox1.Location = new Point(54, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 186);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Choose";
            // 
            // P3
            // 
            P3.Image = (Image)resources.GetObject("P3.Image");
            P3.Location = new Point(212, 96);
            P3.Name = "P3";
            P3.Size = new Size(64, 68);
            P3.TabIndex = 7;
            P3.TabStop = false;
            // 
            // P4
            // 
            P4.Image = (Image)resources.GetObject("P4.Image");
            P4.Location = new Point(321, 96);
            P4.Name = "P4";
            P4.Size = new Size(62, 68);
            P4.TabIndex = 6;
            P4.TabStop = false;
            P4.Click += pictureBox3_Click;
            // 
            // P2
            // 
            P2.Image = (Image)resources.GetObject("P2.Image");
            P2.Location = new Point(321, 22);
            P2.Name = "P2";
            P2.Size = new Size(62, 68);
            P2.TabIndex = 5;
            P2.TabStop = false;
            // 
            // P1
            // 
            P1.Image = (Image)resources.GetObject("P1.Image");
            P1.Location = new Point(212, 22);
            P1.Name = "P1";
            P1.Size = new Size(64, 68);
            P1.TabIndex = 4;
            P1.TabStop = false;
            P1.Click += P1_Click;
            // 
            // choose4
            // 
            choose4.AutoSize = true;
            choose4.Location = new Point(15, 121);
            choose4.Name = "choose4";
            choose4.Size = new Size(58, 19);
            choose4.TabIndex = 3;
            choose4.Text = "&Sunny";
            choose4.UseVisualStyleBackColor = true;
            choose4.CheckedChanged += choose4_CheckedChanged;
            // 
            // choose3
            // 
            choose3.AutoSize = true;
            choose3.Location = new Point(15, 96);
            choose3.Name = "choose3";
            choose3.Size = new Size(60, 19);
            choose3.TabIndex = 2;
            choose3.Text = "S&nowy";
            choose3.UseVisualStyleBackColor = true;
            choose3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // choose2
            // 
            choose2.AutoSize = true;
            choose2.Location = new Point(15, 71);
            choose2.Name = "choose2";
            choose2.Size = new Size(54, 19);
            choose2.TabIndex = 1;
            choose2.Text = "&Rainy";
            choose2.UseVisualStyleBackColor = true;
            choose2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // choose1
            // 
            choose1.AutoSize = true;
            choose1.Location = new Point(15, 46);
            choose1.Name = "choose1";
            choose1.Size = new Size(63, 19);
            choose1.TabIndex = 0;
            choose1.Text = "&Cloudy";
            choose1.UseVisualStyleBackColor = true;
            choose1.CheckedChanged += Cloudy_CheckedChanged;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(54, 342);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(453, 23);
            lblResult.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 23);
            textBox1.TabIndex = 12;
            // 
            // fromlab2b
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(lblResult);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "fromlab2b";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)P3).EndInit();
            ((System.ComponentModel.ISupportInitialize)P4).EndInit();
            ((System.ComponentModel.ISupportInitialize)P2).EndInit();
            ((System.ComponentModel.ISupportInitialize)P1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton choose4;
        private RadioButton choose3;
        private RadioButton choose2;
        private RadioButton choose1;
        private Label lblResult;
        private PictureBox P3;
        private PictureBox P4;
        private PictureBox P2;
        private PictureBox P1;
        private TextBox textBox1;
    }
}