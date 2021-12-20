using LinuxServerManagement.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LinuxServerManagement.Forms
{
    public partial class SavedCommands : Form
    {
        public SavedCommands()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckString.CheckStringIsNull(txt_Name.Text, nameof(txt_Name))) return;
            else if (CheckString.CheckStringIsNull(txt_Commands.Text, nameof(txt_Commands))) return;

            Commands cm = new Commands {Name=txt_Name.Text, CommandList=txt_Commands.Text };

            var exitent = Program.commands.Where(a => a.Name == cm.Name).FirstOrDefault();
            if (exitent != null)
            {
                MessageBox.Show($"There is already a commands added with this name.", $"Error: same identification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Program.commands.Add(cm);
                ManageConfig.SaveConfig();
                this.Close();
            }
        }
    }
}
