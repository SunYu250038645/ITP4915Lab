namespace Lab1
{
    partial class frmLab1
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
            btnAdd = new Button();
            txtNum2 = new TextBox();
            lblNum2 = new Label();
            lblNum1 = new Label();
            txtNum1 = new TextBox();
            lblSum = new Label();
            txtSum = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(349, 191);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(527, 103);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 1;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum2.Location = new Point(536, 80);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(59, 22);
            lblNum2.TabIndex = 2;
            lblNum2.Text = "Num2";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum1.Location = new Point(139, 74);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(59, 22);
            lblNum1.TabIndex = 4;
            lblNum1.Text = "Num1";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(139, 103);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 3;
            // 
            // lblSum
            // 
            lblSum.AutoSize = true;
            lblSum.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSum.Location = new Point(349, 274);
            lblSum.Name = "lblSum";
            lblSum.Size = new Size(46, 22);
            lblSum.TabIndex = 6;
            lblSum.Text = "Sum";
            // 
            // txtSum
            // 
            txtSum.Location = new Point(340, 297);
            txtSum.Name = "txtSum";
            txtSum.Size = new Size(100, 23);
            txtSum.TabIndex = 5;
            // 
            // frmLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSum);
            Controls.Add(txtSum);
            Controls.Add(lblNum1);
            Controls.Add(txtNum1);
            Controls.Add(lblNum2);
            Controls.Add(txtNum2);
            Controls.Add(btnAdd);
            Name = "frmLab1";
            Text = "Lab1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtNum2;
        private Label lblNum2;
        private Label lblNum1;
        private TextBox txtNum1;
        private Label lblSum;
        private TextBox txtSum;
    }
}
