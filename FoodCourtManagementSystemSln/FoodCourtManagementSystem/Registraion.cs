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
    public partial class Registraion : Form
    {
        Boolean ischange = false;
        public Registraion()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtboxFname_Click(object sender, EventArgs e)
        {
            if(txtboxFname.Text=="Enter your first name")
            {
                ischange = true;
                txtboxFname.Text = "";
                txtboxFname.ForeColor = Color.Black;
            }
        }

        private void txtboxFname_TextChanged(object sender, EventArgs e)
        {
            if (txtboxFname.Text == "" && ischange == false)
            {
                txtboxFname.Text = "Enter your first name";
                txtboxFname.ForeColor = Color.Red;
            }
            else
                ischange = false;
        }

        private void txtboxLname_Click(object sender, EventArgs e)
        {
            if (txtboxLname.Text == "Enter your last name")
            {
                ischange = true;
                txtboxLname.Text = "";
                txtboxLname.ForeColor = Color.Black;
            }
        }

        private void txtboxLname_TextChanged(object sender, EventArgs e)
        {
            if (txtboxLname.Text == "" && ischange == false)
            {
                txtboxLname.Text = "Enter your last name";
                txtboxLname.ForeColor = Color.Red;
            }
            else
                ischange = false;
        }

        private void txtboxUname_Click(object sender, EventArgs e)
        {
            if (txtboxUname.Text == "Enter your username")
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
                txtboxUname.Text = "Enter your username";
                txtboxUname.ForeColor = Color.Red;
            }
            else
                ischange = false;
        }

        private void txtboxPassword_Click(object sender, EventArgs e)
        {
            if (txtboxPassword.Text == "Enter your password")
            {
                ischange = true;
                txtboxPassword.Text = "";
                txtboxPassword.ForeColor = Color.Black;
                //txtboxPassword.PasswordChar = '*';
            }
        }

        private void txtboxPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtboxPassword.Text == "" && ischange == false)
            {
                txtboxPassword.Text = "Enter your password";
                txtboxPassword.ForeColor = Color.Red;
            }
            else
                ischange = false;

            if (txtboxCpassword.Text != txtboxPassword.Text)
            {
                lblCross.Visible = true;
                lblRigh.Visible = false;
            }
            else
            {
                lblCross.Visible = false;
                lblRigh.Visible = true;
            }
        }

        private void txtboxCpassword_Click(object sender, EventArgs e)
        {
            if (txtboxCpassword.Text == "Rewrite your password")
            {
                ischange = true;
                txtboxCpassword.Text = "";
                txtboxCpassword.ForeColor = Color.Black;
                //txtboxCpassword.PasswordChar = '*';
            }
        }

        private void txtboxCpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtboxCpassword.Text == "" && ischange == false)
            {
                txtboxCpassword.Text = "Rewrite your password";
                txtboxCpassword.ForeColor = Color.Red;
            }
            else
                ischange = false;

            if(txtboxCpassword.Text!=txtboxPassword.Text)
            {
                lblCross.Visible = true;
                lblRigh.Visible = false;
            }
            else
            {
                lblCross.Visible = false;
                lblRigh.Visible = true;
            }
        }

        private void txtboxEmail_Click(object sender, EventArgs e)
        {
            if (txtboxEmail.Text == "someone@example.com")
            {
                ischange = true;
                txtboxEmail.Text = "";
                txtboxEmail.ForeColor = Color.Black;
            }
        }

        private void txtboxEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtboxEmail.Text == "" && ischange == false)
            {
                txtboxEmail.Text = "someone@example.com";
                txtboxEmail.ForeColor = Color.Red;
            }
            else
                ischange = false;

            string email = txtboxEmail.Text;
            if(email.Contains("@") && email.Contains("."))
            {
                lblEmailRigh.Visible = true;
                lblEmailCross.Visible = false;
            }
            else
            {
                lblEmailCross.Visible = true;
                lblEmailRigh.Visible = false;
            }
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
                lblPhnRigh.Visible = true;
                lblPhnCross.Visible = false;
            }
            else
            {
                lblPhnRigh.Visible = false;
                lblPhnCross.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtboxFname.Text != null && txtboxLname.Text != null && txtboxUname.Text != null &&
                lblRigh.Visible == true && lblPhnRigh.Visible == true && lblEmailRigh.Visible == true &&
                (radioButton1.Checked || radioButton2.Checked) &&
                comboBox1.SelectedItem != null && txtboxAddress.Text != null && txtboxAddress.Text != "")
            {
                string fname = txtboxFname.Text;
                string lname = txtboxLname.Text;
                string uname = txtboxUname.Text;
                string password = txtboxCpassword.Text;
                string phone = txtboxPhone.Text;
                string email = txtboxEmail.Text;
                string area = comboBox1.SelectedItem.ToString();
                string address = txtboxAddress.Text;

                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(@"Data Source=DESKTOP-SGJ05OG;Initial Catalog=FoodCourtManagementSystem;Integrated Security=True");
                    conn.Open();

                    string query = "insert into UserInfo (Fname,Lname,UserName,[Password],Phone,Email,Area,[Address]) VALUES ('" + fname + "','" + lname + "','" + uname + "','" + password + "','" + phone + "','" + email + "','" + area + "','" + address + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    MessageBox.Show("Information saved");
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Please check the form again!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtboxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registraion_Load(object sender, EventArgs e)
        {

        }
    }
}
