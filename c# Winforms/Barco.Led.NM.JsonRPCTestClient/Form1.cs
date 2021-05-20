using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Configuration;
using Newtonsoft.Json;
using Barco.Led.NM.JsonRPCDataModel;

namespace Barco.Led.NM.JsonRPCTestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get the IP address of the NM machine to control
            ipChoose ipChooseForm = new ipChoose();
            ipChooseForm.ShowDialog();
            if (!string.IsNullOrEmpty(ipChooseForm.IpAddressChosen))
            {
                Common.IpAddress = ipChooseForm.IpAddressChosen;
            }
            else
            {
                this.Close();
            }

            //Get the access token from the service
            AuthenticateForm authenticateForm = new AuthenticateForm();
            authenticateForm.ShowDialog();
            if (!string.IsNullOrEmpty(authenticateForm.Token))
            {
                Common.Token = authenticateForm.Token;
            }
            else
            {
                MessageBox.Show("The username and password are not valid. Exiting the application");
                this.Close();
            }

            //Initialize controls if needed
            try
            {
                PopulateDisplaySystemIdsComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        #region Control initializers

        private void comboBoxDisplaySystemIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateColorTempComboBox(comboBoxDisplaySystemIds.Text);
            PopulateAvailableSourcesComboBox(comboBoxDisplaySystemIds.Text);
        }

        private void PopulateAvailableSourcesComboBox(string displaySystemId)
        {
            //Call JSON rpc post request with source value
            JObject result;
            try
            {
                result = SendGetRequest(Common.CreateJsonRequest("getdisplaysystem", "{\"displaySystemId\": " + displaySystemId + "}"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            var availableSources = result["result"]["AvailableSources"].ToList();

            comboBoxActiveSource.Items.Clear();
            comboBoxActiveSource.Items.Add("");

            foreach (var availableSource in availableSources)
            {
                comboBoxActiveSource.Items.Add(availableSource);
            }

            comboBoxActiveSource.Text = result["result"]["ActiveSource"].ToString();
        }

        private void PopulateColorTempComboBox(string displaySystemId)
        {
            //Call JSON rpc post request with source value
            JObject result;
            try
            {
                result = SendGetRequest(Common.CreateJsonRequest("getdisplaysystem", "{\"displaySystemId\": " + displaySystemId + "}"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            DisplaySystemOnClient displaySystem = JsonConvert.DeserializeObject<DisplaySystemOnClient>(result["result"].ToString());

            var validRange = displaySystem.ColorTemperature.ValidRange;
            comboBoxColorTemp.Items.Clear();
            comboBoxColorTemp.Items.Add("");

            foreach (var value in validRange)
            {
                comboBoxColorTemp.Items.Add(value);
            }

            comboBoxColorTemp.Text = displaySystem.ColorTemperature.CurrentValue;
        }

        #endregion

        private void buttonSetActiveSource_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxActiveSource.Text))
                {
                    MessageBox.Show("Please enter a value for the source");
                }

                //first check list view
                if (displaySystemIdsListView.SelectedItems.Count > 0)
                {
                    var isAllChosen = displaySystemIdsListView.SelectedItems[0].Text.Equals("All");
                    if (isAllChosen)
                    {
                        //Call JSON rpc post request with source value
                        byte[] data2 = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setactivesource", "{\"displaySystemIds\":{},\"source\":\"" + comboBoxActiveSource.Text + "\"}"));

                        SendRequest(data2);
                    }
                    else
                    {
                        string displaySystemIds = "[";
                        foreach (ListViewItem displaysystemIdListViewItem in displaySystemIdsListView.SelectedItems)
                        {
                            displaySystemIds += displaysystemIdListViewItem.Text + ",";
                        }
                        displaySystemIds = displaySystemIds.TrimEnd(',');
                        displaySystemIds += "]";

                        //Call JSON rpc post request with source value
                        byte[] data2 = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setactivesource", "{\"displaySystemIds\":" + displaySystemIds + ",\"source\":\"" + comboBoxActiveSource.Text + "\"}"));

                        SendRequest(data2);
                    }
                }
                else
                {
                    int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

                    //Call JSON rpc post request with source value
                    byte[] data = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setactivesource", "{\"displaySystemIds\":" + displaySystemId + ",\"source\":\"" + comboBoxActiveSource.Text + "\"}"));

                    SendRequest(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGetActiveSource_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxDisplaySystemIds.Text))
            {
                MessageBox.Show("Please enter a display system Id.");
                return;
            }

            int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

            Random rand = new Random();

            //Call JSON rpc post request with source value
            JObject result;
            try
            {
                result = SendGetRequest(Common.CreateJsonRequest("getactivesource", "{\"displaySystemId\": " + displaySystemId + "}"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            comboBoxActiveSource.Text = result["result"].ToString();
        }

        private void restStyleFormButton_Click(object sender, EventArgs e)
        {
            TestingRestStyle form2 = new TestingRestStyle();
            form2.Show(this);
        }

        private void getLuminanceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxDisplaySystemIds.Text))
            {
                MessageBox.Show("Please enter a display system Id.");
                return;
            }

            int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

            //Call JSON rpc post request with source value
            JObject result;
            try
            {
                result = SendGetRequest(Common.CreateJsonRequest("getluminance", "{\"displaySystemId\":" + displaySystemId + "}"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            txtLuminance.Text = result["result"].ToString();
        }

        private string SendRequest(byte[] data)
        {
            try
            {
                //For debugging purposes write out what we are sending
                string dataBeingSent = Encoding.ASCII.GetString(data);
                dataBeingSentText.Text = dataBeingSent;

                string dataReceived = Common.SendRequest(data);
                dataReceivedText.Text = dataReceived;

                return dataReceived;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private JObject SendGetRequest(string query)
        {
            //Call JSON rpc post request with source value
            JObject result;
            try
            {
                dataBeingSentText.Text = query;

                string rawResponse = "";
                result = Common.SendGetRequest(query, out rawResponse);

                dataReceivedText.Text = rawResponse;
                if (result["error"] != null && result["error"]["message"] != null)
                {
                    throw new Exception(result["error"]["message"].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        private void setLuminanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

                if (string.IsNullOrEmpty(txtLuminance.Text))
                {
                    MessageBox.Show("Please enter a value for the luminance");
                    return;
                }

                //first check list view
                if (displaySystemIdsListView.SelectedItems.Count > 0)
                {
                    var isAllChosen = displaySystemIdsListView.SelectedItems[0].Text.Equals("All");
                    if (isAllChosen)
                    {
                        //Call JSON rpc post request with luminance value
                        byte[] data2 = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setluminance", "{\"displaySystemIds\":{}, \"value\": " + txtLuminance.Text + " }"));

                        SendRequest(data2);
                    }
                    else
                    {
                        string displaySystemIds = "[";
                        foreach (ListViewItem displaysystemIdListViewItem in displaySystemIdsListView.SelectedItems)
                        {
                            displaySystemIds += displaysystemIdListViewItem.Text + ",";
                        }
                        displaySystemIds = displaySystemIds.TrimEnd(',');
                        displaySystemIds += "]";

                        //Call JSON rpc post request with luminance value
                        byte[] data2 = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setluminance", "{\"displaySystemIds\":" + displaySystemIds + ", \"value\": " + txtLuminance.Text + " }"));

                        SendRequest(data2);
                    }
                }
                else
                {
                    //Call JSON rpc post request with source value
                    byte[] data = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setluminance", "{\"displaySystemIds\":" + displaySystemId + ", \"value\": " + txtLuminance.Text + " }"));

                    SendRequest(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PopulateDisplaySystemIdsComboBox()
        {
            //Call JSON rpc post request with source values
            JObject result;
            try
            {
                result = SendGetRequest(Common.CreateJsonRequest("getdisplaysystems", ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            List<DisplaySystemOnClient> displaySystems = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DisplaySystemOnClient>>(result["result"].ToString());

            if (displaySystems.Count() > 0)
            {
                comboBoxDisplaySystemIds.Items.Clear();

                foreach (var displaySystem in displaySystems)
                {
                    comboBoxDisplaySystemIds.Items.Add(displaySystem.ID);
                    gammaNumericUpDown1.Maximum = (decimal)displaySystem.Gamma.Max;
                    gammaNumericUpDown1.Minimum = (decimal)displaySystem.Gamma.Min;

                    //Populate the multi-select list as well
                    displaySystemIdsListView.Items.Add(new ListViewItem(displaySystem.ID));
                }
                displaySystemIdsListView.Items.Add(new ListViewItem("All"));

                comboBoxDisplaySystemIds.SelectedIndex = 0;
                PopulateColorTempComboBox(comboBoxDisplaySystemIds.Text);
                PopulateAvailableSourcesComboBox(comboBoxDisplaySystemIds.Text);
            }
            else
            {
                MessageBox.Show("There are no display systems that exist at this time. Please add a display system and restart this application.");
                this.Close();
            }
        }

        private void buttonGetGamma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxDisplaySystemIds.Text))
            {
                MessageBox.Show("Please enter a display system Id.");
                return;
            }

            int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

            //Call JSON rpc post request with source value
            JObject result;
            try
            {
                result = SendGetRequest(Common.CreateJsonRequest("getgamma", "{\"displaySystemId\":" + displaySystemId + "}"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            gammaNumericUpDown1.Text = result["result"].ToString();
        }

        private void buttonSetGamma_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(gammaNumericUpDown1.Text))
                {
                    MessageBox.Show("Please enter a value for the gamma");
                    return;
                }

                //first check list view
                if (displaySystemIdsListView.SelectedItems.Count > 0)
                {
                    var isAllChosen = displaySystemIdsListView.SelectedItems[0].Text.Equals("All");
                    if (isAllChosen)
                    {
                        //Call JSON rpc post request with luminance value
                        byte[] data2 = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setgamma", "{\"displaySystemIds\":{}, \"value\": " + gammaNumericUpDown1.Text + " }"));

                        SendRequest(data2);
                    }
                    else
                    {
                        string displaySystemIds = "[";
                        foreach (ListViewItem displaysystemIdListViewItem in displaySystemIdsListView.SelectedItems)
                        {
                            displaySystemIds += displaysystemIdListViewItem.Text + ",";
                        }
                        displaySystemIds = displaySystemIds.TrimEnd(',');
                        displaySystemIds += "]";

                        //Call JSON rpc post request with luminance value
                        byte[] data2 = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setgamma", "{\"displaySystemIds\":" + displaySystemIds + ", \"value\": " + gammaNumericUpDown1.Text + " }"));

                        SendRequest(data2);
                    }
                }
                else
                {
                    int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

                    //Call JSON rpc post request with source value
                    byte[] data = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setgamma", "{\"displaySystemIds\":" + displaySystemId + ", \"value\": " + gammaNumericUpDown1.Text + " }"));

                    SendRequest(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGetColorTemp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxDisplaySystemIds.Text))
                {
                    MessageBox.Show("Please enter a display system Id.");
                    return;
                }

                int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

                //Call JSON rpc post request with source value
                JObject result;
                try
                {
                    result = SendGetRequest(Common.CreateJsonRequest("getcolortemperature", "{\"displaySystemId\":" + displaySystemId + "}"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                comboBoxColorTemp.Text = result["result"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSetColorTemp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxColorTemp.Text))
                {
                    MessageBox.Show("Please enter a value for the color temperature");
                    return;
                }

                //first check list view
                if (displaySystemIdsListView.SelectedItems.Count > 0)
                {
                    var isAllChosen = displaySystemIdsListView.SelectedItems[0].Text.Equals("All");
                    if (isAllChosen)
                    {
                        //Call JSON rpc post request with luminance value
                        byte[] data2 = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setcolortemperature", "{\"displaySystemIds\":{}, \"value\": " + comboBoxColorTemp.Text + " }"));

                        SendRequest(data2);
                    }
                    else
                    {
                        string displaySystemIds = "[";
                        foreach (ListViewItem displaysystemIdListViewItem in displaySystemIdsListView.SelectedItems)
                        {
                            displaySystemIds += displaysystemIdListViewItem.Text + ",";
                        }
                        displaySystemIds = displaySystemIds.TrimEnd(',');
                        displaySystemIds += "]";

                        //Call JSON rpc post request with luminance value
                        byte[] data2 = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setcolortemperature", "{\"displaySystemIds\":" + displaySystemIds + ", \"value\": " + comboBoxColorTemp.Text + " }"));

                        SendRequest(data2);
                    }
                }
                else
                {
                    int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

                    //Call JSON rpc post request with source value
                    byte[] data = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setcolortemperature", "{\"displaySystemIds\":" + displaySystemId + ", \"value\": " + comboBoxColorTemp.Text + " }"));

                    SendRequest(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getDisplaySystemNameButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxDisplaySystemIds.Text))
            {
                MessageBox.Show("Please enter a display system Id.");
                return;
            }

            int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

            //Call JSON rpc post request with source value
            JObject result;
            try
            {
                result = SendGetRequest(Common.CreateJsonRequest("getdisplaysystemname", "{\"displaySystemId\":" + displaySystemId + "}"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            displaySystemNameText.Text = result["result"].ToString();
        }

        private void setDisplaySystemNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

                if (string.IsNullOrEmpty(displaySystemNameText.Text))
                {
                    MessageBox.Show("Please enter a value for the display system name");
                    return;
                }

                //Call JSON rpc post request with source value
                byte[] data = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setdisplaysystemname", "{\"displaySystemId\":" + displaySystemId + ", \"value\": \"" + displaySystemNameText.Text + "\" }"));

                SendRequest(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getSourcePositionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxDisplaySystemIds.Text))
                {
                    MessageBox.Show("Please enter a display system Id.");
                    return;
                }

                int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

                //Call JSON rpc post request with source value
                JObject result;
                try
                {
                    result = SendGetRequest(Common.CreateJsonRequest("getsourcepositionandoutputsize", "{\"displaySystemId\":" + displaySystemId + "}"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;

                }

                dynamic point = JObject.Parse(result["result"].ToString());
                sourcePositionXTextBox.Text = point.x.ToString();
                sourcePositionYTextBox.Text = point.y.ToString();
                sourceSizeWidthTextBox.Text = point.width.ToString();
                sourceSizeHeightTextBox.Text = point.height.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setSourcePositionButton_Click(object sender, EventArgs e)
        {
            try
            {
                //first check list view
                if (displaySystemIdsListView.SelectedItems.Count > 0)
                {
                    var isAllChosen = displaySystemIdsListView.SelectedItems[0].Text.Equals("All");
                    if (isAllChosen)
                    {
                        //Call JSON rpc post request with luminance value
                        byte[] data2 = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setsourcepositionandoutputsize", "{\"displaySystemIds\":{}"
                        + ", \"x\":" + sourcePositionXTextBox.Text
                        + ", \"y\":" + sourcePositionYTextBox.Text + ", \"width\":" + sourceSizeWidthTextBox.Text
                        + ", \"height\":" + sourceSizeHeightTextBox.Text + ", \"source\":\"" + comboBoxActiveSource.Text + "\"}"));

                        SendRequest(data2);
                    }
                    else
                    {
                        string displaySystemIds = "[";
                        foreach (ListViewItem displaysystemIdListViewItem in displaySystemIdsListView.SelectedItems)
                        {
                            displaySystemIds += displaysystemIdListViewItem.Text + ",";
                        }
                        displaySystemIds = displaySystemIds.TrimEnd(',');
                        displaySystemIds += "]";

                        //Call JSON rpc post request with luminance value
                        byte[] data2 = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setsourcepositionandoutputsize", "{\"displaySystemIds\":" + displaySystemIds
                        + ", \"x\":" + sourcePositionXTextBox.Text
                        + ", \"y\":" + sourcePositionYTextBox.Text + ", \"width\":" + sourceSizeWidthTextBox.Text
                        + ", \"height\":" + sourceSizeHeightTextBox.Text + ", \"source\":\"" + comboBoxActiveSource.Text + "\"}"));

                        SendRequest(data2);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(comboBoxDisplaySystemIds.Text))
                    {
                        MessageBox.Show("Please enter a display system Id.");
                        return;
                    }

                    int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

                    //Call JSON rpc post request with source value
                    byte[] data = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setsourcepositionandoutputsize", "{\"displaySystemIds\":" + displaySystemId
                        + ", \"x\":" + sourcePositionXTextBox.Text
                        + ", \"y\":" + sourcePositionYTextBox.Text + ", \"width\":" + sourceSizeWidthTextBox.Text
                        + ", \"height\":" + sourceSizeHeightTextBox.Text + ", \"source\":\"" + comboBoxActiveSource.Text + "\"}"));

                    SendRequest(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displaySystemIdsListView.SelectedItems.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImageProcessingParams imageProcessingParamsForm = new ImageProcessingParams();
            imageProcessingParamsForm.Show(this);
        }

        private void getTestPatternSettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxDisplaySystemIds.Text))
                {
                    MessageBox.Show("Please enter a display system Id.");
                    return;
                }

                int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

                //Call JSON rpc post request with source value
                JObject result;
                try
                {
                    result = SendGetRequest(Common.CreateJsonRequest("gettestpatternsettings", "{\"displaySystemId\":" + displaySystemId + "}"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;

                }

                TestPattern testPatternSettings = JsonConvert.DeserializeObject<TestPattern>(result["result"].ToString());

                supportedTestPatternsComboBox.Items.Clear();
                testPatternSettings.AvailableTestPatterns.ForEach(x => supportedTestPatternsComboBox.Items.Add(x));
                testPatternDirectionsComboBox.Items.Clear();
                testPatternSettings.ValidDirections.ForEach(x => testPatternDirectionsComboBox.Items.Add(x));

                supportedTestPatternsComboBox.Text = testPatternSettings.SelectedTestPattern;
                redTextBox.Text = testPatternSettings.Red.ToString();
                greenTextBox.Text = testPatternSettings.Green.ToString();
                blueTextBox.Text = testPatternSettings.Blue.ToString();
                movementCheckBox.Checked = testPatternSettings.Movement;
                testPatternDirectionsComboBox.Text = testPatternSettings.Direction;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setTestPatternSettingsButton_Click(object sender, EventArgs e)
        {
            try
            {
                TestPattern testPatternSettings = new TestPattern();
                testPatternSettings.Direction = testPatternDirectionsComboBox.Text;
                testPatternSettings.Movement = movementCheckBox.Checked;
                testPatternSettings.Red = Int32.Parse(redTextBox.Text);
                testPatternSettings.Green = Int32.Parse(greenTextBox.Text);
                testPatternSettings.Blue = Int32.Parse(blueTextBox.Text);
                testPatternSettings.SelectedTestPattern = supportedTestPatternsComboBox.Text;

                //first check list view
                if (displaySystemIdsListView.SelectedItems.Count > 0)
                {
                    var isAllChosen = displaySystemIdsListView.SelectedItems[0].Text.Equals("All");
                    if (isAllChosen)
                    {

                        string parameters = "{\"pattern\": \"" + supportedTestPatternsComboBox.Text + "\"," +
                                             "\"direction\": \"" + testPatternDirectionsComboBox.Text + "\"," + "\"movement\": \"" + movementCheckBox.Checked + "\"," +
                                             "\"red\": " + redTextBox.Text + "," +
                                             "\"green\": " + greenTextBox.Text + "," +
                                             "\"blue\": " + blueTextBox.Text + "}";

                        //Call JSON rpc post request with source value
                        byte[] data2 = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("settestpatternsettings", parameters));

                        SendRequest(data2);
                    }
                    else
                    {
                        string displaySystemIds = "[";
                        foreach (ListViewItem displaysystemIdListViewItem in displaySystemIdsListView.SelectedItems)
                        {
                            displaySystemIds += displaysystemIdListViewItem.Text + ",";
                        }
                        displaySystemIds = displaySystemIds.TrimEnd(',');
                        displaySystemIds += "]";

                        string parameters = "{\"displaySystemIds\":" + displaySystemIds + ", \"pattern\": \"" + supportedTestPatternsComboBox.Text + "\"," +
                                             "\"direction\": \"" + testPatternDirectionsComboBox.Text + "\"," + "\"movement\": \"" + movementCheckBox.Checked + "\"," +
                                             "\"red\": " + redTextBox.Text + "," +
                                             "\"green\": " + greenTextBox.Text + "," +
                                             "\"blue\": " + blueTextBox.Text + "}";

                        //Call JSON rpc post request with source value
                        byte[] data2 = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("settestpatternsettings", parameters));

                        SendRequest(data2);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(comboBoxDisplaySystemIds.Text))
                    {
                        MessageBox.Show("Please enter a display system Id.");
                        return;
                    }

                    int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

                    string parameters = "{\"displaySystemIds\":" + displaySystemId + ", \"pattern\": \"" + supportedTestPatternsComboBox.Text + "\"," +
                                         "\"direction\": \"" + testPatternDirectionsComboBox.Text + "\"," + "\"movement\": \"" + movementCheckBox.Checked + "\"," +
                                         "\"red\": " + redTextBox.Text + "," +
                                         "\"green\": " + greenTextBox.Text + "," +
                                         "\"blue\": " + blueTextBox.Text + "}";

                    //Call JSON rpc post request with source value
                    byte[] data = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("settestpatternsettings", parameters));

                    SendRequest(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getLightSensorInfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxDisplaySystemIds.Text))
                {
                    MessageBox.Show("Please enter a display system Id.");
                    return;
                }

                int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

                //Call JSON rpc post request with source value
                JObject result;
                try
                {
                    result = SendGetRequest(Common.CreateJsonRequest("getsensorhostinfo", "{\"displaySystemId\":" + displaySystemId + "}"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;

                }

                if (result["result"] != null && result["result"].Type == JTokenType.String)
                {
                    MessageBox.Show(result["result"].ToString());
                    return;
                }

                List<SensorHost> sensorHosts = null;
                try
                {
                    sensorHosts = JsonConvert.DeserializeObject<List<SensorHost>>(result["result"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }

                if (sensorHosts != null && sensorHosts.Count() > 0)
                {
                    lightSensorGridView.DataSource = sensorHosts.First().LuminanceDevices;
                }
                else
                {
                    MessageBox.Show("No light sensors exist for this display system");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getPowerboxButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(comboBoxDisplaySystemIds.Text))
                {
                    MessageBox.Show("Please enter a display system Id.");
                    return;
                }

                int displaySystemId = Int32.Parse(comboBoxDisplaySystemIds.Text);

                //Call JSON rpc post request with source value
                JObject result;
                try
                {
                    result = SendGetRequest(Common.CreateJsonRequest("getpowerboxinfo", "{\"displaySystemId\":" + displaySystemId + "}"));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;

                }

                if (result["result"] != null && result["result"].Type == JTokenType.String)
                {
                    MessageBox.Show(result["result"].ToString());
                    return;
                }

                List<PowerBox> powerBoxes = null;
                try
                {
                    powerBoxes = JsonConvert.DeserializeObject<List<PowerBox>>(result["result"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }

                if (powerBoxes != null && powerBoxes.Count() > 0)
                {
                    dataGridView1.DataSource = powerBoxes;
                }
                else
                {
                    MessageBox.Show("No power boxes exist for this display system");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
