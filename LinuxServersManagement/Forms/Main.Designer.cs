
namespace LinuxServerManagement
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_AddServer = new System.Windows.Forms.Button();
            this.listView_Servers = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_RemoveServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SSHCommand = new System.Windows.Forms.TextBox();
            this.btn_RunCommand = new System.Windows.Forms.Button();
            this.btn_CheckedAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Commands = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_RemoveCommand = new System.Windows.Forms.Button();
            this.btn_AddCommand = new System.Windows.Forms.Button();
            this.btn_ConnectOnSelecteds = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_DiretoryExampleCreateFolder = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_RunActions = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_DiretoryExample = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_AddSendFileAction = new System.Windows.Forms.Button();
            this.txt_LinuxFolderName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_FilesFoundCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_selectFolder = new System.Windows.Forms.Button();
            this.txt_FromFolderPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_add_Folder = new System.Windows.Forms.Button();
            this.txt_FolderName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_actionCount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_ClearActionList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddServer
            // 
            this.btn_AddServer.Location = new System.Drawing.Point(262, 260);
            this.btn_AddServer.Name = "btn_AddServer";
            this.btn_AddServer.Size = new System.Drawing.Size(111, 23);
            this.btn_AddServer.TabIndex = 1;
            this.btn_AddServer.Text = "Add New Server";
            this.btn_AddServer.UseVisualStyleBackColor = true;
            this.btn_AddServer.Click += new System.EventHandler(this.btn_AddServer_Click);
            // 
            // listView_Servers
            // 
            this.listView_Servers.HideSelection = false;
            this.listView_Servers.Location = new System.Drawing.Point(12, 27);
            this.listView_Servers.Name = "listView_Servers";
            this.listView_Servers.Size = new System.Drawing.Size(361, 227);
            this.listView_Servers.TabIndex = 2;
            this.listView_Servers.UseCompatibleStateImageBehavior = false;
            this.listView_Servers.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_Servers_ItemChecked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Servers:";
            // 
            // btn_RemoveServer
            // 
            this.btn_RemoveServer.Location = new System.Drawing.Point(131, 260);
            this.btn_RemoveServer.Name = "btn_RemoveServer";
            this.btn_RemoveServer.Size = new System.Drawing.Size(125, 23);
            this.btn_RemoveServer.TabIndex = 4;
            this.btn_RemoveServer.Text = "Remove Selected";
            this.btn_RemoveServer.UseVisualStyleBackColor = true;
            this.btn_RemoveServer.Click += new System.EventHandler(this.btn_RemoveServer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Execute (SHELL) Commands";
            // 
            // txt_SSHCommand
            // 
            this.txt_SSHCommand.Location = new System.Drawing.Point(379, 27);
            this.txt_SSHCommand.Multiline = true;
            this.txt_SSHCommand.Name = "txt_SSHCommand";
            this.txt_SSHCommand.Size = new System.Drawing.Size(409, 79);
            this.txt_SSHCommand.TabIndex = 6;
            // 
            // btn_RunCommand
            // 
            this.btn_RunCommand.Location = new System.Drawing.Point(623, 112);
            this.btn_RunCommand.Name = "btn_RunCommand";
            this.btn_RunCommand.Size = new System.Drawing.Size(165, 23);
            this.btn_RunCommand.TabIndex = 7;
            this.btn_RunCommand.Text = "Run on Selected Servers";
            this.btn_RunCommand.UseVisualStyleBackColor = true;
            this.btn_RunCommand.Click += new System.EventHandler(this.btn_RunCommand_Click);
            // 
            // btn_CheckedAll
            // 
            this.btn_CheckedAll.Location = new System.Drawing.Point(12, 260);
            this.btn_CheckedAll.Name = "btn_CheckedAll";
            this.btn_CheckedAll.Size = new System.Drawing.Size(113, 23);
            this.btn_CheckedAll.TabIndex = 8;
            this.btn_CheckedAll.Text = "Check/Uncheck All";
            this.btn_CheckedAll.UseVisualStyleBackColor = true;
            this.btn_CheckedAll.Click += new System.EventHandler(this.btn_CheckedAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select Command:";
            // 
            // cb_Commands
            // 
            this.cb_Commands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Commands.FormattingEnabled = true;
            this.cb_Commands.Location = new System.Drawing.Point(110, 19);
            this.cb_Commands.Name = "cb_Commands";
            this.cb_Commands.Size = new System.Drawing.Size(184, 28);
            this.cb_Commands.TabIndex = 11;
            this.cb_Commands.SelectedIndexChanged += new System.EventHandler(this.cb_Commands_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_RemoveCommand);
            this.groupBox1.Controls.Add(this.btn_AddCommand);
            this.groupBox1.Controls.Add(this.cb_Commands);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(388, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 142);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saved Commands";
            // 
            // btn_RemoveCommand
            // 
            this.btn_RemoveCommand.Location = new System.Drawing.Point(177, 113);
            this.btn_RemoveCommand.Name = "btn_RemoveCommand";
            this.btn_RemoveCommand.Size = new System.Drawing.Size(165, 23);
            this.btn_RemoveCommand.TabIndex = 13;
            this.btn_RemoveCommand.Text = "Remove Selected Command";
            this.btn_RemoveCommand.UseVisualStyleBackColor = true;
            this.btn_RemoveCommand.Click += new System.EventHandler(this.btn_RemoveCommand_Click);
            // 
            // btn_AddCommand
            // 
            this.btn_AddCommand.Location = new System.Drawing.Point(6, 113);
            this.btn_AddCommand.Name = "btn_AddCommand";
            this.btn_AddCommand.Size = new System.Drawing.Size(165, 23);
            this.btn_AddCommand.TabIndex = 12;
            this.btn_AddCommand.Text = "Add New Command";
            this.btn_AddCommand.UseVisualStyleBackColor = true;
            this.btn_AddCommand.Click += new System.EventHandler(this.btn_AddCommand_Click);
            // 
            // btn_ConnectOnSelecteds
            // 
            this.btn_ConnectOnSelecteds.Location = new System.Drawing.Point(379, 112);
            this.btn_ConnectOnSelecteds.Name = "btn_ConnectOnSelecteds";
            this.btn_ConnectOnSelecteds.Size = new System.Drawing.Size(180, 23);
            this.btn_ConnectOnSelecteds.TabIndex = 13;
            this.btn_ConnectOnSelecteds.Text = "Open SSH on Selected Servers";
            this.btn_ConnectOnSelecteds.UseVisualStyleBackColor = true;
            this.btn_ConnectOnSelecteds.Click += new System.EventHandler(this.btn_ConnectOnSelecteds_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ClearActionList);
            this.groupBox2.Controls.Add(this.lbl_actionCount);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1188, 357);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SFTP Actions";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_DiretoryExampleCreateFolder);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btn_RunActions);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btn_add_Folder);
            this.groupBox3.Controls.Add(this.txt_FolderName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(820, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 325);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Action";
            // 
            // lbl_DiretoryExampleCreateFolder
            // 
            this.lbl_DiretoryExampleCreateFolder.AutoSize = true;
            this.lbl_DiretoryExampleCreateFolder.Location = new System.Drawing.Point(89, 44);
            this.lbl_DiretoryExampleCreateFolder.Name = "lbl_DiretoryExampleCreateFolder";
            this.lbl_DiretoryExampleCreateFolder.Size = new System.Drawing.Size(10, 13);
            this.lbl_DiretoryExampleCreateFolder.TabIndex = 23;
            this.lbl_DiretoryExampleCreateFolder.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Final Directory:";
            // 
            // btn_RunActions
            // 
            this.btn_RunActions.Location = new System.Drawing.Point(142, 276);
            this.btn_RunActions.Name = "btn_RunActions";
            this.btn_RunActions.Size = new System.Drawing.Size(208, 43);
            this.btn_RunActions.TabIndex = 15;
            this.btn_RunActions.Text = "Run Actions on Selected Servers";
            this.btn_RunActions.UseVisualStyleBackColor = true;
            this.btn_RunActions.Click += new System.EventHandler(this.btn_RunActions_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_DiretoryExample);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btn_AddSendFileAction);
            this.groupBox4.Controls.Add(this.txt_LinuxFolderName);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lbl_FilesFoundCount);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btn_selectFolder);
            this.groupBox4.Controls.Add(this.txt_FromFolderPath);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(9, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 149);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Send Files From Folder";
            // 
            // lbl_DiretoryExample
            // 
            this.lbl_DiretoryExample.AutoSize = true;
            this.lbl_DiretoryExample.Location = new System.Drawing.Point(89, 118);
            this.lbl_DiretoryExample.Name = "lbl_DiretoryExample";
            this.lbl_DiretoryExample.Size = new System.Drawing.Size(10, 13);
            this.lbl_DiretoryExample.TabIndex = 21;
            this.lbl_DiretoryExample.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Final Directory:";
            // 
            // btn_AddSendFileAction
            // 
            this.btn_AddSendFileAction.Location = new System.Drawing.Point(239, 113);
            this.btn_AddSendFileAction.Name = "btn_AddSendFileAction";
            this.btn_AddSendFileAction.Size = new System.Drawing.Size(96, 23);
            this.btn_AddSendFileAction.TabIndex = 19;
            this.btn_AddSendFileAction.Text = "Add Action";
            this.btn_AddSendFileAction.UseVisualStyleBackColor = true;
            this.btn_AddSendFileAction.Click += new System.EventHandler(this.btn_AddSendFileAction_Click);
            // 
            // txt_LinuxFolderName
            // 
            this.txt_LinuxFolderName.Location = new System.Drawing.Point(123, 87);
            this.txt_LinuxFolderName.Name = "txt_LinuxFolderName";
            this.txt_LinuxFolderName.Size = new System.Drawing.Size(212, 20);
            this.txt_LinuxFolderName.TabIndex = 18;
            this.txt_LinuxFolderName.TextChanged += new System.EventHandler(this.txt_LinuxFolderName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Send To Linux Folder:";
            // 
            // lbl_FilesFoundCount
            // 
            this.lbl_FilesFoundCount.AutoSize = true;
            this.lbl_FilesFoundCount.Location = new System.Drawing.Point(76, 46);
            this.lbl_FilesFoundCount.Name = "lbl_FilesFoundCount";
            this.lbl_FilesFoundCount.Size = new System.Drawing.Size(13, 13);
            this.lbl_FilesFoundCount.TabIndex = 16;
            this.lbl_FilesFoundCount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Files Found:";
            // 
            // btn_selectFolder
            // 
            this.btn_selectFolder.Location = new System.Drawing.Point(245, 21);
            this.btn_selectFolder.Name = "btn_selectFolder";
            this.btn_selectFolder.Size = new System.Drawing.Size(90, 23);
            this.btn_selectFolder.TabIndex = 14;
            this.btn_selectFolder.Text = "Select Folder";
            this.btn_selectFolder.UseVisualStyleBackColor = true;
            this.btn_selectFolder.Click += new System.EventHandler(this.btn_selectFolder_Click);
            // 
            // txt_FromFolderPath
            // 
            this.txt_FromFolderPath.Location = new System.Drawing.Point(75, 23);
            this.txt_FromFolderPath.Name = "txt_FromFolderPath";
            this.txt_FromFolderPath.Size = new System.Drawing.Size(164, 20);
            this.txt_FromFolderPath.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Send From:";
            // 
            // btn_add_Folder
            // 
            this.btn_add_Folder.Location = new System.Drawing.Point(254, 19);
            this.btn_add_Folder.Name = "btn_add_Folder";
            this.btn_add_Folder.Size = new System.Drawing.Size(96, 23);
            this.btn_add_Folder.TabIndex = 13;
            this.btn_add_Folder.Text = "Add";
            this.btn_add_Folder.UseVisualStyleBackColor = true;
            this.btn_add_Folder.Click += new System.EventHandler(this.btn_add_Folder_Click);
            // 
            // txt_FolderName
            // 
            this.txt_FolderName.Location = new System.Drawing.Point(75, 21);
            this.txt_FolderName.Name = "txt_FolderName";
            this.txt_FolderName.Size = new System.Drawing.Size(173, 20);
            this.txt_FolderName.TabIndex = 1;
            this.txt_FolderName.TextChanged += new System.EventHandler(this.txt_FolderName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Create Folder:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(808, 325);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtConsole.Location = new System.Drawing.Point(6, 19);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(394, 250);
            this.txtConsole.TabIndex = 15;
            this.txtConsole.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtConsole);
            this.groupBox5.Location = new System.Drawing.Point(794, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(406, 275);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Console Log";
            // 
            // lbl_actionCount
            // 
            this.lbl_actionCount.AutoSize = true;
            this.lbl_actionCount.Location = new System.Drawing.Point(782, 3);
            this.lbl_actionCount.Name = "lbl_actionCount";
            this.lbl_actionCount.Size = new System.Drawing.Size(13, 13);
            this.lbl_actionCount.TabIndex = 18;
            this.lbl_actionCount.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(697, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Actions Count: ";
            // 
            // btn_ClearActionList
            // 
            this.btn_ClearActionList.Location = new System.Drawing.Point(640, 295);
            this.btn_ClearActionList.Name = "btn_ClearActionList";
            this.btn_ClearActionList.Size = new System.Drawing.Size(165, 43);
            this.btn_ClearActionList.TabIndex = 19;
            this.btn_ClearActionList.Text = "Clear Action List";
            this.btn_ClearActionList.UseVisualStyleBackColor = true;
            this.btn_ClearActionList.Click += new System.EventHandler(this.btn_ClearActionList_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 660);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_ConnectOnSelecteds);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_CheckedAll);
            this.Controls.Add(this.btn_RunCommand);
            this.Controls.Add(this.txt_SSHCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_RemoveServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView_Servers);
            this.Controls.Add(this.btn_AddServer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinuxServersManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AddServer;
        private System.Windows.Forms.ListView listView_Servers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_RemoveServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SSHCommand;
        private System.Windows.Forms.Button btn_RunCommand;
        private System.Windows.Forms.Button btn_CheckedAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Commands;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddCommand;
        private System.Windows.Forms.Button btn_RemoveCommand;
        private System.Windows.Forms.Button btn_ConnectOnSelecteds;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_add_Folder;
        private System.Windows.Forms.TextBox txt_FolderName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_selectFolder;
        private System.Windows.Forms.TextBox txt_FromFolderPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_FilesFoundCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_AddSendFileAction;
        private System.Windows.Forms.TextBox txt_LinuxFolderName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_RunActions;
        public System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbl_DiretoryExample;
        public System.Windows.Forms.Label lbl_DiretoryExampleCreateFolder;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label lbl_actionCount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_ClearActionList;
    }
}

