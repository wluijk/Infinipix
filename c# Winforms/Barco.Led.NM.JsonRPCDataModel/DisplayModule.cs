using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco.Led.NM.JsonRPCDataModel
{
    public class DisplayModule
    {
        public string AutomaticIdentify { get; set; }
        public ModuleSourceType ModuleSource { get; set; }
        public enum ModuleSourceType { HDMI, SDI, TestPattern }
    }
}
