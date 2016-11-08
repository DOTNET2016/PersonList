using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonList
{
    public partial class CustomMessageBox : Form
    {
        static CustomMessageBox newMessageBox;
        static string Button_id;

        public CustomMessageBox()
        {
            InitializeComponent();
        }

        private void CustomMessageBox_Load(object sender, EventArgs e)
        {

        }
        //custom Show() method for the message box
        public static string ShowBox(string textMessage)
        {
            newMessageBox = new CustomMessageBox();
            newMessageBox.label1Message.Text = textMessage;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        public static string ShowBox(string textMessage, string textTitle)
        {
            newMessageBox = new CustomMessageBox();
            newMessageBox.label1Message.Text = textMessage;
            newMessageBox.Text = textTitle;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            Button_id = "1";
            newMessageBox.Dispose();
        }
    }
}
