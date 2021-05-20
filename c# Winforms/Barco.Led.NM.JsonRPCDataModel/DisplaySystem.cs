using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Barco.Led.NM.JsonRPCDataModel
{
    /// <summary>
    /// DisplaySystem.cs - The resource returned to users using the JsonRPC API.  Represents the DisplaySystem resource and is  meant to be used as kind of a 
    /// RESTful service resource. This means that we can return a whole representation of the display system to the user and the user can set some parameters
    /// and send the whole representation back to the service in a POST request. The data model will be changed on whatever the user passes in, similar to passing in a 
    /// resource via a POST request in a REST-based web service.
    /// 
    /// Possible representation as of now:
    ///
    /// ActiveSource
    /// AvailableSources
    /// ColorTemperature
    /// ColorTempRange
    /// Gamma
    /// ValidGammaRange
    /// Name
    /// Luminance
    /// ImageProcessingParameters {
    ///    ["hdmi": {
    ///         "brightness": ..,
    ///         "contrast": ...,
    ///         ...
    ///        },
    ///     "sdi": {
    ///         "brightness": ..,
    ///         "contrast": ...,
    ///         ...
    ///      }
    ///    ]
    /// },
    /// DisplayProcessors: [
    /// ],
    /// link: {
    ///   "rel": "DisplayProcessors",
    ///   "href": <getdisplayprocessorsJsonRPCmethod>,
    /// }
    /// ,
    /// GroupId: ..,
    /// DeviceGroup : {
    ///    "rel": "DeviceGroup",
    ///    "href": <getdevicegroupJsonRPCMethod>
    /// }
    /// Author: ameja
    /// Date: 11/22/2017
    /// </summary>
    public class DisplaySystem
    {
        public DisplaySystem()
        {
            this.ColorTemperature = new ColorTemperature();
            this.Gamma = new Gamma();
            this.Power = new Power();
            this.TestPattern = new TestPattern();
            this.SensorHosts = new List<SensorHost>();
            this.PowerBoxes = new List<PowerBox>();
        }

        public string ID { get; set; }
        public string ActiveSource { get; set; }
        public string Luminance { get; set; }
        public ColorTemperature ColorTemperature { get; set; }
        public Gamma Gamma { get; set; }
        public string Name { get; set; }
        public List<string> AvailableSources { get; set; }
        public Point SourceMappingPosition { get; set; }
        public Size SourceMappingSize { get; set; }
        public Power Power { get; set; }
        public TestPattern TestPattern { get; set; }
        public List<SensorHost> SensorHosts { get; set; }
        public List<PowerBox> PowerBoxes { get; set; }
    }

    public class Power
    {
        public string CurrentValue { get; set; }
        public string RequestedAction { get; set; }
        public List<string> AvailableActions { get; set; }
    }

    public class ColorTemperature
    {
        public List<string> ValidRange { get; set; }
        public string CurrentValue { get; set; }
    }

    public class Gamma
    {
        public string CurrentValue { get; set; }
        public float Min { get; set; }
        public float Max { get; set; }
    }
}
