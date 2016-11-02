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
            this.PersonListBox.ItemHeight = 16;
            this.PersonListBox.Location = new System.Drawing.Point(35, 32);
            this.PersonListBox.MultiColumn = true;
            this.PersonListBox.Name = "PersonListBox";
            this.PersonListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PersonListBox.Size = new System.Drawing.Size(345, 292);
            this.PersonListBox.TabIndex = 5;
            // 
            // MaleButton
            // 
            this.MaleButton.AutoSize = true;
            this.MaleButton.Location = new System.Drawing.Point(35, 59);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(59, 21);
            this.MaleButton.TabIndex = 2;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            this.MaleButton.CheckedChanged += new System.EventHandler(this.MaleButton_CheckedChanged);
            // 
            // FemaleButton
            // 
            this.FemaleButton.AutoSize = true;
            this.FemaleButton.Location = new System.Drawing.Point(35, 86);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(75, 21);
            this.FemaleButton.TabIndex = 3;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            // 
            // SortButton
            // 
            this.SortButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SortButton.Location = new System.Drawing.Point(47, 557);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(70, 25);
            this.SortButton.TabIndex = 8;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            // 
            // MergeButton
            // 
            this.MergeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MergeButton.Location = new System.Drawing.Point(127, 557);
            this.MergeButton.Name = "MergeButton";
            this.MergeButton.Size = new System.Drawing.Size(70, 25);
            this.MergeButton.TabIndex = 7;
            this.MergeButton.Text = "Merge";
            this.MergeButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveButton.Location = new System.Drawing.Point(208, 557);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(70, 25);
            this.RemoveButton.TabIndex = 6;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // TabControlWindow
            // 
            this.TabControlWindow.Controls.Add(this.NewPersonTab);
            this.TabControlWindow.Controls.Add(this.SearchTab);
            this.TabControlWindow.Location = new System.Drawing.Point(12, 12);
            this.TabControlWindow.Name = "TabControlWindow";
            this.TabControlWindow.SelectedIndex = 0;
            this.TabControlWindow.Size = new System.Drawing.Size(422, 176);
            this.TabControlWindow.TabIndex = 0;
            this.TabControlWindow.TabStop = false;
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
            this.NewPersonTab.Location = new System.Drawing.Point(4, 25);
            this.NewPersonTab.Name = "NewPersonTab";
            this.NewPersonTab.Padding = new System.Windows.Forms.Padding(3);
            this.NewPersonTab.Size = new System.Drawing.Size(414, 147);
            this.NewPersonTab.TabIndex = 0;
            this.NewPersonTab.Text = "New person";
            this.NewPersonTab.Enter += new System.EventHandler(this.NewPersonTab_Enter);
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.Location = new System.Drawing.Point(305, 59);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 25);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(241, 11);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(74, 17);
            this.LastNameLabel.TabIndex = 8;
            this.LastNameLabel.Text = "Last name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(36, 11);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(74, 17);
            this.FirstNameLabel.TabIndex = 7;
            this.FirstNameLabel.Text = "First name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(240, 31);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(140, 22);
            this.LastNameTextBox.TabIndex = 1;
            this.LastNameTextBox.Enter += new System.EventHandler(this.LastNameTextBox_Enter);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(35, 31);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(140, 22);
            this.FirstNameTextBox.TabIndex = 0;
            this.FirstNameTextBox.Enter += new System.EventHandler(this.FirstNameTextBox_Enter);
            // 
            // SearchTab
            // 
            this.SearchTab.BackColor = System.Drawing.SystemColors.Control;
            this.SearchTab.Controls.Add(this.FirstOrLastNameLabel);
            this.SearchTab.Controls.Add(this.SearchTextBox);
            this.SearchTab.Location = new System.Drawing.Point(4, 25);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.Padding = new System.Windows.Forms.Padding(3);
            this.SearchTab.Size = new System.Drawing.Size(414, 147);
            this.SearchTab.TabIndex = 1;
            this.SearchTab.Text = "Search";
            this.SearchTab.Enter += new System.EventHandler(this.SearchTab_Enter);
            // 
            // FirstOrLastNameLabel
            // 
            this.FirstOrLastNameLabel.AutoSize = true;
            this.FirstOrLastNameLabel.Location = new System.Drawing.Point(36, 11);
            this.FirstOrLastNameLabel.Name = "FirstOrLastNameLabel";
            this.FirstOrLastNameLabel.Size = new System.Drawing.Size(117, 17);
            this.FirstOrLastNameLabel.TabIndex = 1;
            this.FirstOrLastNameLabel.Text = "First or last name";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(35, 31);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(198, 22);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            // 
            // PersonGroupBox
            // 
            this.PersonGroupBox.Controls.Add(this.PersonListBox);
            this.PersonGroupBox.Location = new System.Drawing.Point(12, 194);
            this.PersonGroupBox.Name = "PersonGroupBox";
            this.PersonGroupBox.Size = new System.Drawing.Size(420, 346);
            this.PersonGroupBox.TabIndex = 1;
            this.PersonGroupBox.TabStop = false;
            this.PersonGroupBox.Text = "Persons";
            // 
            // RemoveAllButton
            // 
            this.RemoveAllButton.Location = new System.Drawing.Point(302, 557);
            this.RemoveAllButton.Name = "RemoveAllButton";
            this.RemoveAllButton.Size = new System.Drawing.Size(90, 25);
            this.RemoveAllButton.TabIndex = 9;
            this.RemoveAllButton.Text = "Remove All";
            this.RemoveAllButton.UseVisualStyleBackColor = true;
            this.RemoveAllButton.Click += new System.EventHandler(this.RemoveAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(446, 594);
            this.Controls.Add(this.RemoveAllButton);
            this.Controls.Add(this.TabControlWindow);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.MergeButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.PersonGroupBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
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

