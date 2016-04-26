using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DAL dal = DAL.getInstance();
            if (!dal.isConnected())
            {
                MessageBox.Show("NEW CONNECT");
                dal.connect();
            }

            dal.getTasks(1);

            }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
