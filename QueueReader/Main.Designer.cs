namespace QueueReader
{
    partial class Main
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
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.queueListBox = new System.Windows.Forms.ListBox();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.extensionTextBox = new System.Windows.Forms.RichTextBox();
            this.queueLoadProgress = new System.Windows.Forms.ProgressBar();
            this.reportButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.serverNameTextBox.Location = new System.Drawing.Point(12, 497);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(209, 20);
            this.serverNameTextBox.TabIndex = 0;
            this.serverNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serverNameTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Machine Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.queueListBox.FormattingEnabled = true;
            this.queueListBox.HorizontalScrollbar = true;
            this.queueListBox.Location = new System.Drawing.Point(12, 13);
            this.queueListBox.Name = "queueListBox";
            this.queueListBox.Size = new System.Drawing.Size(291, 459);
            this.queueListBox.TabIndex = 3;
            this.queueListBox.SelectedIndexChanged += new System.EventHandler(this.queueListBox_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.HorizontalScrollbar = true;
            this.messageListBox.Location = new System.Drawing.Point(310, 13);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(349, 459);
            this.messageListBox.TabIndex = 4;
            this.messageListBox.SelectedIndexChanged += new System.EventHandler(this.messageListBox_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(666, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 459);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.messageTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Body";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.messageTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.Location = new System.Drawing.Point(-4, 0);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(815, 437);
            this.messageTextBox.TabIndex = 0;
            this.messageTextBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.extensionTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extension";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.extensionTextBox.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extensionTextBox.Location = new System.Drawing.Point(-4, 0);
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.ReadOnly = true;
            this.extensionTextBox.Size = new System.Drawing.Size(811, 433);
            this.extensionTextBox.TabIndex = 0;
            this.extensionTextBox.Text = "";
            // 
            // progressBar1
            // 
            this.queueLoadProgress.Location = new System.Drawing.Point(310, 497);
            this.queueLoadProgress.Name = "queueLoadProgress";
            this.queueLoadProgress.Size = new System.Drawing.Size(100, 23);
            this.queueLoadProgress.TabIndex = 9;
            this.queueLoadProgress.Visible = false;
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(417, 497);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 10;
            this.reportButton.Text = "Reports";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 529);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.queueLoadProgress);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.messageListBox);
            this.Controls.Add(this.queueListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverNameTextBox);
            this.Name = "Form1";
            this.Text = "Queue Reader!";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox queueListBox;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox extensionTextBox;
        private System.Windows.Forms.ProgressBar queueLoadProgress;
        private System.Windows.Forms.Button reportButton;
    }
}

