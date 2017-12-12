namespace MailBlaster
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VariableOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailMessageTextBox = new System.Windows.Forms.TextBox();
            this.SendEmailButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.emailPreviewBrowser = new System.Windows.Forms.WebBrowser();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.VariableOne});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(329, 410);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CellContentClick);
            // 
            // Email
            // 
            this.Email.HeaderText = "EmailColumn";
            this.Email.Name = "Email";
            // 
            // VariableOne
            // 
            this.VariableOne.HeaderText = "Variable One";
            this.VariableOne.Name = "VariableOne";
            // 
            // emailMessageTextBox
            // 
            this.emailMessageTextBox.Location = new System.Drawing.Point(935, 40);
            this.emailMessageTextBox.MaxLength = 1000000;
            this.emailMessageTextBox.Multiline = true;
            this.emailMessageTextBox.Name = "emailMessageTextBox";
            this.emailMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.emailMessageTextBox.Size = new System.Drawing.Size(476, 316);
            this.emailMessageTextBox.TabIndex = 1;
            this.emailMessageTextBox.TextChanged += new System.EventHandler(this.emailMessageTextBox_TextChanged);
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.Location = new System.Drawing.Point(935, 428);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(476, 63);
            this.SendEmailButton.TabIndex = 2;
            this.SendEmailButton.Text = "Send Mail";
            this.SendEmailButton.UseVisualStyleBackColor = true;
            this.SendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(935, 362);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(476, 60);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // emailPreviewBrowser
            // 
            this.emailPreviewBrowser.Location = new System.Drawing.Point(357, 12);
            this.emailPreviewBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.emailPreviewBrowser.Name = "emailPreviewBrowser";
            this.emailPreviewBrowser.Size = new System.Drawing.Size(572, 479);
            this.emailPreviewBrowser.TabIndex = 4;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(996, 12);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(415, 22);
            this.subjectTextBox.TabIndex = 5;
            this.subjectTextBox.TextChanged += new System.EventHandler(this.subjectTextBox_TextChanged);
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(935, 15);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(55, 17);
            this.subjectLabel.TabIndex = 6;
            this.subjectLabel.Text = "Subject";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(12, 429);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(329, 62);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Load List";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 504);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.emailPreviewBrowser);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.SendEmailButton);
            this.Controls.Add(this.emailMessageTextBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mail Blaster";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn VariableOne;
        private System.Windows.Forms.TextBox emailMessageTextBox;
        private System.Windows.Forms.Button SendEmailButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.WebBrowser emailPreviewBrowser;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Button loadButton;
    }
}

