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
    public partial class Lunch : Form
    {
        Boolean ischange = false;
        public Lunch(string uname)
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
                lbltotal.Text = "230";
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                lbltotal.Text = "200";
                button1.Visible = true;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                lbltotal.Text = "160";
                button1.Visible = true;
            }
            else if (!taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                lbltotal.Text = "120";
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                int num = 230 + 200;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 230 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                int num = 230 + 120;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 200 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                int num = 200 + 120;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 160 + 120;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                int num = 230 + 200 + 160;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                int num = 230 + 200 + 120;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 230 + 160 + 120;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 200 + 160 + 120;
                lbltotal.Text = num.ToString();
                button1.Visible = true;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                int num = 230 + 200 + 160 + 120;
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
            string foodtype = "Lunch";
            string cost = lbltotal2.Text;
            int foodId = 0;

            if (taka180.Checked && !taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 201;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 202;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 203;
            }
            else if (!taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 204;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && !taka80.Checked)
            {
                foodId = 205;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 206;
            }
            else if (taka180.Checked && !taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 207;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 208;
            }
            else if (!taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 209;
            }
            else if (!taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 210;
            }
            else if (taka180.Checked && taka120.Checked && taka90.Checked && !taka80.Checked)
            {
                foodId = 211;
            }
            else if (taka180.Checked && taka120.Checked && !taka90.Checked && taka80.Checked)
            {
                foodId = 212;
            }
            else if (taka180.Checked && !taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 213;
            }
            else if (!taka180.Checked && taka120.Checked && taka90.Checked && taka80.Checked)
            {
                foodId = 214;
            }
            else //4 selected
            {
                foodId = 215;
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

        private void Lunch_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
