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
    public partial class fromlab2b : Form
    {
        public fromlab2b()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            chagePhoto(P2, "Rainy");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            chagePhoto(P3, "Snowy");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Cloudy_CheckedChanged(object sender, EventArgs e)
        {
            chagePhoto(P1, "Cloudy");
        }

        private void choose4_CheckedChanged(object sender, EventArgs e)
        {
            chagePhoto(P4, "Sunny");
        }

        private void chagePhoto(PictureBox chosePictureBox, String weather)
        {
            P1.Visible = false;
            P2.Visible = false;
            P3.Visible = false;
            P4.Visible = false;
            chosePictureBox.Visible = true;
            lblResult.Text = $"This is going to be a {weather} day,{textBox1.Text}!";
        }

        private void P1_Click(object sender, EventArgs e)
        {

        }
    }
}
