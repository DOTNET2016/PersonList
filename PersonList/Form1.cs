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
    public partial class Form1 : Form
    {
        
        // Male = Mr
        // Female (un-married) = Ms
        // Female (married) = Mrs
        // Child (girl) = Miss
        // Child (boy) = Master

        List<Person> personList = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            personList.Add(new Male(FirstNameTextBox.Text, LastNameTextBox.Text));
            foreach (var a in personList)
            {
                PersonListBox.Items.Add(a);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //PersonListBox.SelectionMode = SelectionMode.MultiExtended;

            for (int i = PersonListBox.SelectedIndices.Count-1; i >= 0; i--)//removes from the list box but not from the actual list!
            {
                PersonListBox.Items.RemoveAt(PersonListBox.SelectedIndices[i]);
               
            }
           
        }
    }
}
