using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barco.Led.NM.JsonRPCDataModel
{
    /// <summary>
    /// BearerToken.cs - Represents the Bearer token which will be encrypted and appended to an HTTP Authorization header.
    /// 
    /// Author: ameja
    /// Date: 12/20/2017
    /// </summary>
    public class BearerToken
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string MachineId { get; set; }
        public int TimeLimitInMinutes { get; set; }
        public DateTime IssuedDateTime { get; set; }
    }
}
