using System;
using System.Collections.Generic;
using System.Text;

namespace TioRACLab.DosBox.Package
{

    public class PackageSetup
    {
        public string Name { get; set; }
        
        public string Description { get; set; }

        public Dictionary<string, string> Lang { get; set; }

        public string Cover { get; set; }
        
        public List<string> Images { get; set; }
        
        public List<Option> Options { get; set; }
    }
}
