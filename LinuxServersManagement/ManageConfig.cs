using LinuxServerManagement.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace LinuxServerManagement
{
    class ManageConfig
    {
        public static void LoadConfig()
        {
            if (File.Exists(Program.Servers_File))
            {
                var Servers = JsonConvert.DeserializeObject<List<Server>>(File.ReadAllText(Program.Servers_File));
                if(Servers != null || Servers.Count > 0)
                {
                    Program.servers = Servers;
                }
            }
            else
            {
                List<Server> server = new List<Server>();
                File.WriteAllText(Program.Servers_File, JsonConvert.SerializeObject(server));
            }

            if (File.Exists(Program.Commands_FilePath))
            {
                var CommandsList = JsonConvert.DeserializeObject<List<Commands>>(File.ReadAllText(Program.Commands_FilePath));
                if (CommandsList != null || CommandsList.Count > 0)
                {
                    Program.commands = CommandsList;
                }
            }
            else
            {
                List<Commands> CommandsList = new List<Commands>();
                File.WriteAllText(Program.Commands_FilePath, JsonConvert.SerializeObject(CommandsList));
            }

        }

        public static void SaveConfig()
        {
            File.WriteAllText(Program.Servers_File, JsonConvert.SerializeObject(Program.servers));
            File.WriteAllText(Program.Commands_FilePath, JsonConvert.SerializeObject(Program.commands));
        }
    }
}
