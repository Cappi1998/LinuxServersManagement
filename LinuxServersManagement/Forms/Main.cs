using LinuxServerManagement.Forms;
using LinuxServerManagement.Models;
using LinuxServerManagement.Utils;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace LinuxServerManagement
{
    public partial class Main : Form
    {
        public static Dictionary<string, ConsoleLog> Consoles = new Dictionary<string, ConsoleLog>();
        public static Dictionary<string, SshClient> SshClients = new Dictionary<string, SshClient>();

        public static List<LinuxServerManagement.Models.Action> actions = new List<LinuxServerManagement.Models.Action>();


        public static Main _Main;
        public Main()
        {
            _Main = this;
            InitializeComponent();
            populateListView();
            populateComboBox();
        }

        public void populateComboBox()
        {
            cb_Commands.Items.Clear();
            Program.commands.ForEach(a =>{ cb_Commands.Items.Add(a.Name); });
            cb_Commands.Text = "Select To Load";
        }
        public void populateListView()
        {
            listView_Servers.Clear();

            listView_Servers.CheckBoxes = true;
            listView_Servers.View = View.Details;
            listView_Servers.Columns.Add("Identification", 100);
            listView_Servers.Columns.Add("Host", 130);
            listView_Servers.Columns.Add("User", 100);


            Program.servers =Program.servers.OrderBy(a => a.Identification).ToList();
            Program.servers.ForEach(a =>
            {
                listView_Servers.Items.Add(new ListViewItem(new string[] { a.Identification, a.Host, a.User }));
            });
        }

        public List<Server> GetCheckedServers()
        {
            List<Server> ServerList = new List<Server>();
            foreach(ListViewItem item in listView_Servers.CheckedItems)
            {
                var sv = Program.servers.Where(a => a.Identification == item.Text).FirstOrDefault();
                if (sv != null) ServerList.Add(sv);
            }
            return ServerList;
        }

        private void btn_AddServer_Click(object sender, EventArgs e)
        {
            AddServer frm = new AddServer();
            frm.ShowDialog();
            populateListView();
        }
        private void btn_AddCommand_Click(object sender, EventArgs e)
        {
            SavedCommands frm = new SavedCommands();
            frm.ShowDialog();
            populateComboBox();
        }

        private void btn_RemoveServer_Click(object sender, EventArgs e)
        {
            if (listView_Servers.CheckedItems.Count > 0)
            {
                string ServerIndentifications = $"";
                List<Server> svToRemove = new List<Server>();

                foreach(ListViewItem item in listView_Servers.CheckedItems)
                {
                    Server sv = Program.servers.Where(a => a.Identification == item.Text).FirstOrDefault();
                    if (sv != null)
                    { 
                        svToRemove.Add(sv);
                        ServerIndentifications += $"Indentificatio: {sv.Identification}{Environment.NewLine}";
                    }
                }

                if (MessageBox.Show($"{ServerIndentifications}{Environment.NewLine} Are you sure you want to remove from the list?", "Atention!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    svToRemove.ForEach(a => { Program.servers.Remove(a);});
                    ManageConfig.SaveConfig();
                    populateListView();
                }
            }
        }

        private void listView_Servers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            btn_RemoveServer.Text = $"Remove Selected ({listView_Servers.CheckedItems.Count})";
            btn_RunCommand.Text = $"Run on Selected Servers ({listView_Servers.CheckedItems.Count})";
            btn_ConnectOnSelecteds.Text = $"Open SSH on Selected Servers ({listView_Servers.CheckedItems.Count})";
            btn_RunActions.Text= $"Run Actions on Selected Servers ({listView_Servers.CheckedItems.Count})";
        }

        public bool CheckOrUnCheck = true;
        private void btn_CheckedAll_Click(object sender, EventArgs e)
        {
            if (CheckOrUnCheck)
            {
                foreach (ListViewItem item in listView_Servers.Items)
                {
                    item.Checked = true;
                }
                CheckOrUnCheck = false;
            }
            else
            {
                foreach (ListViewItem item in listView_Servers.Items)
                {
                    item.Checked = false;
                }
                CheckOrUnCheck = true;
            }
        }

        private void btn_UnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Servers.Items)
            {
                item.Checked = false;
            }
        }

        private void btn_RunCommand_Click(object sender, EventArgs e)
        {
            if (CheckString.CheckStringIsNull(txt_SSHCommand.Text, nameof(txt_SSHCommand))) return;

            var Servers = GetCheckedServers();

            foreach (var sv in Servers)
            {
                var sshClient = Get_SshClient(sv);//Create SSHClient

                if(sshClient != null) ShowFrmLog(sv);

                string[] lines = txt_SSHCommand.Text.Split(new string[] { Environment.NewLine },StringSplitOptions.None);

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    /* run your code here */

                    var frm = Consoles.Where(a => a.Key == sv.Host).FirstOrDefault().Value;

                    foreach(var command in lines)
                    {
                        frm.shellStream.WriteLine(command);
                        Thread.Sleep(100);
                    }

                }).Start();
                
            }
        }

        private void RunCommand(Server server, string command)
        {
            var sshClient = Get_SshClient(server);

            var cmd = sshClient.CreateCommand(command);

            var result = cmd.BeginExecute();

            using (var reader = new StreamReader(cmd.OutputStream, Encoding.UTF8, true, 1024, true))
            {
                while (!result.IsCompleted || !reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        if (Consoles.ContainsKey(server.Host))
                        {
                            var frm = Consoles[server.Host];
                            frm.txtConsole.Invoke((MethodInvoker)(() => frm.txtConsole.AppendText(line + Environment.NewLine)));
                        }
                        else
                        {
                            break;
                        }

                    }
                }
            }

            cmd.EndExecute(result);
        }

        public static SshClient Get_SshClient(Server server)
        {
            var existentClient = SshClients.Where(a => a.Key == server.Host).FirstOrDefault().Value;

            if(existentClient != null)
            {
                return existentClient;
            }
            else
            {
                SshClient client = new SshClient(server.Host, server.User, server.Pass);
                client.Connect();

                if (client.IsConnected)
                {
                    SshClients.Add(server.Host, client);
                    return client;
                }
                else { return null; }
            }
        }

        public static void ShowFrmLog(Server sv)
        {
            ConsoleLog frmExist = Consoles.Where(a => a.Key == sv.Host).FirstOrDefault().Value;

            if (frmExist == null)
            {
                ConsoleLog frm = new ConsoleLog();
                frm.Name = $"frm_{sv.Host}";
                frm.Text = $"ID: {sv.Identification} - Host: {sv.Host}";
                frm.server = sv;
                frm.Show();
                Consoles.Add(sv.Host, frm);
            }
        }

        private void cb_Commands_SelectedIndexChanged(object sender, EventArgs e)
        {
            var command = Program.commands.Where(a => a.Name == cb_Commands.SelectedItem.ToString()).FirstOrDefault();

            if(command != null)
            {
                txt_SSHCommand.Text = command.CommandList;
            }
        }

        private void btn_RemoveCommand_Click(object sender, EventArgs e)
        {
            if(cb_Commands.SelectedItem == null) return;

            var command = Program.commands.Where(a => a.Name == cb_Commands.SelectedItem.ToString()).FirstOrDefault();

            if (command != null)
            {
                if (MessageBox.Show($"are you sure you want to remove {command.Name}?", "Atention!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Program.commands.Remove(command);
                    txt_SSHCommand.Text = "";
                    ManageConfig.SaveConfig();
                    populateComboBox();
                }
            }
        }

        private void btn_ConnectOnSelecteds_Click(object sender, EventArgs e)
        {
            var Servers = GetCheckedServers();
            Servers.ForEach(a => { var sshClient = Get_SshClient(a); if (sshClient != null) ShowFrmLog(a); });
        }



        public void ReloadActionList()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("ActionType", typeof(string));
            dt.Columns.Add("FolderName", typeof(string));
            dt.Columns.Add("SendFilesFrom", typeof(string));
            dt.Columns.Add("SendFilesTo", typeof(string));


            foreach (var v in actions)
            {
                dt.Rows.Add(new object[] { v.ActionType, v.FolderName, v.SendFilesFrom, v.SendFilesTo });
            }

            dataGridView1.DataSource = dt;
            //lbl_actionCount.Text = actions.Count().ToString();
        }

        private void btn_add_Folder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FolderName.Text))
                return;

            Models.Action action = new Models.Action();
            action.ActionType = "CreateFolder";
            action.FolderName = txt_FolderName.Text;

            actions.Add(action);

            txt_FolderName.Text = "";

            ReloadActionList();
        }

        private void btn_selectFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                    txt_FromFolderPath.Text = fbd.SelectedPath;

                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    lbl_FilesFoundCount.Text = files.Length.ToString();
                }
            }
        }

        private void btn_AddSendFileAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_FromFolderPath.Text))
                return;

            if (string.IsNullOrWhiteSpace(txt_LinuxFolderName.Text))
                return;

            Models.Action action = new Models.Action();
            action.ActionType = "SendFilesFromFolder";
            action.SendFilesFrom = txt_FromFolderPath.Text;
            action.SendFilesTo = txt_LinuxFolderName.Text;

            actions.Add(action);

            txt_FolderName.Text = "";

            ReloadActionList();
        }

        private void btn_RunActions_Click(object sender, EventArgs e)
        {
            var Servers = GetCheckedServers();

            foreach(var sv in Servers)
            {
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    /* run your code here */
                    RunActionThread(sv);

                }).Start();
            }
        }


        public static void RunActionThread(Server sv)
        {
            Log.info($"{sv.Identification} - Start connection on server {sv.Host}");
            SftpClient sftpClient = new SftpClient(sv.Host, sv.User, sv.Pass);
            sftpClient.Connect();

            if (!sftpClient.IsConnected)
            {
                Log.error($"{sv.Identification} - Error to connect to server {sv.Host}");
                return;
            }

            foreach (var action in actions)
            {

                switch (action.ActionType)
                {
                    case "CreateFolder":
                        {

                            var folderName = $"{sftpClient.WorkingDirectory}/{action.FolderName}";
                            Log.info($"{sv.Identification} - Try create folder '{folderName}'");

                            if (!sftpClient.Exists(folderName))
                            {
                                sftpClient.CreateDirectory(folderName);
                            }

                            if (sftpClient.Exists(folderName))
                            {
                                Log.info($"{sv.Identification} - Folder '{folderName}' successfully created!");
                            }
                            else
                            {
                                Log.error($"{sv.Identification} - Failed to create folder '{folderName}'");
                            }


                            break;
                        }

                    case "SendFilesFromFolder":
                        {
                            if (!Directory.Exists(action.SendFilesFrom))
                            {
                                Log.error($"{sv.Identification} - Local folder not Found: {action.SendFilesFrom}");
                                continue;
                            }

                            string[] files = Directory.GetFiles(action.SendFilesFrom);

                            foreach (var file in files)
                            {
                                var folderName = $"{sftpClient.WorkingDirectory}/{action.SendFilesTo}/";
                                string filename = Path.GetFileName(file);

                                Log.info($"{sv.Identification} - Try send file '{filename}'");
                                var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
                                if (fileStream != null)
                                {
                                    //If you have a folder located at sftp://ftp.example.com/share
                                    //then you can add this like:
                                    sftpClient.UploadFile(fileStream, folderName + filename, null);
                                }

                            }

                            var directories = Directory.GetDirectories(action.SendFilesFrom);

                            foreach (var dir in directories)//Check SubFolders
                            {
                                string SubFolderName = new DirectoryInfo(dir).Name;
                                var folderName = $"{sftpClient.WorkingDirectory}/{action.SendFilesTo}/{SubFolderName}/";
                                Log.info($"{sv.Identification} - Try create folder '{folderName}'");
                                if (!sftpClient.Exists(folderName))
                                {
                                    sftpClient.CreateDirectory(folderName);
                                }

                                string[] filesSubFolder = Directory.GetFiles(dir);


                                foreach (var file in filesSubFolder)
                                {
                                    string filename = Path.GetFileName(file);

                                    Log.info($"{sv.Identification} - Try send file '{filename}'");
                                    var fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
                                    if (fileStream != null)
                                    {
                                        //If you have a folder located at sftp://ftp.example.com/share
                                        //then you can add this like:
                                        sftpClient.UploadFile(fileStream, folderName + filename, null);
                                    }

                                }
                            }

                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }
        }


        private void txt_LinuxFolderName_TextChanged(object sender, EventArgs e)
        {
            lbl_DiretoryExample.Text = $"/root/{txt_LinuxFolderName.Text}/";
        }

        private void txt_FolderName_TextChanged(object sender, EventArgs e)
        {
            lbl_DiretoryExampleCreateFolder.Text = $"/root/{txt_FolderName.Text}/";
        }
    }
}
