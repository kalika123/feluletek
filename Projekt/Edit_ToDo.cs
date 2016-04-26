using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    class Edit_ToDo : Form
    {
        private TextBox Title = new TextBox();
        private RichTextBox Description = new RichTextBox();

        private TextBox Description_txt = new TextBox();
        private TextBox Title_txt = new TextBox();

        private Button Save = new Button();

        private ComboBox priority = new ComboBox();
        private TextBox priority_txt = new TextBox();


        public Edit_ToDo()
        {
            InitializeComponent();

            this.Text = "Edit ToDo";


            String strTitle = "toEdit";
            String strDecription = "ghfgfg to    edit    mmmnnmnmn";


            int priorityIndex = 1;

            Title.Text = strTitle;
            Description.Text = strDecription;

            priority.SelectedIndex = priorityIndex;


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

            ///description
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
            this.Controls.Add(priority);

            ///button oke
            EventHandler handler = new EventHandler(Save_Click);
            Save.Text = "Save ToDo!";
            Save.Size = new Size(100, 30);
            Save.Location = new Point(220, 280);
            this.Controls.Add(Save);

            Save.Click += handler;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveNewToDo();
        }

        public void SaveNewToDo()
        {
            String strTitle = Title.Text;
            String strDecription = Description.Text;
            String strPriority = priority.GetItemText(priority.SelectedItem);
            int priorityIndex = priority.SelectedIndex;

            // Title.Text = strPriority;

            if (strDecription != "" && strTitle != "" && strPriority != "")
            {
                //return;
                this.Close();
            }
        }


    }
}
