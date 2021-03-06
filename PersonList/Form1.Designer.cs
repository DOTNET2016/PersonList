﻿namespace PersonList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PersonListBox = new System.Windows.Forms.ListBox();
            this.MaleButton = new System.Windows.Forms.RadioButton();
            this.FemaleButton = new System.Windows.Forms.RadioButton();
            this.SortButton = new System.Windows.Forms.Button();
            this.MergeButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.TabControlWindow = new System.Windows.Forms.TabControl();
            this.NewPersonTab = new System.Windows.Forms.TabPage();
            this.AddButton = new System.Windows.Forms.Button();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchTab = new System.Windows.Forms.TabPage();
            this.FirstOrLastNameLabel = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.PersonGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabControlWindow.SuspendLayout();
            this.NewPersonTab.SuspendLayout();
            this.SearchTab.SuspendLayout();
            this.PersonGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonListBox
            // 
            this.PersonListBox.BackColor = System.Drawing.Color.SlateBlue;
            this.PersonListBox.ColumnWidth = 345;
            this.PersonListBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PersonListBox.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonListBox.ForeColor = System.Drawing.Color.White;
            this.PersonListBox.FormattingEnabled = true;
            this.PersonListBox.HorizontalScrollbar = true;
            this.PersonListBox.ItemHeight = 24;
            this.PersonListBox.Location = new System.Drawing.Point(35, 32);
            this.PersonListBox.Margin = new System.Windows.Forms.Padding(2);
            this.PersonListBox.Name = "PersonListBox";
            this.PersonListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PersonListBox.Size = new System.Drawing.Size(345, 244);
            this.PersonListBox.TabIndex = 5;
            this.PersonListBox.TabStop = false;
            // 
            // MaleButton
            // 
            this.MaleButton.AutoSize = true;
            this.MaleButton.Location = new System.Drawing.Point(35, 59);
            this.MaleButton.Margin = new System.Windows.Forms.Padding(2);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(61, 23);
            this.MaleButton.TabIndex = 19;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            // 
            // FemaleButton
            // 
            this.FemaleButton.AutoSize = true;
            this.FemaleButton.Location = new System.Drawing.Point(35, 86);
            this.FemaleButton.Margin = new System.Windows.Forms.Padding(2);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(77, 23);
            this.FemaleButton.TabIndex = 20;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            // 
            // SortButton
            // 
            this.SortButton.BackColor = System.Drawing.Color.White;
            this.SortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortButton.ForeColor = System.Drawing.Color.Black;
            this.SortButton.Location = new System.Drawing.Point(540, 558);
            this.SortButton.Margin = new System.Windows.Forms.Padding(2);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(70, 25);
            this.SortButton.TabIndex = 6;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = false;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // MergeButton
            // 
            this.MergeButton.BackColor = System.Drawing.Color.White;
            this.MergeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MergeButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MergeButton.Location = new System.Drawing.Point(658, 558);
            this.MergeButton.Margin = new System.Windows.Forms.Padding(2);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(70, 25);
            this.MergeButton.TabIndex = 5;
            this.MergeButton.Text = "Merge";
            this.MergeButton.UseVisualStyleBackColor = false;
            this.MergeButton.Click += new System.EventHandler(this.MergeButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.White;
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.Location = new System.Drawing.Point(773, 558);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(70, 25);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TabControlWindow
            // 
            this.TabControlWindow.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabControlWindow.Controls.Add(this.NewPersonTab);
            this.TabControlWindow.Controls.Add(this.SearchTab);
            this.TabControlWindow.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlWindow.Location = new System.Drawing.Point(540, 24);
            this.TabControlWindow.Margin = new System.Windows.Forms.Padding(2);
            this.TabControlWindow.Name = "TabControlWindow";
            this.TabControlWindow.SelectedIndex = 0;
            this.TabControlWindow.Size = new System.Drawing.Size(422, 176);
            this.TabControlWindow.TabIndex = 0;
            this.TabControlWindow.TabStop = false;
            this.TabControlWindow.SelectedIndexChanged += new System.EventHandler(this.TabControlWindow_SelectedIndexChanged);
            // 
            // NewPersonTab
            // 
            this.NewPersonTab.BackColor = System.Drawing.Color.Yellow;
            this.NewPersonTab.Controls.Add(this.AddButton);
            this.NewPersonTab.Controls.Add(this.LastNameLabel);
            this.NewPersonTab.Controls.Add(this.FirstNameLabel);
            this.NewPersonTab.Controls.Add(this.LastNameTextBox);
            this.NewPersonTab.Controls.Add(this.FirstNameTextBox);
            this.NewPersonTab.Controls.Add(this.MaleButton);
            this.NewPersonTab.Controls.Add(this.FemaleButton);
            this.NewPersonTab.Location = new System.Drawing.Point(4, 30);
            this.NewPersonTab.Margin = new System.Windows.Forms.Padding(2);
            this.NewPersonTab.Name = "NewPersonTab";
            this.NewPersonTab.Padding = new System.Windows.Forms.Padding(2);
            this.NewPersonTab.Size = new System.Drawing.Size(414, 142);
            this.NewPersonTab.TabIndex = 0;
            this.NewPersonTab.Text = "New person";
            this.NewPersonTab.Enter += new System.EventHandler(this.NewPersonTab_Enter);
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Location = new System.Drawing.Point(305, 59);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 25);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(241, 11);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(75, 19);
            this.LastNameLabel.TabIndex = 8;
            this.LastNameLabel.Text = "Last name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(36, 11);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(80, 19);
            this.FirstNameLabel.TabIndex = 7;
            this.FirstNameLabel.Text = "First name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(240, 31);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(140, 26);
            this.LastNameTextBox.TabIndex = 1;
            this.LastNameTextBox.Click += new System.EventHandler(this.LastNameTextBox_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(35, 31);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(140, 26);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.Click += new System.EventHandler(this.FirstNameTextBox_Click);
            // 
            // SearchTab
            // 
            this.SearchTab.BackColor = System.Drawing.Color.Yellow;
            this.SearchTab.Controls.Add(this.FirstOrLastNameLabel);
            this.SearchTab.Controls.Add(this.SearchTextBox);
            this.SearchTab.Location = new System.Drawing.Point(4, 30);
            this.SearchTab.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(2);
            this.SearchTab.Size = new System.Drawing.Size(414, 142);
            this.SearchTab.TabIndex = 1;
            this.SearchTab.Text = "Search";
            this.SearchTab.Enter += new System.EventHandler(this.SearchTab_Enter);
            // 
            // FirstOrLastNameLabel
            // 
            this.FirstOrLastNameLabel.AutoSize = true;
            this.FirstOrLastNameLabel.Location = new System.Drawing.Point(36, 11);
            this.FirstOrLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstOrLastNameLabel.Name = "FirstOrLastNameLabel";
            this.FirstOrLastNameLabel.Size = new System.Drawing.Size(127, 19);
            this.FirstOrLastNameLabel.TabIndex = 1;
            this.FirstOrLastNameLabel.Text = "First or last name";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(35, 31);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(198, 26);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Click);
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // PersonGroupBox
            // 
            this.PersonGroupBox.BackColor = System.Drawing.Color.SlateBlue;
            this.PersonGroupBox.Controls.Add(this.PersonListBox);
            this.PersonGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonGroupBox.ForeColor = System.Drawing.Color.White;
            this.PersonGroupBox.Location = new System.Drawing.Point(542, 204);
            this.PersonGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.PersonGroupBox.Name = "PersonGroupBox";
            this.PersonGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.PersonGroupBox.Size = new System.Drawing.Size(420, 346);
            this.PersonGroupBox.TabIndex = 1;
            this.PersonGroupBox.TabStop = false;
            this.PersonGroupBox.Text = "The people of Springfield";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.BackColor = System.Drawing.Color.White;
            this.ClearAllButton.Enabled = false;
            this.ClearAllButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearAllButton.Location = new System.Drawing.Point(872, 558);
            this.ClearAllButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(90, 25);
            this.ClearAllButton.TabIndex = 3;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = false;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PersonList.Properties.Resources.homer;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(962, 585);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(986, 610);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.TabControlWindow);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.MergeButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.PersonGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person list";
            this.TabControlWindow.ResumeLayout(false);
            this.NewPersonTab.ResumeLayout(false);
            this.NewPersonTab.PerformLayout();
            this.SearchTab.ResumeLayout(false);
            this.SearchTab.PerformLayout();
            this.PersonGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PersonListBox;
        private System.Windows.Forms.RadioButton MaleButton;
        private System.Windows.Forms.RadioButton FemaleButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button MergeButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TabControl TabControlWindow;
        private System.Windows.Forms.TabPage NewPersonTab;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TabPage SearchTab;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label FirstOrLastNameLabel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox PersonGroupBox;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

