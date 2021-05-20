using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco.Led.NM.JsonRPCDataModel
{
    /// <summary>
    /// TestPattern.cs - Represents the settings that can be applied to get a certain test pattern.
    /// 
    /// Author: ameja
    /// Date: 12/20/2017
    /// </summary>
    public class TestPattern
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public bool Movement { get; set; }
        public string Direction { get; set; }
        public string SelectedTestPattern { get; set; }
        public List<string> AvailableTestPatterns { get; set; }
        public List<string> ValidDirections { get; set; }

        public bool IsEmpty()
        {
            if (Red == 0 && Green == 0 && Blue == 0 && string.IsNullOrEmpty(Direction) && string.IsNullOrEmpty(SelectedTestPattern))
                return true;
            else
                return false;
        }
    }
}
