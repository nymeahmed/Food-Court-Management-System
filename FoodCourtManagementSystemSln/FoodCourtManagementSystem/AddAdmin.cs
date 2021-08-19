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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void txtboxCpass_TextChanged(object sender, EventArgs e)
        {
            if(txtboxCpass.Text!=txtboxAdminPass.Text)
            {
                lblCross.Visible = true;
                lblRigh.Visible = false;

                
            }
            else
            {
                lblRigh.Visible = true;
                lblCross.Visible = false;

                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtboxAdminUname!=null && lblRigh.Visible==true)
            {
                string uname = txtboxAdminUname.Text;
                string password = txtboxCpass.Text;

                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                    conn.Open();

                    string query = "insert into [Admin](Username,[Password]) values ('"+uname+"','"+password+"')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();

                    MessageBox.Show("New Admin added!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please check the username,password again!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtboxAdminPass_TextChanged(object sender, EventArgs e)
        {
            if (txtboxCpass.Text != txtboxAdminPass.Text)
            {
                lblCross.Visible = true;
                lblRigh.Visible = false;


            }
            else
            {
                lblRigh.Visible = true;
                lblCross.Visible = false;

                button1.Visible = true;
            }
        }
    }
}
