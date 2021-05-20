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
using Newtonsoft.Json;
using System.Configuration;

namespace Barco.Led.NM.JsonRPCTestClient
{
    public partial class TestingRestStyle : Form
    {
        public TestingRestStyle()
        {
            InitializeComponent();
        }

        /// <summary>
        /// getDisplaySystemButton_Click() - Get a Display System based on the ID which is chosen.
        /// 
        /// Author: ameja
        /// Date: 1/25/2018
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getDisplaySystemButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxDisplaySystemIds.Text))
            {
                MessageBox.Show("Please enter a display system ID");
                return;
            }
            string displaySystemId = comboBoxDisplaySystemIds.Text;

            //Call JSON rpc post request with source value
            JObject result;
            try
            {
                result = SendGetRequest(Common.CreateJsonRequest("getdisplaysystem", "{\"displaySystemId\": \"" + displaySystemId + "\"}"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            DisplaySystemOnClient displaySystem = JsonConvert.DeserializeObject<DisplaySystemOnClient>(result["result"].ToString());

            luminanceTextBox.Text = displaySystem.Luminance;
            displaySystemNameText.Text = displaySystem.Name;

            if (displaySystem.Gamma != null)
            {
                if (!displaySystem.Gamma.CurrentValue.Equals("Undefined"))
                {
                    gammaNumericUpDown.Text = displaySystem.Gamma.CurrentValue.ToString();
                    gammaUndefinedLabel.Visible = false;
                }
                else
                {
                    gammaUndefinedLabel.Visible = true;
                }
                gammaNumericUpDown.Maximum = (decimal)displaySystem.Gamma.Max;
                gammaNumericUpDown.Minimum = (decimal)displaySystem.Gamma.Min;
            }
            if (displaySystem.AvailableSources != null)
            {
                comboBoxActiveSource.Items.Clear();
                displaySystem.AvailableSources.ForEach(x => comboBoxActiveSource.Items.Add(x));
            }
            comboBoxActiveSource.Text = displaySystem.ActiveSource;

            var validRange = displaySystem.ColorTemperature.ValidRange;
            colorTempComboBox.Items.Clear();
            colorTempComboBox.Items.Add("");
            foreach (var value in validRange)
            {
                colorTempComboBox.Items.Add(value);
            }

            colorTempComboBox.Text = displaySystem.ColorTemperature.CurrentValue;

            //Load source position
            sourcePositionXText.Text = displaySystem.SourceMappingPosition.X.ToString();
            sourcePositionYText.Text = displaySystem.SourceMappingPosition.Y.ToString();
            sourceSizeWidthText.Text = displaySystem.SourceMappingSize.Width.ToString();
            sourceSizeHeightText.Text = displaySystem.SourceMappingSize.Height.ToString();

            flowLayoutPanel1.Controls.Clear();

            //Init the direction combo box
            directionComboBox.Items.Clear();
            displaySystem.TestPattern.ValidDirections.ForEach(x => directionComboBox.Items.Add(x));

            //Init available test patterns combo box
            availableTestPatternsComboBox.Items.Clear();
            displaySystem.TestPattern.AvailableTestPatterns.ForEach(x => availableTestPatternsComboBox.Items.Add(x));

            //Set the test pattern settings information
            redTextBox.Text = displaySystem.TestPattern.Red.ToString();
            greenTextBox.Text = displaySystem.TestPattern.Green.ToString();
            blueTextBox.Text = displaySystem.TestPattern.Blue.ToString();
            movementCheckBox.Checked = displaySystem.TestPattern.Movement;
            directionComboBox.Text = displaySystem.TestPattern.Direction;
            availableTestPatternsComboBox.Text = displaySystem.TestPattern.SelectedTestPattern;

            //Add light sensor info 
            if (displaySystem.SensorHosts.Count() > 0)
            {
                lightSensorGridView.DataSource = displaySystem.SensorHosts;
            }

            //Add power switch info
            if (displaySystem.PowerBoxes.Count() > 0)
            {
                powerSwitchGridView.DataSource = displaySystem.PowerBoxes;
            }
        }

        /// <summary>
        /// PopulateColorTempComboBox() - Get the available color temperatures from a display system and populate in the dropdown
        /// 
        /// Author: ameja
        /// Date: 1/25/2018
        /// </summary>
        private void PopulateColorTempComboBox()
        {
            if (string.IsNullOrEmpty(comboBoxDisplaySystemIds.Text))
            {
                MessageBox.Show("Please enter a display system ID");
                return;
            }
            string displaySystemId = comboBoxDisplaySystemIds.Text;

            //Call JSON rpc post request with source value
            JObject result;
            try
            {
                result = SendGetRequest(Common.CreateJsonRequest("getdisplaysystem", "{\"displaySystemId\": \"" + displaySystemId + "\"}"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            var validRange = result["result"]["ColorTemperature"]["ValidRange"].ToList();
            colorTempComboBox.Items.Clear();
            colorTempComboBox.Items.Add("");
            validRange.Sort();

            foreach (var value in validRange)
            {
                colorTempComboBox.Items.Add(value);
            }

            colorTempComboBox.SelectedIndex = colorTempComboBox.FindString(result["result"]["ColorTemperature"]["CurrentValue"].ToString());
        }

        /// <summary>
        /// setDisplaySystemButton_Click() - Do a bulk set of parameters on a Display System based on which parameters have been set.
        /// 
        /// Author: ameja
        /// Date: 1/25/2018
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setDisplaySystemButton_Click(object sender, EventArgs e)
        {
            try
            {
                DisplaySystemOnClient clientObj = new DisplaySystemOnClient();
                clientObj.ID = comboBoxDisplaySystemIds.Text;
                clientObj.ActiveSource = comboBoxActiveSource.Text;
                clientObj.Luminance = luminanceTextBox.Text;
                clientObj.ColorTemperature.CurrentValue = colorTempComboBox.Text;
                clientObj.Gamma.CurrentValue = gammaNumericUpDown.Value.ToString();
                clientObj.Name = displaySystemNameText.Text;
                Point pos = new Point();
                pos.X = Int32.Parse(sourcePositionXText.Text);
                pos.Y = Int32.Parse(sourcePositionYText.Text);
                clientObj.SourceMappingPosition = pos;
                Size outputVideoSize = new System.Drawing.Size();
                outputVideoSize.Width = Int32.Parse(sourceSizeWidthText.Text);
                outputVideoSize.Height = Int32.Parse(sourceSizeHeightText.Text);
                clientObj.SourceMappingSize = outputVideoSize;
                clientObj.TestPattern.Red = Int32.Parse(redTextBox.Text);
                clientObj.TestPattern.Green = Int32.Parse(greenTextBox.Text);
                clientObj.TestPattern.Blue = Int32.Parse(blueTextBox.Text);
                clientObj.TestPattern.Direction = directionComboBox.Text;
                clientObj.TestPattern.Movement = movementCheckBox.Checked;
                clientObj.TestPattern.SelectedTestPattern = availableTestPatternsComboBox.Text;

                string displaySystemOnClientString = JsonConvert.SerializeObject(clientObj, Formatting.Indented);

                if (string.IsNullOrEmpty(displaySystemOnClientString))
                {
                    MessageBox.Show("Please enter a value for the display system");
                }

                string displaySystem = displaySystemOnClientString.Replace("\n", "");
                string displaySystemId = "";

                //Call JSON rpc post request with source value
                byte[] data = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setdisplaysystem", "{\"displaySystem\": " + displaySystem + ", \"displaySystemId\":\"" + displaySystemId + "\"}"));

                try
                {
                    SendRequest(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            luminanceTextBox.Text = "";
            colorTempComboBox.SelectedIndex = 0;
            gammaNumericUpDown.Text = "";
            displaySystemNameText.Text = "";
        }

        /// <summary>
        /// getDisplaySystemsButton_Click() - Get all the Display Systems in JSON format and populate the JSON values into a text area.
        /// 
        /// Author: ameja
        /// Date: 1/25/2018
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getDisplaySystemsButton_Click(object sender, EventArgs e)
        {
            //Call JSON rpc post request with source value
            JObject result;
            try
            {
                result = SendGetRequest(Common.CreateJsonRequest("getdisplaysystems", ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            comboBoxDisplaySystemIds.Items.Clear();
            displaySystemsTextBox.Text = "";  //clear the display systems text box
            List<DisplaySystemOnClient> displaySystems = JsonConvert.DeserializeObject<List<DisplaySystemOnClient>>(result["result"].ToString());

            foreach (var displaySystem in displaySystems)
            {
                comboBoxDisplaySystemIds.Items.Add(displaySystem.ID);
            }

            displaySystemsTextBox.Text = JsonConvert.SerializeObject(displaySystems, Formatting.Indented);

            comboBoxDisplaySystemIds.SelectedIndex = 0;
        }

        public void PopulateDisplaySystemIdsComboBox()
        {
            //Call JSON rpc post request with source value
            JObject result;
            try
            {
                result = SendGetRequest(Common.CreateJsonRequest("getdisplaysystems", ""));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            List<DisplaySystemOnClient> displaySystems = JsonConvert.DeserializeObject<List<DisplaySystemOnClient>>(result["result"].ToString());

            if (displaySystems.Count() > 0)
            {
                comboBoxDisplaySystemIds.Items.Clear();

                foreach (var displaySystem in displaySystems)
                {
                    comboBoxDisplaySystemIds.Items.Add(displaySystem.ID);
                }
                comboBoxDisplaySystemIds.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("There are no display systems that exist at this time. Please add a display system and restart this application.");
                this.Close();
            }
        }

        private void buttonIndividualCallsForm_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Owner.Focus();
            this.Close();
        }

        private void TestingRestStyle_Load(object sender, EventArgs e)
        {
            PopulateDisplaySystemIdsComboBox();
        }

        /// <summary>
        /// Get the text from the display systems text box to set values for all display systems in bulk.
        /// 
        /// Author: ameja
        /// Date: 11/21/2017
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setDisplaySystemsButton_Click(object sender, EventArgs e)
        {
            try
            {
                string displaySystems = displaySystemsTextBox.Text;

                //Call JSON rpc post request with source value
                byte[] data = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setdisplaysystems", "{\"displaySystems\": " + displaySystems + "}"));

                try
                {
                    SendRequest(data);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void comboBoxActiveSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxActiveSource.Text.Equals("testpattern"))
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }
    }
}
