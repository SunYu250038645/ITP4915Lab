namespace Lab_03
{
    partial class frm3a
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
            saveFileDialog1 = new SaveFileDialog();
            label1 = new Label();
            Cast = new Button();
            choose = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 38);
            label1.Name = "label1";
            label1.Size = new Size(169, 15);
            label1.TabIndex = 0;
            label1.Text = "My chocie of best movie series";
            label1.Click += label1_Click;
            // 
            // Cast
            // 
            Cast.Location = new Point(109, 122);
            Cast.Name = "Cast";
            Cast.Size = new Size(75, 23);
            Cast.TabIndex = 2;
            Cast.Text = "Cast your vote";
            Cast.UseVisualStyleBackColor = true;
            Cast.Click += Cast_Click;
            // 
            // choose
            // 
            choose.DropDownStyle = ComboBoxStyle.DropDownList;
            choose.FormattingEnabled = true;
            choose.Items.AddRange(new object[] { "The Godfather", "Terminator", "Back to the Future", "Matrix" });
            choose.Location = new Point(109, 76);
            choose.Name = "choose";
            choose.Size = new Size(121, 23);
            choose.TabIndex = 3;
            choose.SelectedIndexChanged += choose_SelectedIndexChanged;
            // 
            // frm3a
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(choose);
            Controls.Add(Cast);
            Controls.Add(label1);
            Name = "frm3a";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private TextBox textBox1;
        private Button Cast;
        private ComboBox choose;
    }
}
