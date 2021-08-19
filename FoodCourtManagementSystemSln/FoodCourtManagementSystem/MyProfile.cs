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
    public partial class MyProfile : Form
    {
        public MyProfile(string x)
        {
            InitializeComponent();

            string uname = x;
            label6.Text = uname;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                conn.Open();

                string query1 = "select Email from UserInfo where Username = '" +uname+ "'";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                DataSet ds1 = new DataSet();
                SqlDataAdapter adp1 = new SqlDataAdapter(cmd1);
                adp1.Fill(ds1);
                DataTable dt1 = ds1.Tables[0];
                string email = dt1.Rows[0]["Email"].ToString();
                label7.Text = email;

                string query2 = "select Phone from UserInfo where Username = '" + uname + "'";
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                DataSet ds2 = new DataSet();
                SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
                adp2.Fill(ds2);
                DataTable dt2 = ds2.Tables[0];
                string phone = dt2.Rows[0]["Phone"].ToString();
                label8.Text = phone;

                string query3 = "select Area from UserInfo where Username = '" + uname + "'";
                SqlCommand cmd3 = new SqlCommand(query3, conn);
                DataSet ds3 = new DataSet();
                SqlDataAdapter adp3 = new SqlDataAdapter(cmd3);
                adp3.Fill(ds3);
                DataTable dt3 = ds3.Tables[0];
                string area = dt3.Rows[0]["Area"].ToString();
                label9.Text = area;

                string query4 = "select [Address] from UserInfo where Username = '" + uname + "'";
                SqlCommand cmd4 = new SqlCommand(query4, conn);
                DataSet ds4 = new DataSet();
                SqlDataAdapter adp4 = new SqlDataAdapter(cmd4);
                adp4.Fill(ds4);
                DataTable dt4 = ds4.Tables[0];
                string address = dt4.Rows[0]["Address"].ToString();
                label10.Text = address;

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
