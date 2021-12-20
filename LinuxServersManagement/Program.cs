using LinuxServerManagement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LinuxServerManagement
{
    static class Program
    {

        public static string Base_Diretory = Directory.GetCurrentDirectory();
        public static string Servers_File = Path.Combine(Base_Diretory, "Server.json");
        public static string Commands_FilePath = Path.Combine(Base_Diretory, "Commands.json");
        public static List<Server> servers = new List<Server>();
        public static List<Commands> commands = new List<Commands>();

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ManageConfig.LoadConfig();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
