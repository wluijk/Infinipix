using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace TestCreatingJsonRPCClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static string Token = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Token = "";
                EnableControls(false);
                ipAddressText.ReadOnly = false;
            }
        }

        private void EnableControls(bool ctrlStatus)
        {
            foreach (Control c in Page.Controls)
            {
                foreach (Control ctrl in c.Controls)
                {
                    if (ctrl is TextBox)
                        ((TextBox)ctrl).ReadOnly = (ctrlStatus == true) ? false : true;

                    else if (ctrl is Button)
                        ((Button)ctrl).Enabled = ctrlStatus;

                    else if (ctrl is RadioButtonList)
                        ((RadioButtonList)ctrl).Enabled = ctrlStatus;

                    else if (ctrl is ImageButton)
                        ((ImageButton)ctrl).Enabled = ctrlStatus;

                    else if (ctrl is CheckBox)
                        ((CheckBox)ctrl).Enabled = ctrlStatus;

                    else if (ctrl is DropDownList)
                        ((DropDownList)ctrl).Enabled = ctrlStatus;

                    else if (ctrl is HyperLink)
                        ((HyperLink)ctrl).Enabled = ctrlStatus;
                }
            }

        }
        protected void btn1_Click(object sender, EventArgs e)
        {
            string content = SendRequest(ipAddressText.Text, "{\"jsonrpc\":\"2.0\", \"method\":\"getpublickey\", \"params\":{}, \"id\":\"1234\"}");
            var obj = Newtonsoft.Json.Linq.JObject.Parse(content);

            lblPublicKey.Text = obj["result"].ToString();
        }

        public static string SendRequest(string ipAddress, string query)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(query);

            WebRequest request = WebRequest.Create("http://" + ipAddress + "/webapi/JsonRPC");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;
            if (!string.IsNullOrEmpty(Token))
            {
                request.Headers[HttpRequestHeader.Authorization] = "Bearer " + Token;
            }

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
                        using (StreamReader sr99 = new StreamReader(stream))
                        {
                            responseContent = sr99.ReadToEnd();
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

        protected void btnAuthenticate_Click(object sender, EventArgs e)
        {
            string content = SendRequest(ipAddressText.Text, "{\"jsonrpc\":\"2.0\", \"method\":\"authenticate\", \"params\":{\"encryptedString\":\"" + encryptedText.Text + "\"}, \"id\":\"1234\"}");
            var obj = Newtonsoft.Json.Linq.JObject.Parse(content);

            if (obj["result"] != null)
            {
                lblAuthenticatedToken.Text = obj["result"].ToString();
                if (obj["result"].Count() > 0 && obj["result"]["Token"] != null)
                {
                    Token = obj["result"]["Token"].ToString();
                }
            }
            else
            {
                errorLabel.Text = obj["error"].ToString();
            }
        }

        protected void btnActiveSource_Click(object sender, EventArgs e)
        {
            string content = SendRequest(ipAddressText.Text, "{\"jsonrpc\":\"2.0\", \"method\":\"getactivesource\", \"params\":{\"displaySystemId\":" + ddlDisplaySystemIds.Text + "}, \"id\":\"1234\"}");
            var obj = Newtonsoft.Json.Linq.JObject.Parse(content);

            activeSourceText.Text = obj["result"].ToString();
        }

        protected void btnGetSourcePosition_Click(object sender, EventArgs e)
        {
            string content = SendRequest(ipAddressText.Text, "{\"jsonrpc\":\"2.0\", \"method\":\"getsourcepositionandoutputsize\", \"params\":{\"displaySystemId\":" + ddlDisplaySystemIds.Text + "}, \"id\":\"1234\"}");
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(content);

            if (obj.error != null)
            {
                errorLabel.Text = obj.error.message.ToString();
            }
            else
            {
                txtXPosition.Text = obj.result.x.ToString();
                txtYPosition.Text = obj.result.y.ToString();
                txtWidth.Text = obj.result.width.ToString();
                txtHeight.Text = obj.result.height.ToString();
            }
        }

        protected void btnSetSourcePosition_Click(object sender, EventArgs e)
        {
            string content = SendRequest(ipAddressText.Text, "{\"jsonrpc\":\"2.0\", \"method\":\"setsourcepositionandoutputsize\", \"params\":{\"displaySystemId\":" + ddlDisplaySystemIds.Text +
                ", \"source\":\"" + activeSourceText.Text + "\", \"x\": " + txtXPosition.Text + ", " +
                "\"y\":" + txtYPosition.Text + ", \"width\":" + txtWidth.Text + ", \"height\":" + txtHeight.Text + "}, \"id\":\"1234\"}");
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(content);

            if (obj.error != null)
            {
                errorLabel.Text = obj.error.message.ToString();
            }
            else
            {
                successLabel.Text = obj.result.ToString();
            }
        }

        protected void btnGetTestPatternSettings_Click(object sender, EventArgs e)
        {
            string content = SendRequest(ipAddressText.Text, "{\"jsonrpc\":\"2.0\", \"method\":\"gettestpatternsettings\", \"params\":{\"displaySystemId\":" + ddlDisplaySystemIds.Text + "}, \"id\":\"1234\"}");
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(content);

            if (obj.error != null)
            {
                errorLabel.Text = obj.error.message.ToString();
            }
            else
            {
                dynamic obj1 = JObject.Parse(obj.result.ToString());

                txtTestPatternSettings.Text = obj.result.ToString();
                txtTestPatternSettingRed.Text = obj1.Red.ToString();
                txtTestPatternSettingGreen.Text = obj1.Green.ToString();
                txtTestPatternSettingBlue.Text = obj1.Blue.ToString();
                txtTestPatternSettingMovement.Text = obj1.Movement.ToString();
                txtTestPatternSettingDirection.Text = obj1.Direction.ToString();
                chkMovement.Checked = Boolean.Parse(obj1.Movement.ToString());

                ddlDirections.Items.Clear();
                foreach (var direction in obj1.ValidDirections)
                {
                    ddlDirections.Items.Add(direction.ToString());
                }
                ddlAvailableTestPatterns.Items.Clear();
                foreach (var availableTestPattern in obj1.AvailableTestPatterns)
                {
                    ddlAvailableTestPatterns.Items.Add(availableTestPattern.ToString());
                }
                ddlAvailableTestPatterns.SelectedValue = obj1.SelectedTestPattern.ToString();
                ddlDirections.SelectedValue = obj1.Direction.ToString();

            }
        }

        protected void btnSetTestPatternSettings_Click(object sender, EventArgs e)
        {
            string content = SendRequest(ipAddressText.Text, "{\"jsonrpc\":\"2.0\", \"method\":\"settestpatternsettings\", \"params\":{\"displaySystemId\":" + ddlDisplaySystemIds.Text +
               ", \"pattern\":\"" + ddlAvailableTestPatterns.Text + "\", \"red\": " + txtTestPatternSettingRed.Text + ", " +
               "\"green\":" + txtTestPatternSettingGreen.Text + ", \"blue\":" + txtTestPatternSettingBlue.Text + ", \"movement\":\"" + chkMovement.Checked
               + "\", \"direction\":\"" + ddlDirections.Text + "\"}, \"id\":\"1234\"}");
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(content);

            if (obj.error != null)
            {
                errorLabel.Text = obj.error.message.ToString();
            }
            else
            {
                successLabel.Text = obj.result.ToString();
            }
        }

        protected void btnGetSourceSettings_Click(object sender, EventArgs e)
        {
            string content = SendRequest(ipAddressText.Text, "{\"jsonrpc\":\"2.0\", \"method\":\"getsource\", \"params\":{\"displaySystemId\":" + ddlDisplaySystemIds.Text + ", \"sourceType\":\"" + ddlAvailableSources.Text + "\"}, \"id\":\"1234\"}");
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(content);

            if (obj.error != null)
            {
                errorLabel.Text = obj.error.message.ToString();
            }
            else
            {
                txtSourceSettings.Text = obj.result.ToString();

                try
                {
                    dynamic dynamo = JObject.Parse(obj["result"].ToString());
                    
                    foreach (dynamic imageProcessingParameter in dynamo.ImageProcessingParameters)
                    {
                        if (imageProcessingParameter.Type.ToString().Equals("brightness"))
                        {
                            txtBrightness.Text = imageProcessingParameter.Value.ToString();
                        }
                        else
                        {
                            txtSourceSettingArea.Text += imageProcessingParameter.Type.ToString() + " " + imageProcessingParameter.Value.ToString() + System.Environment.NewLine;
                        }
                    }
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }
        }

        protected void btnGetDisplaySystems_Click(object sender, EventArgs e)
        {
            string content = SendRequest(ipAddressText.Text, "{\"jsonrpc\":\"2.0\", \"method\":\"getdisplaysystems\", \"params\":{}, \"id\":\"1234\"}");
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(content);

            if (obj.error != null)
            {
                errorLabel.Text = obj.error.message.ToString();
            }
            else
            {
                //dynamic displaySystem = JObject.Parse(obj.result.ToString());
                var newString = string.Join(" ", System.Text.RegularExpressions.Regex.Split(obj.result.ToString(), @"(?:\r\n|\n|\r)"));

                JArray j = JArray.Parse(newString);
                dynamic displaySystem = JObject.Parse(j[0].ToString());
                string sourceMappingPosition = displaySystem.SourceMappingPosition.ToString();
                var coords = sourceMappingPosition.Split(',');
                txtXPosition.Text = coords[0];
                txtYPosition.Text = coords[1];
                string sourceMappingSize = displaySystem.SourceMappingSize.ToString();
                var sizecoords = sourceMappingSize.Split(',');
                txtWidth.Text = sizecoords[0];
                txtHeight.Text = sizecoords[1];
                txtTestPatternSettingRed.Text = displaySystem.TestPattern.Red.ToString();

                Console.Write(newString);
                txtDisplaySystems.Text = obj.result.ToString();
                activeSourceText.Text = displaySystem.ActiveSource.ToString();
            }
        }

        protected void btnSetDisplaySystems_Click(object sender, EventArgs e)
        {
            string content = SendRequest(ipAddressText.Text, "{\"jsonrpc\":\"2.0\", \"method\":\"setdisplaysystems\", \"params\":{\"displaySystems\":" + txtDisplaySystems.Text + "}, \"id\":\"1234\"}");
           
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(content);

            if (obj.error != null)
            {
                errorLabel.Text = obj.error.message.ToString();
            }
            else
            {
                successLabel.Text = obj.result.ToString();
            }
        }

        protected void ipAddressText_TextChanged(object sender, EventArgs e)
        {
            EnableControls(true);
        }

        protected void btnDisplaySystemIds_Click(object sender, EventArgs e)
        {
            string content = SendRequest(ipAddressText.Text, "{\"jsonrpc\":\"2.0\", \"method\":\"getdisplaysystemids\", \"params\":{}, \"id\":\"1234\"}");
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(content);

            if (obj.result != null)
            {
                foreach (var tuple in obj.result)
                {
                    ddlDisplaySystemIds.Items.Add(tuple.ID.ToString());
                }
            }
            else
            {
                if (obj.error != null)
                {
                    errorLabel.Text = obj.error.message.ToString();
                }
            }
        }

        protected void btnGetAvailableSources_Click(object sender, EventArgs e)
        {

        }

        protected void btnGetAvailableSources_Click1(object sender, EventArgs e)
        {
            string content = SendRequest(ipAddressText.Text, "{\"jsonrpc\":\"2.0\", \"method\":\"getdisplaysystem\", \"params\":{\"displaySystemId\":"+ ddlDisplaySystemIds.Text +"}, \"id\":\"1234\"}");
            dynamic obj = Newtonsoft.Json.Linq.JObject.Parse(content);

            if (obj.result != null)
            {
                dynamic displaySystem = JObject.Parse(obj["result"].ToString());

                foreach (var source in displaySystem.AvailableSources)
                {
                    ddlAvailableSources.Items.Add(source.ToString());
                }
            }
            else
            {
                errorLabel.Text = "There are no available sources.";
            }
        }
    }
}