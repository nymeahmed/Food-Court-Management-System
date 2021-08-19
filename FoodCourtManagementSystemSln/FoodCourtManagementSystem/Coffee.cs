using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCourtManagementSystem
{
    public partial class Payment : Form
    {
        Boolean ischange = false;
        public Payment(string taka)
        {
            InitializeComponent();

            lbltaka.Text = taka+" tk";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(radiobtnCash.Checked==true)
            {
                MessageBox.Show("Thanks for your order");
                this.Close();
            }
            else if(txtPin.Text!="")
            {
                MessageBox.Show("Thanks for your order");
                this.Close();
            }
            else
            {
                MessageBox.Show("No pin number is given");
            }
        }

        private void radiobtnBkash_CheckedChanged(object sender, EventArgs e)
        {
            lblBkash.Visible = true;
            txtboxBkash.Visible = true;

            button11.Visible = false;
        }

        private void radiobtnCash_CheckedChanged(object sender, EventArgs e)
        {
            lblBkash.Visible = false;
            txtboxBkash.Visible = false;
            lblPin.Visible = false;
            txtPin.Visible = false;

            button11.Visible = true;
        }

        private void txtboxBkash_Click(object sender, EventArgs e)
        {
            if (txtboxBkash.Text == "01XXXXXXXXX")
            {
                ischange = true;
                txtboxBkash.Text = "";
                txtboxBkash.ForeColor = Color.Black;

            }
        }

        private void txtboxBkash_TextChanged(object sender, EventArgs e)
        {
            if (txtboxBkash.Text == "" && ischange == false)
            {
                txtboxBkash.Text = "01XXXXXXXXX";
                txtboxBkash.ForeColor = Color.Red;

            }
            else
            {
                ischange = false;
            }

            string number = txtboxBkash.Text;
            if (number.StartsWith("01") && (number.Length == 11) && (txtboxBkash.Text!="01XXXXXXXXX"))
            {
                lblPin.Visible = true;
                txtPin.Visible = true;
                button11.Visible = true;
            }
            else
            {
                lblPin.Visible = false;
                txtPin.Visible = false;
                button11.Visible = false;
            }
        }
    }
}
