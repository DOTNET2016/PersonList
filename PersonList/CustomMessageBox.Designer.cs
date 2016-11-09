namespace PersonList
{
    partial class CustomMessageBox
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
            this.NedpictureBox = new System.Windows.Forms.PictureBox();
            this.label1Message = new System.Windows.Forms.Label();
            this.Okbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NedpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NedpictureBox
            // 
            this.NedpictureBox.Image = global::PersonList.Properties.Resources.Ned_Flanders;
            this.NedpictureBox.Location = new System.Drawing.Point(13, 13);
            this.NedpictureBox.Name = "NedpictureBox";
            this.NedpictureBox.Size = new System.Drawing.Size(272, 440);
            this.NedpictureBox.TabIndex = 0;
            this.NedpictureBox.TabStop = false;
            // 
            // label1Message
            // 
            this.label1Message.AutoSize = true;
            this.label1Message.BackColor = System.Drawing.Color.Transparent;
            this.label1Message.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Message.ForeColor = System.Drawing.Color.Black;
            this.label1Message.Location = new System.Drawing.Point(291, 122);
            this.label1Message.Name = "label1Message";
            this.label1Message.Size = new System.Drawing.Size(67, 27);
            this.label1Message.TabIndex = 1;
            this.label1Message.Text = "label1";
            this.label1Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Okbutton
            // 
            this.Okbutton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okbutton.ForeColor = System.Drawing.Color.Black;
            this.Okbutton.Location = new System.Drawing.Point(374, 398);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(159, 50);
            this.Okbutton.TabIndex = 2;
            this.Okbutton.Text = "Okaley Dokely!";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 460);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.label1Message);
            this.Controls.Add(this.NedpictureBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NedpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox NedpictureBox;
        private System.Windows.Forms.Label label1Message;
        private System.Windows.Forms.Button Okbutton;
    }
}