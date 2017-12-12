using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MailBlaster
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            emailMessageTextBox.Text = ServerSettings.Default.emailHTML;
            subjectTextBox.Text = ServerSettings.Default.emailSubject;
            dataGridView1_CellContentClick(null, null);

            //Update Preview Box
            emailPreviewBrowser.DocumentText = emailMessageTextBox.Text;
            emailPreviewBrowser.Refresh();

        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value!=null||dataGridView1.CurrentRow.Cells[1].Value!=null)
            {
                string emailer = ServerSettings.Default.user;
                string displayName = ServerSettings.Default.displayName;
                string emailee = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                new SendMail(emailPreviewBrowser.DocumentText.ToString(), subjectTextBox.Text, emailer, emailee, displayName);
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.CurrentRow.Index + 1].Cells[dataGridView1.CurrentCell.ColumnIndex];
                dataGridView1_CellContentClick(null, null);
            }
        }

        private void emailMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            //Update Preview Box
            emailPreviewBrowser.DocumentText = emailMessageTextBox.Text;
            emailPreviewBrowser.Refresh();

            //Save email HTML for next load
            ServerSettings.Default.emailHTML = emailMessageTextBox.Text;
            ServerSettings.Default.Save();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = ".csv|CSV";
            DialogResult result = ofd.ShowDialog();
            if(result == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(ofd.FileName))
                {
                    while(reader.Peek()!=-1)
                    {
                        string line = reader.ReadLine();

                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                        IList<string> data = line.Split(new string[] {","},StringSplitOptions.RemoveEmptyEntries);
                        row.Cells[0].Value = data[0];
                        row.Cells[1].Value = data[1];
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows.Count>1&&emailMessageTextBox.Text.Contains("####")==true&&dataGridView1.CurrentRow.Index!= dataGridView1.Rows.Count-1)
            {
                emailPreviewBrowser.DocumentText = emailMessageTextBox.Text.ToString().Replace("####",dataGridView1.CurrentRow.Cells[1].Value.ToString());
            }
            else
            {
                emailPreviewBrowser.DocumentText = emailMessageTextBox.Text.ToString();
            }
        }

        private void subjectTextBox_TextChanged(object sender, EventArgs e)
        {
            ServerSettings.Default.emailSubject = subjectTextBox.Text;
            ServerSettings.Default.Save();
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {

        }
    }
}
