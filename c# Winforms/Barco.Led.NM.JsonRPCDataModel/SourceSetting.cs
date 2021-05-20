using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco.Led.NM.JsonRPCDataModel
{
    /// <summary>
    /// Source.cs - Represents a source along with it's image processing settings.
    /// 
    /// Author: ameja
    /// Date: 12/20/2017
    /// </summary>
    public class SourceSetting
    {
        public SourceSetting()
        {
            this.ImageProcessingParameters = new List<ImageProcessingParameter>();
        }

        public SourceSetting(string sourceType)
            : base()
        {
            this.SourceType = sourceType;
            this.ImageProcessingParameters = new List<ImageProcessingParameter>();
        }

        public string SourceType { get; set; }
        public List<ImageProcessingParameter> ImageProcessingParameters { get; set; }
    }

    public class ImageProcessingParameter
    {
        public ImageProcessingParameter(string type, string value, double min, double max)
        {
            this.Type = type;
            this.Value = value;
            this.Min = min;
            this.Max = max;
        }

        public string Type { get; set; }
        public string Value { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
    }
}
