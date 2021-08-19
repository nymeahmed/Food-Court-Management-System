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
    public partial class Breakfast : Form
    {
        Boolean ischange = false;
        public Breakfast(string uname)
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
            if(taka180.Checked && !taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                lbltotal.Text = "180";
                button1.Visible = true;
            }
            else if(!taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                lbltotal.Text = "120";
                button1.Visible = true;
            }
            else if(!taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                lbltotal.Text = "90";
                button1.Visible = true;
            }
            else if(!taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                lbltotal.Text = "80";
                button1.Visible = true;
            }
            else if(taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                int num = 180 + 120;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 180 + 90;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                int num = 180 + 80;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 120 + 90;
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
                int num = 90 + 80;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 180 + 120 + 90;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                int num = 180 + 120 + 80;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 180 + 90 + 80;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 120 + 90 + 80;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 180 + 120 + 90 + 80;
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
            if(lbltotal.Text == "0")
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
            if(txtboxVoucher.Text=="C#2K20")
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
            else if(txtboxVoucher.Text=="Voucher code" || txtboxVoucher.Text=="")
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
            if(txtboxVoucher.Text == "C#2K20")
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
            string foodtype = "Breakfast";
            string cost = lbltotal2.Text;
            int foodId = 0;

            if (taka180.Checked && !taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 101;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 102;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 103;
            }
            else if (!taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 104;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 105;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 106;
            }
            else if (taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 107;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 108;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 109;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 110;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 111;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 112;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 113;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 114;
            }
            else //4 selected
            {
                foodId = 115;
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

        private void Breakfast_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
