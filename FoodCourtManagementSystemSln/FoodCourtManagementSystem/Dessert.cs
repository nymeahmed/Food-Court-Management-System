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
    public partial class Dessert : Form
    {
        Boolean ischange = false;
        public Dessert(string uname)
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
                lbltotal.Text = "200";
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                lbltotal.Text = "120";
                button1.Visible = true;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                lbltotal.Text = "100";
                button1.Visible = true;
            }
            else if (!taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                lbltotal.Text = "80";
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                int num = 200 + 120;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 200 + 100;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                int num = 200 + 80;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 120 + 100;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                int num = 120 + 80;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 100 + 80;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 200 + 120 + 100;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                int num = 200 + 120 + 80;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 200 + 100 + 80;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 120 + 100 + 80;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 200 + 120 + 100 + 80;
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
            string foodtype = "Dessert";
            string cost = lbltotal2.Text;
            int foodId = 0;

            if (taka180.Checked && !taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 701;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 702;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 703;
            }
            else if (!taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 704;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 705;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 706;
            }
            else if (taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 707;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 708;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 709;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 710;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 711;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 712;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 713;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 714;
            }
            else //4 selected
            {
                foodId = 715;
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
