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
    public partial class Pasta : Form
    {
        Boolean ischange = false;
        public Pasta(string uname)
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
                lbltotal.Text = "220";
                button1.Visible = true;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                lbltotal.Text = "200";
                button1.Visible = true;
            }
            else if (!taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                lbltotal.Text = "160";
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                int num = 240 + 220;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 240 + 200;
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
                int num = 220 + 200;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                int num = 220 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 200 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 240 + 220 + 200;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                int num = 240 + 220 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 240 + 200 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 220 + 200 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 240 + 220 + 200 + 160;
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
            string foodtype = "Pasta";
            string cost = lbltotal2.Text;
            int foodId = 0;

            if (taka180.Checked && !taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 401;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 402;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 403;
            }
            else if (!taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 404;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 405;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 406;
            }
            else if (taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 407;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 408;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 409;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 410;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 411;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 412;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 413;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 414;
            }
            else //4 selected
            {
                foodId = 415;
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
