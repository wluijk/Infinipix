using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco.Led.NM.JsonRPCDataModel
{
    /// <summary>
    /// SensorHost.cs - Represents some of the fields from a light sensor.
    /// 
    /// Author: ameja
    /// Date: 12/20/2017
    /// </summary>
    public class SensorHost
    {
        public SensorHost()
        {
            this.Temperatures = new List<Temperature>();
            this.LuminanceDevices = new List<LuminanceDevice>();
        }

        public bool IsOnline { get; set; }
        public List<Temperature> Temperatures { get; set; }
        public List<LuminanceDevice> LuminanceDevices { get; set; }
    }

    public class Temperature
    {
        public double Value { get; set; }
        public double Threshold { get; set; }
    }

    public class LuminanceDevice
    {
        public int ID { get; set; }
        public int Value { get; set; }
        public string SensorName { get; set; }
    }
}
