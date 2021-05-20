using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Barco.Led.NM.JsonRPCDataModel;

namespace Barco.Led.NM.JsonRPCTestClient
{
    public class DisplaySystemOnClient : DisplaySystem
    {
    }

    public class ImageProcessingParamOnClient : ImageProcessingParameter
    {
        public ImageProcessingParamOnClient(string sourceType, string value, int min, int max)
            : base(sourceType, value, min, max)
        {
        }
    }
}
