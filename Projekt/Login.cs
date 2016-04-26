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

namespace Projekt
{
    public partial class Login : Form
    {

        private DAL db = null;

        public Login()
        {
            InitializeComponent();
            db = DAL.getInstance();
            if (!db.connect()) MessageBox.Show("Could not connect to database!");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usname = username.Text;
            string pword = password.Text;
            int id = db.getUser(usname, pword);
            Console.WriteLine("ID : " + id);
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
