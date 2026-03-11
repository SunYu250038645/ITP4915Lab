namespace Lab_02
{
    partial class frmLab2A
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            grpPayment = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            label1 = new Label();
            lblResult = new Label();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            grpPayment.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(56, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(135, 152);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Wine Line";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(7, 72);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(123, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Beer(1 dozen)($75)";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(118, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "White Wine($180)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(7, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Red Winde ($250)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(32, 40);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(49, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "VISA";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(32, 65);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(86, 19);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "MasterCard";
            radioButton5.TextAlign = ContentAlignment.MiddleCenter;
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // grpPayment
            // 
            grpPayment.Controls.Add(radioButton4);
            grpPayment.Controls.Add(radioButton5);
            grpPayment.Location = new Point(228, 37);
            grpPayment.Name = "grpPayment";
            grpPayment.Size = new Size(200, 123);
            grpPayment.TabIndex = 6;
            grpPayment.TabStop = false;
            grpPayment.Text = "Payment Method";
            // 
            // button1
            // 
            button1.Location = new Point(349, 166);
            button1.Name = "button1";
            button1.Size = new Size(79, 23);
            button1.TabIndex = 7;
            button1.Text = "Calculete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 170);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 9;
            label1.Text = "Qty";
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Location = new Point(56, 209);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(372, 23);
            lblResult.TabIndex = 10;
            lblResult.Click += lblResult_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(60, 23);
            textBox1.TabIndex = 11;
            // 
            // frmLab2A
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(lblResult);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(grpPayment);
            Controls.Add(groupBox1);
            Name = "frmLab2A";
            Text = "Lab 2a";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private GroupBox grpPayment;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Label label1;
        private Label lblResult;
        private TextBox textBox1;
    }
}
