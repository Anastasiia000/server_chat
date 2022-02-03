using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace server_chat {
    public partial class createNewRoom : Form {
        static public List<string> custumer = new List<string>();
        static public string nameOfRoom;
        public createNewRoom() {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++) 
                custumer.Add(checkedListBox1.CheckedItems[i].ToString());
            nameOfRoom = textBox1.Text;
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            ComboBox cb = (ComboBox)form1.Controls["queue"];
            cb.Items.Add(textBox1.Text);
            /*  Form1 form1 = (Form1)Application.OpenForms["Form1"];
             ComboBox cb = (ComboBox)form1.Controls["queue"];
             cb.Items.Add(textBox1.Text);
             Panel panel1 = (Panel)form1.Controls["panel2"];
              Button newRoom = new Button();

              panel1.Controls.Add(newRoom);

              newRoom.Text = textBox1.Text;
              newRoom.Width= 94;
              newRoom.Height = 29;
              newRoom.Location = new Point(11, 150);*/

            Close();
        }
    }
}
