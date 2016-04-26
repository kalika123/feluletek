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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_ToDo add_new_todo = new Add_ToDo();
            add_new_todo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_ToDo edit_todo = new Edit_ToDo();
            edit_todo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
