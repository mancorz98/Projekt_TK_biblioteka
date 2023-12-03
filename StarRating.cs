using Projekt_TK_biblioteka.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_TK_biblioteka
{
    public partial class StarRating : UserControl
    {
 
        public StarRating()
        {
            InitializeComponent();
        }

        private void StarRating_Load(object sender, EventArgs e)
        {

        }

        private void raiseOnValueChange(EventArgs e)
        {
            if (this.onValueChanged!= null)
                this.onValueChanged(this, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.yellow_star;
            pictureBox2.Image = Resources.white_star;
            pictureBox3.Image = Resources.white_star;
            pictureBox4.Image = Resources.white_star;
            pictureBox5.Image = Resources.white_star;
            label2.Text = "Twoja ocena: 1";
            value = 1;
            raiseOnValueChange (e);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.yellow_star;
            pictureBox2.Image = Resources.yellow_star;
            pictureBox3.Image = Resources.white_star;
            pictureBox4.Image = Resources.white_star;
            pictureBox5.Image = Resources.white_star;
            label2.Text = "Twoja ocena: 2";
            value = 2;
            raiseOnValueChange(e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.yellow_star;
            pictureBox2.Image = Resources.yellow_star;
            pictureBox3.Image = Resources.yellow_star;
            pictureBox4.Image = Resources.white_star;
            pictureBox5.Image = Resources.white_star;
            label2.Text = "Twoja ocena: 3";
            value = 3;
            raiseOnValueChange  (e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.yellow_star;
            pictureBox2.Image = Resources.yellow_star;
            pictureBox3.Image = Resources.yellow_star;
            pictureBox4.Image = Resources.yellow_star;
            pictureBox5.Image = Resources.white_star;
            label2.Text = "Twoja ocena: 4";
            value = 4;
            raiseOnValueChange  (e);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.yellow_star;
            pictureBox2.Image = Resources.yellow_star;
            pictureBox3.Image = Resources.yellow_star;
            pictureBox4.Image = Resources.yellow_star;
            pictureBox5.Image = Resources.yellow_star;
            label2.Text = "Twoja ocena: 5";
            value = 5;
            raiseOnValueChange(e);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
