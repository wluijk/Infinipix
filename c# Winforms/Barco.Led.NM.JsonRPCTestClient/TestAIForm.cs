using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace Barco.Led.JsonRpc.TestClient
{
    public partial class TestAIForm : Form
    {
        public TestAIForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = richTextBox1.Text;
            string method = "";

            //get luminance
            if (text.Contains("luminance"))
            {
                method = "setluminance";
            }

            string resultString = System.Text.RegularExpressions.Regex.Match(text, @"\d+").Value;
            int val = Int32.Parse(resultString);

            string command = Common.CreateJsonRequest(method, "{\"displaySystemIds\":{}, \"value\": " + val + " }");
        }

        private void InitEngine()
        {
            // Create a new SpeechRecognitionEngine instance.
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
            
            // Configure the input to the recognizer.
            sre.SetInputToDefaultAudioDevice();

            // Create a simple grammar that recognizes "red", "green", or "blue".
            Choices colors = new Choices();
            colors.Add(new string[] { "red", "green", "blue", "luminance", "ten" });

            // Create a GrammarBuilder object and append the Choices object.
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(colors);

            // Create the Grammar instance and load it into the speech recognition engine.
            Grammar g = new Grammar(gb);
            sre.LoadGrammar(g);

            // Register a handler for the SpeechRecognized event.
            sre.SpeechRecognized += sre_SpeechRecognized;

            // Start recognition.
            sre.Recognize();
        }

        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            MessageBox.Show(e.Result.Text);
            if (string.IsNullOrEmpty(command))
            {
                command = e.Result.Text;
            }
            else
            {
                command2 = e.Result.Text;
                if (command.Equals("luminance") && command2.Equals("ten"))
                {
                    MessageBox.Show("setting luminance to ten");
                }
                command = "";
                command2 = "";
                MessageBox.Show("reset params");
            }
            InitEngine();
        }

        string command = "";
        string command2 = "";

        private void button2_Click(object sender, EventArgs e)
        {
            InitEngine();
        }
    }
}
