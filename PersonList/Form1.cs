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
            m1.FirstName = FirstNameTextBox.Text;
            m1.LastName = LastNameTextBox.Text;
            //now the Add button wont do anything until ether male or female is checked
            if ((FemaleButton.Checked == false) && (MaleButton.Checked == false))
                MessageBox.Show("Please select either Male or Female");
            else if (FemaleButton.Checked && m1.CheckInput())
            {
                peopleList.Add(new Female(FirstNameTextBox.Text, LastNameTextBox.Text, ""));
                RemoveButton.Enabled = true;
                RemoveAllButton.Enabled = true;
            }
            else if (MaleButton.Checked && m1.CheckInput())
            {
                peopleList.Add(new Male(FirstNameTextBox.Text, LastNameTextBox.Text, ""));
                RemoveButton.Enabled = true;
                RemoveAllButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please enter a name");
            }
            UpdateListBox();
            PersonListBox.ClearSelected();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            for (var i = PersonListBox.SelectedIndices.Count - 1; i >= 0; i--)
                ((CurrencyManager)PersonListBox.BindingContext[peopleList]).RemoveAt(PersonListBox.SelectedIndices[i]);

            UpdateListBox();
            UpdateButtons();
            PersonListBox.ClearSelected();
        }

        private void RemoveAllButton_Click(object sender, EventArgs e)
        {
            peopleList.Clear();
            UpdateListBox();
            UpdateButtons();
            PersonListBox.ClearSelected();
        }

        private void UpdateListBox()
        {
            ((CurrencyManager)PersonListBox.BindingContext[peopleList]).Refresh();
        }
        private void UpdateButtons()
        {
            if (PersonListBox.Items.Count == 0)
            {
                RemoveButton.Enabled = false;
                RemoveAllButton.Enabled = false;
                MaleButton.Checked = false;
                FemaleButton.Checked = false;
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
            }
            else
            {
                RemoveButton.Enabled = true;
                RemoveAllButton.Enabled = true;
            }
        }

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
        }
        #endregion

        private void SortButton_Click(object sender, EventArgs e)
        {
            peopleList.Sort();
            UpdateListBox();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
