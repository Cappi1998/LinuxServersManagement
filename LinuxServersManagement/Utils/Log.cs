using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxServerManagement.Utils
{
    class Log
    {
        Main _Main = new Main();

        public static void info(string msg)
        {
            msg = DateTime.Now + " - " + msg;
            global_void_Log(msg, Color.LimeGreen);
        }

        public static void error(string msg, Exception ex = null)
        {
            msg = DateTime.Now + " - " + msg;
            global_void_Log(msg, Color.Red);

            if(ex != null) File.AppendAllText("Error.txt", ex + "\n");
        }
        public static void global_void_Log(string msg, Color color)
        {
            Main._Main.txtConsole.Invoke(new Action(() => Main._Main.txtConsole.SelectionColor = color));
            Main._Main.txtConsole.Invoke(new Action(() => Main._Main.txtConsole.AppendText(msg + Environment.NewLine)));
            Main._Main.txtConsole.Invoke(new Action(() => Main._Main.txtConsole.SelectionColor = Main._Main.txtConsole.ForeColor));
            Main._Main.txtConsole.Invoke(new Action(() => Main._Main.txtConsole.SelectionStart = Main._Main.txtConsole.Text.Length));
            Main._Main.txtConsole.Invoke(new Action(() => Main._Main.txtConsole.ScrollToCaret()));

            try
            {
                File.AppendAllText("log.txt", msg + "\n");
            }
            catch
            {

            }

        }
    }
}
