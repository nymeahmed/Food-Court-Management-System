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
    public partial class AccountIdentification : Form
    {
        public AccountIdentification(string name)
        {
            InitializeComponent();

            lblUname.Text = name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtboxEmail.Text;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select Email from UserInfo where UserName = '" + lblUname.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string dbemail = dt.Rows[0]["Email"].ToString();
                if(dbemail==email)
                {
                    //MessageBox.Show("Yes");
                    string query2 = "select [Password] from UserInfo where Email = '" + email + "'";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);

                    DataSet ds2 = new DataSet();
                    SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
                    adp2.Fill(ds2);
                    DataTable dt2 = ds2.Tables[0];
                    string dbpass = dt2.Rows[0]["Password"].ToString();
                    lblPass.Text = "Your password: " + dbpass;
                    lblPass.Visible = true;
                    lblPass.BackColor = Color.LimeGreen;
                    btnOk.Visible = true;
                }
                else
                {
                    MessageBox.Show("Email address is not matched");
                    lblPass.Visible = false;
                    btnOk.Visible = false;
                }

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

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
