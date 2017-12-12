using System;
using System.Windows.Forms;


namespace MailBlaster
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            serverTextBox.Text = ServerSettings.Default.server;
            emailTextBox.Text = ServerSettings.Default.user;
            passwordTextBox.Text = ServerSettings.Default.password;
            displayNameTextBox.Text = ServerSettings.Default.displayName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(serverTextBox.Text!=null && emailTextBox.Text!=null&&passwordTextBox.Text!=null&&displayNameTextBox.Text!=null)
            {
                ServerSettings.Default.server = serverTextBox.Text;
                ServerSettings.Default.user = emailTextBox.Text;
                ServerSettings.Default.password = passwordTextBox.Text;
                ServerSettings.Default.displayName = displayNameTextBox.Text;

                ServerSettings.Default.Save();
            }
        }
    }
}
