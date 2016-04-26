using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    class Add_ToDo : Form
    {
        private TextBox Title = new TextBox();
        private RichTextBox Description = new RichTextBox();

        private TextBox Description_txt = new TextBox();
        private TextBox Title_txt = new TextBox();

        private Button Add = new Button();

        private ComboBox priority = new ComboBox();
        private TextBox priority_txt = new TextBox();


        public Add_ToDo()
        {
            InitializeComponent();

            this.Text = "Add new ToDo";
        }

        private void InitializeComponent()
        {

            Size = new Size(370, 370);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;



            ////title
            Title_txt.Text = "Title of ToDo:";
            Title_txt.Size = new Size(110, 60);
            Title_txt.Location = new Point(10, 10);
            Title_txt.ReadOnly = true;
            Title_txt.BorderStyle = new BorderStyle();
            this.Controls.Add(Title_txt);

            Title.Size = new Size(200, 60);
            Title.Location = new Point(120, 10);
            this.Controls.Add(Title);
            //

            ///description
            ///

            Description_txt.Text = "Description of ToDo:";
            Description_txt.Size = new Size(110, 60);
            Description_txt.Location = new Point(10, 40);
            Description_txt.ReadOnly = true;
            Description_txt.BorderStyle = new BorderStyle();
            this.Controls.Add(Description_txt);

            Description.Size = new Size(200, 200);
            Description.Location = new Point(120, 40);

            this.Controls.Add(Description);
            ///            ComboBox

            priority_txt.Text = "Priority of ToDo:";
            priority_txt.Size = new Size(110, 60);
            priority_txt.Location = new Point(10, 250);
            priority_txt.ReadOnly = true;
            priority_txt.BorderStyle = new BorderStyle();
            this.Controls.Add(priority_txt);

            priority.Location = new Point(120, 250);
            priority.Size = new Size(200, 20);
            priority.Items.Add("Low");
            priority.Items.Add("Medium");
            priority.Items.Add("High");
            priority.SelectedIndex = 0;
            this.Controls.Add(priority);

            ///button oke
            EventHandler handler = new EventHandler(Add_Click);
            Add.Text = "Add ToDo!";
            Add.Size = new Size(100, 30);
            Add.Location = new Point(220, 280);
            this.Controls.Add(Add);

            Add.Click += handler;

        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddNewToDo();
        }

        public void AddNewToDo()
        {
            String strTitle = Title.Text;
            String strDecription = Description.Text;
            String strPriority = priority.GetItemText(priority.SelectedItem);

            // Title.Text = strPriority;

            if (strDecription != "" && strTitle != "" && strPriority != "")
            {
                //return;
                this.Close();
            }

        }


    }
}
