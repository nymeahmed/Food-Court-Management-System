using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodCourtManagementSystem
{
    public partial class Burger : Form
    {
        Boolean ischange = false;
        public Burger(string uname)
        {
            InitializeComponent();

            lblUname.Text = uname;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            lbltotal.Visible = true;
            txtboxVoucher.Visible = false;
            btnApply.Visible = false;
            btnTotal2.Visible = false;
            btnTotal2.Visible = true;
            btnOrder.Visible = false;
            btnCancel.Visible = false;
            if (taka180.Checked && !taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                lbltotal.Text = "240";
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                lbltotal.Text = "210";
                button1.Visible = true;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                lbltotal.Text = "180";
                button1.Visible = true;
            }
            else if (!taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                lbltotal.Text = "160";
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                int num = 240 + 210;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 240 + 180;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                int num = 240 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 210 + 180;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                int num = 210 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 180 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 240 + 210 + 180;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                int num = 240 + 210 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 240 + 180 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 210 + 180 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 240 + 210 + 180 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else
            {
                lbltotal.Text = "0";
                button1.Visible = false;
                btnTotal2.Visible = false;
                lbltotal2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbltotal.Text == "0")
            {
                MessageBox.Show("Please select an item first then click Subtotal");
            }
            else
            {
                txtboxVoucher.Visible = true;
                btnApply.Visible = true;
                btnCancel.Visible = true;
            }
        }

        private void txtboxVoucher_Click(object sender, EventArgs e)
        {
            if (txtboxVoucher.Text == "Voucher code")
            {
                ischange = true;
                txtboxVoucher.Text = "";
                txtboxVoucher.ForeColor = Color.Black;
            }
        }

        private void txtboxVoucher_TextChanged(object sender, EventArgs e)
        {
            if (txtboxVoucher.Text == "" && ischange == false)
            {
                txtboxVoucher.Text = "Voucher code";
                txtboxVoucher.ForeColor = Color.LightSalmon;
            }
            else
                ischange = false;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtboxVoucher.Text == "C#2K20")
            {
                //lbltotal2.Visible = false;

                string x = lbltotal.Text;
                int num = Int32.Parse(x);
                double total = num * 0.1;
                total = num - total;
                string subtotal = total.ToString();
                lbltotal2.Text = subtotal;
                MessageBox.Show("Applied");
                btnTotal2.Visible = true;
                //lbltotal2.Visible = false;
            }
            else if (txtboxVoucher.Text == "Voucher code" || txtboxVoucher.Text == "")
            {
                MessageBox.Show("Please enter a code");
            }
            else
            {
                MessageBox.Show("Code expired");
                btnTotal2.Visible = false;
                lbltotal2.Visible = false;
                btnOrder.Visible = false;
                btnTotal2.Visible = true;
                txtboxVoucher.ForeColor = Color.Red;
                btnOrder.Visible = true;
            }
        }

        private void btnTotal2_Click(object sender, EventArgs e)
        {
            btnOrder.Visible = true;
            if (txtboxVoucher.Text == "C#2K20")
            {
                lbltotal2.Visible = true;
            }
            else
            {
                lbltotal2.Visible = true;
                lbltotal2.Text = lbltotal.Text;
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            string username = lblUname.Text;
            string foodtype = "Burger";
            string cost = lbltotal2.Text;
            int foodId = 0;

            if (taka180.Checked && !taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 601;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 602;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 603;
            }
            else if (!taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 604;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 605;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 606;
            }
            else if (taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 607;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 608;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 609;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 610;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 611;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 612;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 613;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 614;
            }
            else //4 selected
            {
                foodId = 615;
            }

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "insert into OrderList (UserName,FoodType,FoodID,Cost) VALUES ('" + username + "','" + foodtype + "','" + foodId + "','" + cost + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                this.Hide();
                Payment aa = new Payment(lbltotal2.Text);
                aa.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtboxVoucher.Visible = false;
            btnApply.Visible = false;
            btnCancel.Visible = false;
        }
    }
}
