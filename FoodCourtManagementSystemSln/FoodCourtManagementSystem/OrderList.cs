using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCourtManagementSystem
{
    public partial class OrderList : Form
    {
        public OrderList(string name)
        {
            InitializeComponent();

            lblUname.Text = name;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Breakfast aa = new Breakfast(lblUname.Text);
            aa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lunch aa = new Lunch(lblUname.Text);
            aa.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shawarma aa = new Shawarma(lblUname.Text);
            aa.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pasta aa = new Pasta(lblUname.Text);
            aa.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pizza aa = new Pizza(lblUname.Text);
            aa.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Burger aa = new Burger(lblUname.Text);
            aa.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dessert aa = new Dessert(lblUname.Text);
            aa.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cocktail aa = new Cocktail(lblUname.Text);
            aa.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Dinner aa = new Dinner(lblUname.Text);
            aa.Show();
        }

        private void OrderList_Load(object sender, EventArgs e)
        {

        }
    }
}
