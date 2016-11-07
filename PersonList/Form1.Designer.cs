namespace PersonList
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
            this.RemoveAllButton = new System.Windows.Forms.Button();
            this.TabControlWindow.SuspendLayout();
            this.NewPersonTab.SuspendLayout();
            this.SearchTab.SuspendLayout();
            this.PersonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonListBox
            // 
            this.PersonListBox.ColumnWidth = 345;
            this.PersonListBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PersonListBox.FormattingEnabled = true;
            this.PersonListBox.HorizontalScrollbar = true;
            this.PersonListBox.Location = new System.Drawing.Point(28, 26);
            this.PersonListBox.Margin = new System.Windows.Forms.Padding(2);
            this.PersonListBox.MultiColumn = true;
            this.PersonListBox.Name = "PersonListBox";
            this.PersonListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PersonListBox.Size = new System.Drawing.Size(277, 212);
            this.PersonListBox.TabIndex = 5;
            this.PersonListBox.TabStop = false;
            // 
            // MaleButton
            // 
            this.MaleButton.AutoSize = true;
            this.MaleButton.Location = new System.Drawing.Point(28, 47);
            this.MaleButton.Margin = new System.Windows.Forms.Padding(2);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(48, 17);
            this.MaleButton.TabIndex = 19;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            // 
            // FemaleButton
            // 
            this.FemaleButton.AutoSize = true;
            this.FemaleButton.Location = new System.Drawing.Point(28, 69);
            this.FemaleButton.Margin = new System.Windows.Forms.Padding(2);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleButton.TabIndex = 20;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            // 
            // SortButton
            // 
            this.SortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortButton.Location = new System.Drawing.Point(38, 446);
            this.SortButton.Margin = new System.Windows.Forms.Padding(2);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(56, 20);
            this.SortButton.TabIndex = 6;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // MergeButton
            // 
            this.MergeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MergeButton.Location = new System.Drawing.Point(102, 446);
            this.MergeButton.Margin = new System.Windows.Forms.Padding(2);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(56, 20);
            this.MergeButton.TabIndex = 5;
            this.MergeButton.Text = "Merge";
            this.MergeButton.UseVisualStyleBackColor = true;
            this.MergeButton.Click += new System.EventHandler(this.MergeButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Location = new System.Drawing.Point(166, 446);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(56, 20);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TabControlWindow
            // 
            this.TabControlWindow.Controls.Add(this.NewPersonTab);
            this.TabControlWindow.Controls.Add(this.SearchTab);
            this.TabControlWindow.Location = new System.Drawing.Point(10, 10);
            this.TabControlWindow.Margin = new System.Windows.Forms.Padding(2);
            this.TabControlWindow.Name = "TabControlWindow";
            this.TabControlWindow.SelectedIndex = 0;
            this.TabControlWindow.Size = new System.Drawing.Size(338, 141);
            this.TabControlWindow.TabIndex = 0;
            this.TabControlWindow.TabStop = false;
            this.TabControlWindow.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlWindow_Selected);
            // 
            // NewPersonTab
            // 
            this.NewPersonTab.BackColor = System.Drawing.SystemColors.Control;
            this.NewPersonTab.Controls.Add(this.AddButton);
            this.NewPersonTab.Controls.Add(this.LastNameLabel);
            this.NewPersonTab.Controls.Add(this.FirstNameLabel);
            this.NewPersonTab.Controls.Add(this.LastNameTextBox);
            this.NewPersonTab.Controls.Add(this.FirstNameTextBox);
            this.NewPersonTab.Controls.Add(this.MaleButton);
            this.NewPersonTab.Controls.Add(this.FemaleButton);
            this.NewPersonTab.Location = new System.Drawing.Point(4, 22);
            this.NewPersonTab.Margin = new System.Windows.Forms.Padding(2);
            this.NewPersonTab.Name = "NewPersonTab";
            this.NewPersonTab.Padding = new System.Windows.Forms.Padding(2);
            this.NewPersonTab.Size = new System.Drawing.Size(330, 115);
            this.NewPersonTab.TabIndex = 0;
            this.NewPersonTab.Text = "New person";
            this.NewPersonTab.Enter += new System.EventHandler(this.NewPersonTab_Enter);
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Location = new System.Drawing.Point(244, 47);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(60, 20);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(193, 9);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 8;
            this.LastNameLabel.Text = "Last name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(29, 9);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(55, 13);
            this.FirstNameLabel.TabIndex = 7;
            this.FirstNameLabel.Text = "First name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(192, 25);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(113, 20);
            this.LastNameTextBox.TabIndex = 1;
            this.LastNameTextBox.Click += new System.EventHandler(this.LastNameTextBox_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(28, 25);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(113, 20);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.Click += new System.EventHandler(this.FirstNameTextBox_Click);
            // 
            // SearchTab
            // 
            this.SearchTab.BackColor = System.Drawing.SystemColors.Control;
            this.SearchTab.Controls.Add(this.FirstOrLastNameLabel);
            this.SearchTab.Controls.Add(this.SearchTextBox);
            this.SearchTab.Location = new System.Drawing.Point(4, 22);
            this.SearchTab.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(2);
            this.SearchTab.Size = new System.Drawing.Size(330, 115);
            this.SearchTab.TabIndex = 1;
            this.SearchTab.Text = "Search";
            this.SearchTab.Enter += new System.EventHandler(this.SearchTab_Enter);
            // 
            // FirstOrLastNameLabel
            // 
            this.FirstOrLastNameLabel.AutoSize = true;
            this.FirstOrLastNameLabel.Location = new System.Drawing.Point(29, 9);
            this.FirstOrLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstOrLastNameLabel.Name = "FirstOrLastNameLabel";
            this.FirstOrLastNameLabel.Size = new System.Drawing.Size(86, 13);
            this.FirstOrLastNameLabel.TabIndex = 1;
            this.FirstOrLastNameLabel.Text = "First or last name";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(28, 25);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(159, 20);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.Click += new System.EventHandler(this.SearchTextBox_Click);
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // PersonGroupBox
            // 
            this.PersonGroupBox.Controls.Add(this.PersonListBox);
            this.PersonGroupBox.Location = new System.Drawing.Point(10, 155);
            this.PersonGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.PersonGroupBox.Name = "PersonGroupBox";
            this.PersonGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.PersonGroupBox.Size = new System.Drawing.Size(336, 277);
            this.PersonGroupBox.TabIndex = 1;
            this.PersonGroupBox.TabStop = false;
            this.PersonGroupBox.Text = "Persons";
            // 
            // RemoveAllButton
            // 
            this.RemoveAllButton.Enabled = false;
            this.RemoveAllButton.Location = new System.Drawing.Point(242, 446);
            this.RemoveAllButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveAllButton.Name = "RemoveAllButton";
            this.RemoveAllButton.Size = new System.Drawing.Size(72, 20);
            this.RemoveAllButton.TabIndex = 3;
            this.RemoveAllButton.Text = "Remove All";
            this.RemoveAllButton.UseVisualStyleBackColor = true;
            this.RemoveAllButton.Click += new System.EventHandler(this.RemoveAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(357, 475);
            this.Controls.Add(this.RemoveAllButton);
            this.Controls.Add(this.TabControlWindow);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.MergeButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.PersonGroupBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person list";
            this.TabControlWindow.ResumeLayout(false);
            this.NewPersonTab.ResumeLayout(false);
            this.NewPersonTab.PerformLayout();
            this.SearchTab.ResumeLayout(false);
            this.SearchTab.PerformLayout();
            this.PersonGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.Button RemoveAllButton;
    }
}

