using Microsoft.Win32;

namespace Lab_02
{
    public partial class frmLab2A : Form
    {
        private int price;
        private string payment;

        public frmLab2A()
        {
            InitializeComponent();
            radioButton4.Checked = true;
            radioButton5.Checked = true;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 250;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 180;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 75;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            payment = "VISA";
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            payment = "MasterCard";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int total = price * Convert.ToInt32(textBox1.Text);
                Convert.ToInt32(textBox1.Text);
                lblResult.Text = $"Total Price: ${total} \nPayment: {payment} ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid quantity");
                textBox1.Text = "";
            }


        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
