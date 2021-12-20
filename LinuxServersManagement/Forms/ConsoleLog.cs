using LinuxServerManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Action = System.Action;

namespace LinuxServerManagement.Forms
{
    public partial class ConsoleLog : Form
    {
        public Server server = new Server();
        public InteractiveShellStream shellStream = null;
        string LatestCommand = "";

        public ConsoleLog()
        {
            InitializeComponent();
        }

        private void ConsoleLog_Load(object sender, EventArgs e)
        {
            var sshClient = Main.SshClients.Where(a => a.Key == server.Host).FirstOrDefault().Value;

            shellStream = new InteractiveShellStream(sshClient.CreateShellStream("VT102", 80, 24, 800, 600, 2000));

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                while (true)
                {
                    LoopLog();
                    Thread.Sleep(100);
                }
                
            }).Start();
        }

        private void ConsoleLog_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btn_Clean_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
        }

        private void ConsoleLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the current connection to the server?", "Atention!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var sshClient = Main.SshClients.Where(a => a.Key == server.Host).FirstOrDefault().Value;

                if (sshClient != null)
                {
                    Main.SshClients.Remove(server.Host);
                    sshClient.Disconnect();
                    Main.Consoles.Remove(server.Host);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        void LoopLog()
        {
            Color color = Color.White;
            var msg = shellStream.ReadLine();

            if(LatestCommand != null){ if (msg.Contains(LatestCommand)) { color = Color.Green; LatestCommand = null; } }
            

            this.txtConsole.Invoke(new Action(() => this.txtConsole.SelectionColor = color));
            this.txtConsole.Invoke(new Action(() => this.txtConsole.AppendText(msg + Environment.NewLine)));
            this.txtConsole.Invoke(new Action(() => this.txtConsole.SelectionColor = this.txtConsole.ForeColor));
            this.txtConsole.Invoke(new Action(() => this.txtConsole.SelectionStart = this.txtConsole.Text.Length));
            this.txtConsole.Invoke(new Action(() => this.txtConsole.ScrollToCaret()));
        }

        private void btn_ExecuteCommand_Click(object sender, EventArgs e)
        {
            LatestCommand = (string)txt_Command.Text;
            shellStream.WriteLine(txt_Command.Text);
            txt_Command.Text = "";
        }
    }
}
