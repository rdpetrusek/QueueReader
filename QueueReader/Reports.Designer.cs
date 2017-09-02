namespace QueueReader
{
    partial class Reports
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
            this.groupingComboBox = new System.Windows.Forms.ComboBox();
            this.groupListBox = new System.Windows.Forms.ListBox();
            this.GroupValueTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // groupingComboBox
            // 
            this.groupingComboBox.FormattingEnabled = true;
            this.groupingComboBox.Location = new System.Drawing.Point(13, 13);
            this.groupingComboBox.Name = "groupingComboBox";
            this.groupingComboBox.Size = new System.Drawing.Size(121, 21);
            this.groupingComboBox.TabIndex = 0;
            this.groupingComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupListBox
            // 
            this.groupListBox.FormattingEnabled = true;
            this.groupListBox.HorizontalScrollbar = true;
            this.groupListBox.Location = new System.Drawing.Point(13, 41);
            this.groupListBox.Name = "groupListBox";
            this.groupListBox.Size = new System.Drawing.Size(304, 550);
            this.groupListBox.TabIndex = 1;
            this.groupListBox.SelectedIndexChanged += new System.EventHandler(this.groupListBox_SelectedIndexChanged);
            // 
            // GroupValueTextBox
            // 
            this.GroupValueTextBox.Location = new System.Drawing.Point(324, 41);
            this.GroupValueTextBox.Multiline = true;
            this.GroupValueTextBox.Name = "GroupValueTextBox";
            this.GroupValueTextBox.ReadOnly = true;
            this.GroupValueTextBox.Size = new System.Drawing.Size(802, 550);
            this.GroupValueTextBox.TabIndex = 2;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 601);
            this.Controls.Add(this.GroupValueTextBox);
            this.Controls.Add(this.groupListBox);
            this.Controls.Add(this.groupingComboBox);
            this.Name = "Reports";
            this.Text = "Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox groupingComboBox;
        private System.Windows.Forms.ListBox groupListBox;
        private System.Windows.Forms.TextBox GroupValueTextBox;
    }
}