using LinuxServerManagement.Models;
using Renci.SshNet;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LinuxServerManagement
{
    public partial class AddServer : Form
    {
        public AddServer()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckString.CheckStringIsNull(txt_Host.Text, nameof(txt_Host))) return;
            else if (CheckString.CheckStringIsNull(txt_User.Text, nameof(txt_User))) return;
            else if (CheckString.CheckStringIsNull(txt_Pass.Text, nameof(txt_Pass))) return;
            else if (CheckString.CheckStringIsNull(txt_Identification.Text, nameof(txt_Identification))) return;

            var sameIdentification = Program.servers.Where(a => a.Identification == txt_Identification.Text).FirstOrDefault();
            if(sameIdentification != null)
            {
                MessageBox.Show($"There is already a server added with this name.", $"Error: same identification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var sameHost = Program.servers.Where(a => a.Host == txt_Host.Text).FirstOrDefault();
            if (sameHost != null)
            {
                MessageBox.Show($"There is already a server added with this host.", $"Error: same host", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Server sv = new Server { Identification = txt_Identification.Text, Host = txt_Host.Text, User = txt_User.Text, Pass = txt_Pass.Text };
            Program.servers.Add(sv);
            ManageConfig.SaveConfig();
            this.Close();
        }

        private void btn_TestConnection_Click(object sender, EventArgs e)
        {

            if (CheckString.CheckStringIsNull(txt_Host.Text, nameof(txt_Host))) return;
            else if (CheckString.CheckStringIsNull(txt_User.Text, nameof(txt_User))) return;
            else if (CheckString.CheckStringIsNull(txt_Pass.Text, nameof(txt_Pass))) return;

            var connectionInfo = new ConnectionInfo(txt_Host.Text, txt_User.Text, new PasswordAuthenticationMethod(txt_User.Text, txt_Pass.Text));

            using (var client = new SftpClient(connectionInfo))
            {
                try
                {
                    client.Connect();

                    if (client.IsConnected)
                    {
                        MessageBox.Show($"ServerVersion: {client.ConnectionInfo.ServerVersion}", $"Successfully Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Connection failed", $"Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error:{ex.Message}", $"Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
