using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco.Led.NM.JsonRPCDataModel
{
    /// <summary>
    /// PowerBox.cs - Contains information about a power box which is attached to a display system.
    /// 
    /// Author: ameja
    /// Date: 12/20/2017
    /// </summary>
    public class PowerBox
    {
        public bool IsOnline { get; set; }
        public string CurrentState { get; set; }
        public string ProductName { get; set; }
    }
}
