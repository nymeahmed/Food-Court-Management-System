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
    public partial class AdminPassChange : Form
    {
        public AdminPassChange(string value1,string value2)
        {
            InitializeComponent();
            lblUname.Text = value1; //admin username
            lblUname.Visible = true;

            lblPassword.Text = value2; //admin password
            //lblPassword.Visible = true;
        }

        private void lblUname_Click(object sender, EventArgs e)
        {

        }

        private void txtboxPrePass_TextChanged(object sender, EventArgs e)
        {
            if(txtboxPrePass.Text==lblPassword.Text)
            {
                lblAlert.Text = "Correct password";
                lblAlert.Visible = true;
                lblAlert.BackColor = Color.Green;

                lblNewPass.Visible = true;
                txtboxNewPass.Visible = true;
                lblConfirmPass.Visible = true;
                txtboxCPass.Visible = true;
                btnClose.Visible = false;
            }
            else
            {
                lblAlert.Text = "Incorrect password";
                lblAlert.Visible = true;
                lblAlert.BackColor = Color.Red;

                lblNewPass.Visible = false;
                txtboxNewPass.Visible = false;
                lblConfirmPass.Visible = false;
                txtboxCPass.Visible = false;
                btnClose.Visible = true;
            }
        }

        private void lblAlert_Click(object sender, EventArgs e)
        {

        }

        private void txtboxCPass_TextChanged(object sender, EventArgs e)
        {
            if(txtboxCPass.Visible==true && txtboxCPass.Text == txtboxNewPass.Text)
            {
                lblRigh.Visible = true;
                lblCross.Visible = false;

                btnUpdate.Visible = true;
                btnClose.Visible = false;
            }
            else
            {
                lblRigh.Visible = false;
                lblCross.Visible = true;

                btnUpdate.Visible = false;
                btnClose.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(btnUpdate.Visible==true && lblRigh.Visible==true)
            {
                string newpass = txtboxNewPass.Text;
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                    conn.Open();

                    string query = "UPDATE [Admin] SET [Password] =  ('"+newpass+"') WHERE Username = '"+lblUname.Text+"'";
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

                    MessageBox.Show("Password updated!");
                    this.Close();
                }
            }
        }

        private void txtboxNewPass_TextChanged(object sender, EventArgs e)
        {
            if (txtboxCPass.Visible == true && txtboxCPass.Text == txtboxNewPass.Text)
            {
                lblRigh.Visible = true;
                lblCross.Visible = false;

                btnUpdate.Visible = true;
                btnClose.Visible = false;
            }
            else
            {
                lblRigh.Visible = false;
                lblCross.Visible = true;

                btnUpdate.Visible = false;
                btnClose.Visible = true;
            }
        }
    }
}
