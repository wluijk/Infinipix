using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Barco.Led.NM.JsonRPCDataModel
{
    /// <summary>
    /// JsonRPCRequest - Represents a JSON-RPC request. The Parameters field would be used to map the "params" field of a
    /// JSON-RPC request.
    /// 
    /// Author: ameja
    /// Date: 12/20/2017
    /// </summary>
    public class JsonRpcRequest
    {
        public JsonRpcRequest()
        {
            this.DisplaySystemIds = new List<string>();
        }

        public string Method { get; set; }
        public dynamic Parameters { get; set; }
        public string JsonRPCVersion { get; set; }
        public string QueryId { get; set; }
        public string DisplaySystemId { get; set; }
        public List<string> DisplaySystemIds { get; set; }
        public bool IsValid { get; set; }
    }
}
