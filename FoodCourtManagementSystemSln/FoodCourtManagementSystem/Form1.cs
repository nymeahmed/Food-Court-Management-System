using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCourtManagementSystem
{
    public partial class Form1 : Form
    {
        //Boolean ischange = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNowab_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Registraion aa = new Registraion();
            aa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Admin aa = new Admin();
            aa.ShowDialog();

            //this.Close();
        }

        private void txtboxUname_TextChanged(object sender, EventArgs e)
        {
            /*if (txtboxUname.Text == "" && ischange == false)
            {
                txtboxUname.Text = "Enter your user name";
                txtboxUname.ForeColor = Color.Red;
            }
            else
                ischange = false;*/
        }

        private void txtboxUname_Click(object sender, EventArgs e)
        {
            /*if(txtboxUname.Text=="Enter your user name")
            {
                ischange = true;
                txtboxUname.Text = "";
                txtboxUname.ForeColor = Color.Black;
            }*/
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string uname = txtboxUname.Text;
            string password = txtboxUpass.Text;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select [Password] from UserInfo where UserName = '"+uname+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string dbPass = dt.Rows[0]["Password"].ToString();

                string query2 = "select Email from UserInfo where UserName = '" + uname + "'";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                DataSet ds2 = new DataSet();
                SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
                adp2.Fill(ds2);
                DataTable dt2 = ds2.Tables[0];
                string email = dt2.Rows[0]["Email"].ToString();
                //MessageBox.Show(email);

                string query3 = "select Fname from UserInfo where UserName = '" + uname + "'";
                SqlCommand cmd3 = new SqlCommand(query3, conn);
                DataSet ds3 = new DataSet();
                SqlDataAdapter adp3 = new SqlDataAdapter(cmd3);
                adp3.Fill(ds3);
                DataTable dt3 = ds3.Tables[0];
                string fname = dt3.Rows[0]["Fname"].ToString();
                //MessageBox.Show(fname);

                if (password == dbPass)
                {
                    MessageBox.Show("Login Successfull");
                    //this.Close();

                    this.Hide();
                    Homepage aa = new Homepage(uname,email,dbPass,fname);
                    aa.ShowDialog();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Password doesn't match");
                    btnForget.Visible = true;
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Username doesn't match");
                btnForget.Visible = false;
            }
            finally
            {
                conn.Close();
            }

        }

        private void txtboxUpass_Click(object sender, EventArgs e)
        {
            /*if(txtboxUpass.Text=="Enter your password")
            {
                ischange = true;
                txtboxUpass.Text = "";
                txtboxUpass.ForeColor = Color.Black;
            }*/
        }

        private void txtboxUpass_TextChanged(object sender, EventArgs e)
        {
            /*if (txtboxUpass.Text == "" && ischange == false)
            {
                txtboxUpass.Text = "Enter your password";
                txtboxUpass.ForeColor = Color.Red;
            }
            else
                ischange = false;*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            AccountIdentification aa = new AccountIdentification(txtboxUname.Text);
            aa.Show();
        }
    }
}
