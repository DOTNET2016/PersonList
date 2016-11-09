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
    /// <summary>
    /// Custom Message Box so that we can use it in all the classes througout the program.
    /// Also because we could then add our own image and functions.
    /// </summary>
    public partial class CustomMessageBox : Form
    {
        //variables
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
        //another custom Show() method to include a title on the box (otherwise it uses the class name as the title)
        //- decided to remove outer rim of box and so the title too. Looks nicer!
        public static string ShowBox(string textMessage, string textTitle)
        {
            newMessageBox = new CustomMessageBox();
            newMessageBox.label1Message.Text = textMessage;
            newMessageBox.Text = textTitle;
            newMessageBox.ShowDialog();
            return Button_id;
        }
        //button control
        private void Okbutton_Click(object sender, EventArgs e)
        {
            Button_id = "1";
            newMessageBox.Dispose();
        }
    }
}
