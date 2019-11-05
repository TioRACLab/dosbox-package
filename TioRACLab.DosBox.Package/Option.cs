using System;
using System.Collections.Generic;
using System.Text;

namespace TioRACLab.DosBox.Package
{
    public class Option
    {
        public string Name { get; set; }
        
        public string Description { get; set; }

        public Dictionary<string, string> Lang { get; set; }

        public List<string> Configs { get; set; }
        
        public bool? DefaultEntry { get; set; }
        
        public bool? MultiplayerEntry { get; set; }
    }
}
