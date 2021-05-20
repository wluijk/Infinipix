using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Barco.Led.NM.JsonRPCTestClient
{
    public partial class AuthenticateForm : Form
    {
        public string Token { get; set; }

        public AuthenticateForm()
        {
            InitializeComponent();

            encryptButton.Text = "Encrypt " + char.ConvertFromUtf32(8595);
        }

        private void authenticateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var encryptedString = Encrypt("{\"username\":\"" + usernameTextBox.Text + "\", \"password\": \"" + passwordTextBox.Text + "\"}");

                //Call JSON rpc post request with source value
                JObject result;
                try
                {
                    string rawResponse = "";
                    result = Common.SendGetRequest("{\"jsonrpc\":\"2.0\", \"method\":\"authenticate\", \"params\":{\"encryptedString\": \"" +
                      encryptedString + "\"},  \"id\":\"" + new Random().Next(10000) + "\"}", out rawResponse);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }

                //Call JSON rpc post request with source value
                Token = result["result"]["Token"].ToString();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string Encrypt(string text)
        {
            // Use OAEP padding (PKCS#1 v2).
            var doOaepPadding = true;
            // ------------------------------------------------
            // RSA Keys
            // ------------------------------------------------
            var rsa = new System.Security.Cryptography.RSACryptoServiceProvider();
            //Get the xml params returned form getPublicKey which contains the public key information
            var xmlParams = publicKeyTextBox.Text;
            // Import parameters from XML string.
            rsa.FromXmlString(xmlParams);

            // Export RSA key to RSAParameters and include:
            //    false - Only public key required for encryption.
            // Export parameters and include only Public Key (Modulus + Exponent) 
            // required for encryption.
            var rsaParamsPublic = rsa.ExportParameters(false);

            // ------------------------------------------------
            // Encrypt
            // ------------------------------------------------
            var decryptedBytes = System.Text.Encoding.UTF8.GetBytes(text);
            // Create a new instance of RSACryptoServiceProvider.
            rsa = new System.Security.Cryptography.RSACryptoServiceProvider();
            // Import the RSA Key information.
            rsa.ImportParameters(rsaParamsPublic);
            // Encrypt byte array.
            var encryptedBytes = rsa.Encrypt(decryptedBytes, doOaepPadding);
            // Convert bytes to base64 string.
            var encryptedString = System.Convert.ToBase64String(encryptedBytes);
            return encryptedString;
        }

        private void getPublicKeyButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Call JSON rpc post request with source value
                JObject result;
                try
                {
                    string rawResponse = "";
                    result = Common.SendGetRequest("{\"jsonrpc\":\"2.0\", \"method\":\"getpublickey\", \"params\":{},  \"id\":\"" + new Random().Next(10000) + "\"}", out rawResponse);
                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show("The web service is turned off. Please turn it on and try again.");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }

                //Call JSON rpc post request with source value
                string publicKey = result["result"].ToString();
                publicKeyTextBox.Text = publicKey;

                //Enable the authenticate controls
                usernameTextBox.Enabled = true;
                passwordTextBox.Enabled = true;
                authenticateButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            encryptedTextBox.Text = Encrypt("{\"username\":\"" + usernameTextBox.Text + "\", \"password\": \"" + passwordTextBox.Text + "\"}");
        }

        private void defaultUserSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Call JSON rpc post request with source value
                JObject result;
                try
                {
                    string rawResponse = "";
                    result = Common.SendGetRequest("{\"jsonrpc\":\"2.0\", \"method\":\"savedefaultuser\", " +
                                                    "\"params\":{\"username\":\"" + defaultUsernameText.Text + "\", \"password\":\"" +
                                                    defaultPasswordText.Text + "\"},  \"id\":\"" + new Random().Next(10000) + "\"}", out rawResponse);
                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show("The web service is turned off. Please turn it on and try again.");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }

                MessageBox.Show(result.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
