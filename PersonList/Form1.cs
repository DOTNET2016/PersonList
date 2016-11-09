﻿using System;
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
        MissionControl m1 = new MissionControl();
        List<Person> peopleList = new List<Person>();

        public Form1()
        {
            InitializeComponent();
            PersonListBox.DataSource = peopleList;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            m1.FirstName = FirstNameTextBox.Text;
            m1.LastName = LastNameTextBox.Text;

            //now the Add button wont do anything until ether male or female is checked
            if ((FemaleButton.Checked == false) && (MaleButton.Checked == false))
                CustomMessageBox.ShowBox("Please select either Male or Female\n\nNobody Selected!");
            else if (FemaleButton.Checked && m1.CheckInput())
            {
                peopleList.Add(new Female(2, FirstNameTextBox.Text, LastNameTextBox.Text));
                RemoveButton.Enabled = true;
                ClearAllButton.Enabled = true;
            }
            else if (MaleButton.Checked && m1.CheckInput())
            {
                peopleList.Add(new Male(1, FirstNameTextBox.Text, LastNameTextBox.Text));
                RemoveButton.Enabled = true;
                ClearAllButton.Enabled = true;
            }
            else
            {
                CustomMessageBox.ShowBox("Everybody needs a name...\n\nWhere's yours?");
            }
            UpdateListBox();
        }

        //Removes item from list
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            for (var i = PersonListBox.SelectedIndices.Count - 1; i >= 0; i--)
                ((CurrencyManager)PersonListBox.BindingContext[peopleList]).RemoveAt(PersonListBox.SelectedIndices[i]);

            UpdateListBox();
            UpdateButtons();
        }

        //Clears the list
        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            peopleList.Clear();
            UpdateListBox();
            UpdateButtons();
        }

        //this will update the listbox when called
        private void UpdateListBox()
        {
            ((CurrencyManager)PersonListBox.BindingContext[peopleList]).Refresh();
            PersonListBox.ClearSelected();
        }

        //When called it will update the buttons
        private void UpdateButtons()
        {
            if (peopleList.Count == 0)
            {
                RemoveButton.Enabled = false;
                ClearAllButton.Enabled = false;
                MaleButton.Checked = false;
                FemaleButton.Checked = false;
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                SearchTextBox.Clear();
            }
            else
            {
                RemoveButton.Enabled = true;
                ClearAllButton.Enabled = true;
            }
        }

        //Sorts the list
        private void SortButton_Click(object sender, EventArgs e)
        {
            peopleList.Sort();
            UpdateListBox();
        }

        //Select two items in the list and merge them, the outcome will be a child
        private void MergeButton_Click(object sender, EventArgs e)
        {
            if (PersonListBox.SelectedItems.Count >= 3 || PersonListBox.SelectedItems.Count < 2)
            {
                CustomMessageBox.ShowBox("Only two people make a baby!\n\nDo the maths..");
                PersonListBox.ClearSelected();
            }
            else if ((Person)PersonListBox.SelectedItems[0] == (Person)PersonListBox.SelectedItems[1])
            {
                CustomMessageBox.ShowBox("You need a boy and a girl to\nmake babies!\n\nDidn't they teach you anything\nat school?");
                PersonListBox.ClearSelected();
            }
           else if (PersonListBox.SelectedItems.Count == 2)
            {
                m1.MakeABaby((Person)PersonListBox.SelectedItems[0], (Person)PersonListBox.SelectedItems[1]);
                peopleList.Add(m1.NewBaby);
                CustomMessageBox.ShowBox("Hi-dilly-ho, neighborinhos!\n\nI've done everything the Bible says,\neven the stuff that contradicts \nthe other stuff.\n\nAnd now we're having a baby!");
            }           
            UpdateListBox();
        }

        #region LiveSearch
        /// <summary>
        /// Live search is here!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            // known cevat:
            // cant remove people in the list while searching.
            PersonListBox.DataSource = new BindingList<Person>(peopleList.Where(m => m.ToString().ToLower().Contains(SearchTextBox.Text.ToLower())).ToList());

            PersonListBox.ClearSelected();
            UpdateListBox();
        }

        //When going back to "new person" the data source will be set back to old list
        private void TabControlWindow_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonListBox.DataSource = peopleList;
        }
        #endregion

        #region textboxClearandSelectionEntry
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
            SearchTextBox.Clear();
        }
        #endregion
    }
}
