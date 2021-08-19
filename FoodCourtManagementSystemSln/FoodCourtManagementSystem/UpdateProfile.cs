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
    public partial class UpdateProfile : Form
    {
        Boolean ischange = false;
        public UpdateProfile(string email,string pass)
        {
            InitializeComponent();

            lblEmail.Text = email;
            lblPass.Text = pass;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (btnConfirmUname.BackColor == Color.Aqua)
            {
                this.Hide();
                Homepage aa = new Homepage(txtboxUname.Text);
                aa.ShowDialog();
            }
            else
            {
                this.Hide();
                Homepage aa = new Homepage(lblEmail.Text, lblPass.Text);
                //MessageBox.Show(lblEmail.Text);
                aa.ShowDialog();
            }
        }

        private void btnUname_Click(object sender, EventArgs e)
        {
            txtboxUname.Visible = true;
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            txtboxOldpass.Visible = true;         
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            txtboxPhone.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtboxUname.Visible = false;
            txtboxOldpass.Visible = false;
            txtboxPhone.Visible = false;
            lblAlert.Visible = false;
            txtboxNewpass.Visible = false;
            txtboxCpass.Visible = false;
            btnConfirmPass.Visible = false;
            lblPassRigh.Visible = false;
            lblPassCross.Visible = false;
            btnConfirmUname.Visible = false;
            lblUname.Visible = false;
            btnConfirmPhone.Visible = false;
            lblPhoneRigh.Visible = false;
            lblPhoneWrong.Visible = false;
            cmboxArea.Visible = false;
            btnConfirmArea.Visible = false;
            txtboxAddress.Visible = false;
            btnConfirmAddress.Visible = false;
            lblNotice1.Visible = false;
            lblNotice2.Visible = false;
            btnLoginagain.Visible = false;
        }

        private void txtboxNewpass_TextChanged(object sender, EventArgs e)
        {
            if (txtboxNewpass.Text == "" && ischange == false)
            {
                txtboxNewpass.Text = "Enter your new password";
                txtboxNewpass.ForeColor = Color.Red;
            }
            else
                ischange = false;

            if (txtboxCpass.Text != txtboxNewpass.Text)
            {
                lblPassCross.Visible = true;
                lblPassRigh.Visible = false;
                btnConfirmPass.Visible = false;
                lblNotice1.Visible = false;
                lblNotice2.Visible = false;
            }
            else
            {
                lblPassRigh.Visible = true;
                lblPassCross.Visible = false;
                btnConfirmPass.Visible = true;
                lblNotice1.Visible = true;
                lblNotice2.Visible = true;
            }
        }

        private void txtboxOldpass_TextChanged(object sender, EventArgs e)
        {
            if (txtboxOldpass.Text == "" && ischange == false)
            {
                txtboxOldpass.Text = "Enter your old password";
                txtboxOldpass.ForeColor = Color.Red;
            }
            else
                ischange = false;

            if (txtboxOldpass.Text == lblPass.Text)
            {
                lblAlert.Visible = true;
                lblAlert.Text = "✔";
                lblAlert.BackColor = Color.Green;

                txtboxNewpass.Visible = true;
                txtboxCpass.Visible = true;
            }
            else
            {
                lblAlert.Visible = true;
                lblAlert.Text = "❌";
                lblAlert.BackColor = Color.Red;

                txtboxNewpass.Visible = false;
                txtboxCpass.Visible = false;
            }
        }

        private void txtboxOldpass_Click(object sender, EventArgs e)
        {
            if (txtboxOldpass.Text == "Enter your old password")
            {
                ischange = true;
                txtboxOldpass.Text = "";
                txtboxOldpass.ForeColor = Color.Black;
            }
        }

        private void txtboxNewpass_Click(object sender, EventArgs e)
        {
            if (txtboxNewpass.Text == "Enter your new password")
            {
                ischange = true;
                txtboxNewpass.Text = "";
                txtboxNewpass.ForeColor = Color.Black;
            }
        }

        private void txtboxCpass_Click(object sender, EventArgs e)
        {
            if (txtboxCpass.Text == "Rewrite your new password")
            {
                ischange = true;
                txtboxCpass.Text = "";
                txtboxCpass.ForeColor = Color.Black;
            }
        }

        private void txtboxCpass_TextChanged(object sender, EventArgs e)
        {
            if (txtboxCpass.Text == "" && ischange == false)
            {
                txtboxCpass.Text = "Rewrite your new password";
                txtboxCpass.ForeColor = Color.Red;
            }
            else
                ischange = false;

            if (txtboxCpass.Text != txtboxNewpass.Text)
            {
                lblPassCross.Visible = true;
                lblPassRigh.Visible = false;
                btnConfirmPass.Visible = false;
                lblNotice1.Visible = false;
                lblNotice2.Visible = false;
            }
            else
            {
                lblPassRigh.Visible = true;
                lblPassCross.Visible = false;
                btnConfirmPass.Visible = true;
                lblNotice1.Visible = true;
                lblNotice2.Visible = true;
            }
        }

        private void btnConfirmPass_Click(object sender, EventArgs e)
        {
            if(lblPassRigh.Visible==true)
            {
                lblPass.Text = txtboxCpass.Text;
                btnBack.Visible = false;
                btnLoginagain.Visible = true;
                btnRefresh.Visible = false;
                btnConfirmPass.BackColor = Color.Aqua;

                string newPass = txtboxCpass.Text;
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                    conn.Open();

                    string query = "UPDATE UserInfo SET [Password] =  ('" + newPass + "') WHERE Email = '" + lblEmail.Text + "'";
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
                    //this.Close();
                }
            }
        }

        private void btnConfirmUname_Click(object sender, EventArgs e)
        {
            if(lblUname.Visible==true)
            {
                btnBack.Visible = false;
                btnLoginagain.Visible = true;
                btnRefresh.Visible = false;
                btnConfirmUname.BackColor = Color.Aqua;

                string newUname = txtboxUname.Text;
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                    conn.Open();

                    string query = "UPDATE UserInfo SET UserName =  ('" + newUname + "') WHERE Email = '" + lblEmail.Text + "'";
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

                    MessageBox.Show("Username updated!");
                    //this.Close();
                }
            }
        }

        private void txtboxUname_Click(object sender, EventArgs e)
        {
            if (txtboxUname.Text == "Enter your new username")
            {
                ischange = true;
                txtboxUname.Text = "";
                txtboxUname.ForeColor = Color.Black;
            }
        }

        private void txtboxUname_TextChanged(object sender, EventArgs e)
        {
            if (txtboxUname.Text == "" && ischange == false)
            {
                txtboxUname.Text = "Enter your new username";
                txtboxUname.ForeColor = Color.Red;
            }
            else
                ischange = false;

            if (txtboxUname.Text == "" || txtboxUname.Text == "Enter your new username")
            {
                lblUname.Visible = true;
                lblUname.Text = "❌";
                lblUname.BackColor = Color.Red;

                btnConfirmUname.Visible = false;
                lblNotice1.Visible = false;
                lblNotice2.Visible = false;
            }
            else
            {
                lblUname.Visible = true;
                lblUname.Text = "✔";
                lblUname.BackColor = Color.Green;

                btnConfirmUname.Visible = true;
                lblNotice1.Visible = true;
                lblNotice2.Visible = true;
            }
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtboxPhone_Click(object sender, EventArgs e)
        {
            if (txtboxPhone.Text == "01XXXXXXXXX")
            {
                ischange = true;
                txtboxPhone.Text = "";
                txtboxPhone.ForeColor = Color.Black;
            }
        }

        private void txtboxPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtboxPhone.Text == "" && ischange == false)
            {
                txtboxPhone.Text = "01XXXXXXXXX";
                txtboxPhone.ForeColor = Color.Red;
            }
            else
                ischange = false;

            string number = txtboxPhone.Text;
            if (number.StartsWith("01") && (number.Length == 11))
            {
                lblPhoneRigh.Visible = true;
                lblPhoneWrong.Visible = false;

                btnConfirmPhone.Visible = true;
                lblNotice1.Visible = true;
                lblNotice2.Visible = true;
            }
            else
            {
                lblPhoneRigh.Visible = false;
                lblPhoneWrong.Visible = true;

                btnConfirmPhone.Visible = false;
                lblNotice1.Visible = false;
                lblNotice2.Visible = false;
            }
        }

        private void btnConfirmPhone_Click(object sender, EventArgs e)
        {
            if(lblPhoneRigh.Visible==true)
            {
                btnBack.Visible = false;
                btnLoginagain.Visible = true;
                btnRefresh.Visible = false;
                btnConfirmPhone.BackColor = Color.Aqua;

                string newPhone = txtboxPhone.Text;
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                    conn.Open();

                    string query = "UPDATE UserInfo SET Phone =  ('" + newPhone + "') WHERE Email = '" + lblEmail.Text + "'";
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

                    MessageBox.Show("Phone Number updated!");
                    //this.Close();
                }
            }
        }

        private void lblPassRigh_Click(object sender, EventArgs e)
        {

        }

        private void cmboxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmboxArea.SelectedItem==null)
            {
                btnConfirmArea.Visible = false;
                lblNotice1.Visible = false;
                lblNotice2.Visible = false;
            }
            else
            {
                btnConfirmArea.Visible = true;
                lblNotice1.Visible = true;
                lblNotice2.Visible = true;
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            cmboxArea.Visible = true;
        }

        private void txtboxAddress_TextChanged(object sender, EventArgs e)
        {
            if(txtboxAddress.Text!=null)
            {
                btnConfirmAddress.Visible = true;
                lblNotice1.Visible = true;
                lblNotice2.Visible = true;
            }
            else
            {
                btnConfirmAddress.Visible = false;
                lblNotice1.Visible = false;
                lblNotice2.Visible = false;
            }
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            txtboxAddress.Visible = true;
        }

        private void btnConfirmArea_Click(object sender, EventArgs e)
        {
            if(cmboxArea.SelectedItem!=null)
            {
                btnBack.Visible = false;
                btnLoginagain.Visible = true;
                btnRefresh.Visible = false;
                btnConfirmArea.BackColor = Color.Aqua;

                string newArea = cmboxArea.SelectedItem.ToString();
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                    conn.Open();

                    string query = "UPDATE UserInfo SET Area =  ('" + newArea + "') WHERE Email = '" + lblEmail.Text + "'";
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

                    MessageBox.Show("Area updated!");
                    //this.Close();
                }
            }
        }

        private void btnConfirmAddress_Click(object sender, EventArgs e)
        {
            if(txtboxAddress.Text!=null)
            {
                btnBack.Visible = false;
                btnLoginagain.Visible = true;
                btnRefresh.Visible = false;
                btnConfirmAddress.BackColor = Color.Aqua;

                string newAddress = txtboxAddress.Text;
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                    conn.Open();

                    string query = "UPDATE UserInfo SET Address =  ('" + newAddress + "') WHERE Email = '" + lblEmail.Text + "'";
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

                    MessageBox.Show("Address updated!");
                    //this.Close();
                }
            }
        }

        private void btnLoginagain_Click(object sender, EventArgs e)
        {
            Form1 aa = new Form1();
            this.Hide();
            aa.ShowDialog();
        }
    }
}
