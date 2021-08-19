using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCourtManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Application.Run(new Registraion());
            //Application.Run(new AccountIdentification());
            //Application.Run(new Homepage());
            //Application.Run(new Admin()); for admin side
            //Application.Run(new Adminpage());
            //Application.Run(new AddAdmin());
            //Application.Run(new Homepage());
            //Application.Run(new OrderList());
            //Application.Run(new Breakfast());
            //Application.Run(new Lunch());
            //Application.Run(new Shawarma());
            //Application.Run(new Pasta());
            //Application.Run(new Pizza());
            //Application.Run(new Burger());
            //Application.Run(new Dessert());
            //Application.Run(new Coffee());
            //Application.Run(new Cocktail());
            //Application.Run(new Dinner());
        }
    }
}
