using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class frmLab2C : Form
    {
        public frmLab2C()
        {
            InitializeComponent();
        }

        private void frmLab2C_Load(object sender, EventArgs e)
        {
            lstStudents.Items.Add("Mary Chu");
            lstStudents.Items.Add("Peter Lee");
            lstStudents.Items.Add("Johnson Chan");
            lstStudents.Items.Add("Sandy Wong");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Add(txtName.Text);
            lblMessage.Text = $"{txtName.Text} added successfully !";
            txtName.Text = " ";
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstStudents.DoubleClick += (s, args) =>
            {
                if (lstStudents.SelectedItem != null)
                {
                    string name = lstStudents.SelectedItem.ToString();
                    lstStudents.Items.Remove(name);
                    lblMessage.Text = $"{name} deleted successfully !";
                }
            };
        }

        
    }
}