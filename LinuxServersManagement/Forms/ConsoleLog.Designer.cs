
namespace LinuxServerManagement.Forms
{
    partial class ConsoleLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleLog));
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.btn_ExecuteCommand = new System.Windows.Forms.Button();
            this.txt_Command = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsole.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtConsole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtConsole.Location = new System.Drawing.Point(12, 38);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(690, 385);
            this.txtConsole.TabIndex = 12;
            this.txtConsole.Text = "";
            // 
            // btn_Clean
            // 
            this.btn_Clean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clean.Location = new System.Drawing.Point(602, 9);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(97, 23);
            this.btn_Clean.TabIndex = 13;
            this.btn_Clean.Text = "Clean Console";
            this.btn_Clean.UseVisualStyleBackColor = true;
            this.btn_Clean.Click += new System.EventHandler(this.btn_Clean_Click);
            // 
            // btn_ExecuteCommand
            // 
            this.btn_ExecuteCommand.Location = new System.Drawing.Point(383, 9);
            this.btn_ExecuteCommand.Name = "btn_ExecuteCommand";
            this.btn_ExecuteCommand.Size = new System.Drawing.Size(75, 23);
            this.btn_ExecuteCommand.TabIndex = 1;
            this.btn_ExecuteCommand.Text = "Execute";
            this.btn_ExecuteCommand.UseVisualStyleBackColor = true;
            this.btn_ExecuteCommand.Click += new System.EventHandler(this.btn_ExecuteCommand_Click);
            // 
            // txt_Command
            // 
            this.txt_Command.Location = new System.Drawing.Point(117, 11);
            this.txt_Command.Name = "txt_Command";
            this.txt_Command.Size = new System.Drawing.Size(260, 20);
            this.txt_Command.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Execute Command:";
            // 
            // ConsoleLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Command);
            this.Controls.Add(this.btn_ExecuteCommand);
            this.Controls.Add(this.btn_Clean);
            this.Controls.Add(this.txtConsole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsoleLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsoleLog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsoleLog_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConsoleLog_FormClosed);
            this.Load += new System.EventHandler(this.ConsoleLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.Button btn_ExecuteCommand;
        private System.Windows.Forms.TextBox txt_Command;
        private System.Windows.Forms.Label label1;
    }
}