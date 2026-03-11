namespace Lab_03
{
    public partial class frm3a : Form
    {
        public frm3a()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void choose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cast_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You voted for:" + "\n" + choose.Text, "Lab 03");
            DialogResult result = MessageBox.Show("Do you want to vote again?", "Lab 03", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                choose.SelectedIndex = -1;
            }
            else if(result == DialogResult.No)
            {
                MessageBox.Show("Thank you for voting!", "Lab 03");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid choice. Please select Yes or No.", "Lab 03", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
    }
}
