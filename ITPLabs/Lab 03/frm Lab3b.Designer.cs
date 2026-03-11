namespace Lab_03
{
    partial class frm
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
            lblAmount = new Label();
            lblRate = new Label();
            label3 = new Label();
            lblMillion = new Label();
            button1 = new Button();
            textAmount = new TextBox();
            txtRate = new TextBox();
            lblValue2 = new Label();
            lblMillion2 = new Label();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(64, 30);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(51, 15);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Amount";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Location = new Point(64, 77);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(69, 15);
            lblRate.TabIndex = 1;
            lblRate.Text = "InterestRate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 153);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 2;
            label3.Text = "Value after 10 years";
            // 
            // lblMillion
            // 
            lblMillion.AutoSize = true;
            lblMillion.Location = new Point(70, 204);
            lblMillion.Name = "lblMillion";
            lblMillion.Size = new Size(101, 15);
            lblMillion.TabIndex = 3;
            lblMillion.Text = "Year to reach $1M";
            // 
            // button1
            // 
            button1.Location = new Point(70, 114);
            button1.Name = "button1";
            button1.Size = new Size(192, 23);
            button1.TabIndex = 4;
            button1.Text = "Start Calculation";
            button1.UseVisualStyleBackColor = true;
            // 
            // textAmount
            // 
            textAmount.Location = new Point(162, 27);
            textAmount.Name = "textAmount";
            textAmount.Size = new Size(100, 23);
            textAmount.TabIndex = 5;
            textAmount.TextChanged += this.textAmount_TextChanged;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(162, 74);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 6;
            // 
            // lblValue2
            // 
            lblValue2.BorderStyle = BorderStyle.Fixed3D;
            lblValue2.Location = new Point(191, 153);
            lblValue2.Name = "lblValue2";
            lblValue2.Size = new Size(38, 15);
            lblValue2.TabIndex = 7;
            lblValue2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMillion2
            // 
            lblMillion2.BorderStyle = BorderStyle.Fixed3D;
            lblMillion2.Location = new Point(191, 204);
            lblMillion2.Name = "lblMillion2";
            lblMillion2.Size = new Size(150, 17);
            lblMillion2.TabIndex = 8;
            lblMillion2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMillion2);
            Controls.Add(lblValue2);
            Controls.Add(txtRate);
            Controls.Add(textAmount);
            Controls.Add(button1);
            Controls.Add(lblMillion);
            Controls.Add(label3);
            Controls.Add(lblRate);
            Controls.Add(lblAmount);
            Name = "frm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmount;
        private Label lblRate;
        private Label label3;
        private Label lblMillion;
        private Button button1;
        private TextBox textAmount;
        private TextBox txtRate;
        private Label lblValue2;
        private Label lblMillion2;
    }
}