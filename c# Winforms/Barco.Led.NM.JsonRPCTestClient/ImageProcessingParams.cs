using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Barco.Led.NM.JsonRPCDataModel;

namespace Barco.Led.NM.JsonRPCTestClient
{
    public partial class ImageProcessingParams : Form
    {
        public ImageProcessingParams()
        {
            InitializeComponent();
        }

        /// <summary>
        /// PopulateDisplaySystemIdsComboBox() - Get the Display System IDs from an Infinipix Manager and add them to a dropdown
        /// 
        /// Author: ameja
        /// Date: 1/25/2018
        /// </summary>
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
                displaySystemIdsComboBox.Items.Clear();

                foreach (var displaySystem in displaySystems)
                {
                    displaySystemIdsComboBox.Items.Add(displaySystem.ID);
                }

                displaySystemIdsComboBox.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("There are no display systems that exist at this time. Please add a display system and restart this application.");
                this.Close();
            }
        }

        /// <summary>
        /// getButton_Click() - Get a set of Image Processing parameters from a Display System and a specified source.
        /// 
        /// Author: ameja
        /// Date: 1/25/2018
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(displaySystemIdsComboBox.Text))
            {
                MessageBox.Show("Please enter a display system ID");
                return;
            }
            string displaySystemId = displaySystemIdsComboBox.Text;

            //Call JSON rpc post request with source value
            JObject result;
            try
            {
                result = SendGetRequest(Common.CreateJsonRequest("getsource", "{\"displaySystemId\": \"" + displaySystemId + "\", \"sourceType\":\"" + availableSourcesComboBox.Text + "\"}"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            SourceSetting source = JsonConvert.DeserializeObject<SourceSetting>(result["result"].ToString());

            if (source.ImageProcessingParameters != null && source.ImageProcessingParameters.Count() > 0)
            {
                try
                {
                    if (source.ImageProcessingParameters.Exists(x => x.Type.Equals("brightness")))
                    {
                        brightnessNumericUpDown.Minimum = (decimal)source.ImageProcessingParameters.Where(x => x.Type.Equals("brightness")).First().Min;
                        brightnessNumericUpDown.Maximum = (decimal)source.ImageProcessingParameters.Where(x => x.Type.Equals("brightness")).First().Max;
                        brightnessNumericUpDown.Value = decimal.Parse(source.ImageProcessingParameters.Where(x => x.Type.Equals("brightness")).First().Value);
                    }

                    if (source.ImageProcessingParameters.Exists(x => x.Type.Equals("hue")))
                    {
                        hueNumericUpDown.Minimum = (decimal)source.ImageProcessingParameters.Where(x => x.Type.Equals("hue")).First().Min;
                        hueNumericUpDown.Maximum = (decimal)source.ImageProcessingParameters.Where(x => x.Type.Equals("hue")).First().Max;
                        hueNumericUpDown.Value = Int32.Parse(source.ImageProcessingParameters.Where(x => x.Type.Equals("hue")).First().Value);
                    }

                    if (source.ImageProcessingParameters.Exists(x => x.Type.Equals("sharpness")))
                    {
                        sharpnessNumericUpDown.Minimum = (decimal)source.ImageProcessingParameters.Where(x => x.Type.Equals("sharpness")).First().Min;
                        sharpnessNumericUpDown.Maximum = (decimal)source.ImageProcessingParameters.Where(x => x.Type.Equals("sharpness")).First().Max;
                        sharpnessNumericUpDown.Value = Int32.Parse(source.ImageProcessingParameters.Where(x => x.Type.Equals("sharpness")).First().Value);
                    }

                    if (source.ImageProcessingParameters.Exists(x => x.Type.Equals("cliptosubblack")))
                    {
                        clipToSubblackNumericUpDown.Minimum = (decimal)source.ImageProcessingParameters.Where(x => x.Type.Equals("cliptosubblack")).First().Min;
                        clipToSubblackNumericUpDown.Maximum = (decimal)source.ImageProcessingParameters.Where(x => x.Type.Equals("cliptosubblack")).First().Max;
                        clipToSubblackNumericUpDown.Value = Int32.Parse(source.ImageProcessingParameters.Where(x => x.Type.Equals("cliptosubblack")).First().Value);
                    }

                    if (source.ImageProcessingParameters.Exists(x => x.Type.Equals("steepness")))
                    {
                        steepnessNumericUpDown.Minimum = (decimal)source.ImageProcessingParameters.Where(x => x.Type.Equals("steepness")).First().Min;
                        steepnessNumericUpDown.Maximum = (decimal)source.ImageProcessingParameters.Where(x => x.Type.Equals("steepness")).First().Max;
                        steepnessNumericUpDown.Value = Int32.Parse(source.ImageProcessingParameters.Where(x => x.Type.Equals("steepness")).First().Value);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("There are no image processing parameters for this source.");
            }
        }

        /// <summary>
        /// setButton_Click() - Set the Image Processing parameters for a Display System and a specified source.
        /// 
        /// Author: ameja
        /// Date: 1/25/2018
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setButton_Click(object sender, EventArgs e)
        {
            try
            {
                SourceSetting source = new SourceSetting(availableSourcesComboBox.Text);

                //ImageProcessingParametersPerSource imageProcessingParametersPerSource = new ImageProcessingParametersPerSource("hdmi");
                source.ImageProcessingParameters.Add(new ImageProcessingParameter("brightness", brightnessNumericUpDown.Value.ToString(),
                                                           double.Parse(brightnessNumericUpDown.Minimum.ToString()),
                                                            double.Parse(brightnessNumericUpDown.Maximum.ToString())));
                source.ImageProcessingParameters.Add(new ImageProcessingParameter("sharpness", sharpnessNumericUpDown.Value.ToString(),
                                                            Int32.Parse(sharpnessNumericUpDown.Minimum.ToString()),
                                                            Int32.Parse(sharpnessNumericUpDown.Maximum.ToString())));
                source.ImageProcessingParameters.Add(new ImageProcessingParameter("hue", hueNumericUpDown.Value.ToString(),
                                                            Int32.Parse(hueNumericUpDown.Minimum.ToString()),
                                                            Int32.Parse(hueNumericUpDown.Maximum.ToString())));
                source.ImageProcessingParameters.Add(new ImageProcessingParameter("steepness", steepnessNumericUpDown.Value.ToString(),
                                                          Int32.Parse(steepnessNumericUpDown.Minimum.ToString()),
                                                          Int32.Parse(steepnessNumericUpDown.Maximum.ToString())));
                source.ImageProcessingParameters.Add(new ImageProcessingParameter("cliptosubblack", clipToSubblackNumericUpDown.Value.ToString(),
                                                          Int32.Parse(clipToSubblackNumericUpDown.Minimum.ToString()),
                                                          Int32.Parse(clipToSubblackNumericUpDown.Maximum.ToString())));

                //   string imageprocessingparameters = JsonConvert.SerializeObject(displaySystem);
                string sourcestring = JsonConvert.SerializeObject(source);

                //Call JSON rpc post request with source value
                byte[] data = Encoding.ASCII.GetBytes(Common.CreateJsonRequest("setsource", "{\"source\":" + sourcestring + "}"));

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
                string rawResponse = "";
                result = Common.SendGetRequest(query, out rawResponse);

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

                string dataReceived = Common.SendRequest(data);

                return dataReceived;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ImageProcessingParams_Load(object sender, EventArgs e)
        {
            PopulateDisplaySystemIdsComboBox();
            PopulateAvailableSourcesComboBox(displaySystemIdsComboBox.Text);
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

            availableSourcesComboBox.Items.Clear();
            availableSourcesComboBox.Items.Add("");

            foreach (var availableSource in availableSources)
            {
                availableSourcesComboBox.Items.Add(availableSource);
            }

            availableSourcesComboBox.Text = result["result"]["ActiveSource"].ToString();
        }

        private void displaySystemIdsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateAvailableSourcesComboBox(displaySystemIdsComboBox.Text);
        }
    }
}
