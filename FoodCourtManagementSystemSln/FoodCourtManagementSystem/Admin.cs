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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = txtboxAdminUname.Text;
            string password = txtboxAdminUpass.Text;

            //need to pass admin user name
            

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query = "select [Password] from Admin where Username = '" + uname + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                string dbPass = dt.Rows[0]["Password"].ToString();
                if (password == dbPass)
                {
                    MessageBox.Show("Login successful");
                    this.Hide();
                    Adminpage aa = new Adminpage(uname,password); //pass the username,password to adminpage
                    aa.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password doesn't match");
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Username doesn't match");
            }
            finally
            {
                conn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
