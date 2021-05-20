using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Configuration;
using Newtonsoft.Json.Linq;

namespace Barco.Led.NM.JsonRPCTestClient
{
    public class Common
    {
        public static string IpAddress { get; set; }
        public static string Token { get; set; }

        /// <summary>
        /// SendRequest() - Send a POST request to the JSON-RPC web service.
        /// 
        /// Author: ameja
        /// Date: 1/24/2018
        /// </summary>
        /// <param name="data">The data to send in bytes</param>
        /// <returns>The result from the service call</returns>
        public static string SendRequest(byte[] data)
        {
            WebRequest request = WebRequest.Create("http://" + IpAddress + "/webapi/JsonRPC");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            request.Headers[HttpRequestHeader.Authorization] = "Bearer " + Token;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            string responseContent = null;

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader streamReader = new StreamReader(stream))
                        {
                            responseContent = streamReader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return responseContent;
        }

        public static JObject SendGetRequest(string jsonRpcRequestString, out string rawResponse)
        {
            //Call JSON rpc post request with source value
            byte[] data = Encoding.ASCII.GetBytes(jsonRpcRequestString);

            string responseContent = "";
            try
            {
                responseContent = Common.SendRequest(data);
                rawResponse = responseContent;
            }
            catch (Exception)
            {
                throw;
            }

            var trimmedContent = responseContent.Replace("\r", "");
            trimmedContent = trimmedContent.Replace("\n", "");
            trimmedContent = trimmedContent.Replace("}{", "}@{");
            var results = trimmedContent.Split('@');

            var result = JObject.Parse(results[0]);
            return result;
        }

        /// <summary>
        /// CreateJsonRequest() - Return a JSON-RPC formatted request
        /// 
        /// Author: ameja
        /// Date: 1/25/2018
        /// </summary>
        /// <param name="method">The method to call</param>
        /// <param name="parameters">The parameters</param>
        /// <returns>A string representation of the JSON-RPC call</returns>
        public static string CreateJsonRequest(string method, string parameters)
        {
            return "{\"jsonrpc\":\"2.0\", \"method\":\"" + method + "\", \"params\":" + parameters + ", \"id\":\"" + new Random().Next(10000) + "\"}";
        }
    }
}
