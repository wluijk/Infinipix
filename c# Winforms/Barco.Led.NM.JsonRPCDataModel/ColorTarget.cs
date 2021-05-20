using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Barco.Led.NM.JsonRPCDataModel
{
    public class ColorTarget
    {
        public string Name { get; set; }
        public Point Red { get; set; }
        public Point Green { get; set; }
        public Point Blue { get; set; }
    }
}
