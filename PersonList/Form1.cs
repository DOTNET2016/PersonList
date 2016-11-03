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

        List<Person> peopleList = new List<Person>();
        

        public Form1()
        {
            InitializeComponent();
            PersonListBox.DataSource = peopleList;//moved it here

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            //now the Add button wont do anything until ether male or female is checked
            if ((FirstNameTextBox.TextLength == 0) || (LastNameTextBox.TextLength == 0))
                MessageBox.Show("Please write your name");
            else if ((FemaleButton.Checked == false) && (MaleButton.Checked == false))
                MessageBox.Show("Please select either Male or Female");
            else if (FemaleButton.Checked)
            {
                peopleList.Add(new Female(FirstNameTextBox.Text, LastNameTextBox.Text, ""));
                ((CurrencyManager)PersonListBox.BindingContext[peopleList]).Refresh();//added this
            }
            else if (MaleButton.Checked)
            {
                peopleList.Add(new Male(FirstNameTextBox.Text, LastNameTextBox.Text, ""));
                ((CurrencyManager)PersonListBox.BindingContext[peopleList]).Refresh();//added this
            }
            //UpdateList();
            //PersonListBox.Items.Clear();

            //foreach (var a in peopleList)
            //    PersonListBox.Items.Add(a);
            //UpdateList();

            RemoveButton.Enabled = true;
        }
        private void UpdateList()
        {
            //PersonListBox.DataSource = peopleList;

            //((CurrencyManager)PersonListBox.BindingContext[peopleList]).Refresh();
            //PersonListBox.Refresh();
            //PersonListBox.Update();
        }

        //removes from the list box but not from the actual list!
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //PersonListBox.SelectionMode = SelectionMode.MultiExtended;
            //personList.Remove((Person)PersonListBox.SelectedValue);
            //Todo: make it also remove from the <Person> List
            //for (int i = PersonListBox.SelectedIndices.Count - 1; i >= 0; i--)
            //{
            //    PersonListBox.Items.RemoveAt(PersonListBox.SelectedIndices[i]);
            //    //PersonListBox.Items.RemoveAt(i);
            //}
            peopleList.Remove((Person)PersonListBox.SelectedValue);
            if (PersonListBox.Items.Count == 0)
            {
                RemoveButton.Enabled = false;
            }
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            peopleList.Clear();
            PersonListBox.Items.Clear();
        }

        #region textboxClearandSelectonEntry
        //lets discuss how these button clearing should work
        private void FirstNameTextBox_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Clear();
        }

        private void LastNameTextBox_Click(object sender, EventArgs e)
        {
            LastNameTextBox.Clear();
        }

        private void SearchTextBox_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
        }

        private void NewPersonTab_Enter(object sender, EventArgs e)
        {
            FirstNameTextBox.Select();
        }

        private void SearchTab_Enter(object sender, EventArgs e)
        {
            SearchTextBox.Select();
        }
        #endregion


    }
}
