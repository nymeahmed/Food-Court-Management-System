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
    public partial class Homepage : Form
    {
        public Homepage(string name,string email,string pass,string first)
        {
            InitializeComponent();
            string username = name;
            
            //lblUname2.Text = username;
            lblUname2.Visible = false;
            lblEmail.Text = email;
            lblEmail.Visible = false;
            lblPass.Text = pass;
            lblPass.Visible = false;


            lblUname.Text = first; //username showing


            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();
                string query = "select Username from UserInfo where Fname = '" + lblUname.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string uname = dt.Rows[0]["UserName"].ToString();

                lblUname.Text = "Hello " + uname;
                lblUname2.Text = uname;
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
        public Homepage(string uname)
        {
            InitializeComponent();
            string username = uname;

            lblUname2.Text = username;
            lblNewUname.Visible = false;
            lblPass.Visible = false;
            lblEmail.Visible = false;
            lblNewUname.Visible = false;
            lblUname2.Visible = false;

            lblUname.Text = "Hello " + username;
        }
        public Homepage(string email,string pass)
        {
            InitializeComponent();
            string eee = email;
            lblEmail.Text = email; //email ta astese na
            lblEmail.Visible = false;
            lblPass.Text = pass;
            lblPass.Visible = false;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();
                string query = "select UserName from UserInfo where Email = '" + eee + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string uname = dt.Rows[0]["UserName"].ToString();

                lblUname.Text = "Hello " + uname;
                lblUname2.Text = uname;
                lblUname2.Visible = false;
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

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 aa = new Form1();
            aa.Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderList aa = new OrderList(lblUname2.Text);
            aa.ShowDialog();
        }


        private void btnProfile_Click(object sender, EventArgs e)
        {
            MyProfile aa = new MyProfile(lblUname2.Text);
            aa.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MyOrders aa = new MyOrders(lblUname2.Text);
            aa.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProfile aa = new UpdateProfile(lblEmail.Text,lblPass.Text);
            aa.Show();
            this.Close();
        }
    }
}
