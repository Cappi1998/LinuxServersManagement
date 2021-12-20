using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxServerManagement.Models
{
   public class Action
    {
        public string ActionType { get; set; }
        
        public string FolderName { get; set; }

        public string SendFilesFrom { get; set; }

        public string SendFilesTo { get; set; }
    }
}
