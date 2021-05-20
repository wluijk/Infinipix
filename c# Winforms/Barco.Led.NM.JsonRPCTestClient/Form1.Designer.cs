namespace Barco.Led.NM.JsonRPCTestClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonSetActiveSource = new System.Windows.Forms.Button();
            this.buttonGetActiveSource = new System.Windows.Forms.Button();
            this.buttonOpenRestStyleForm = new System.Windows.Forms.Button();
            this.buttonSetLuminance = new System.Windows.Forms.Button();
            this.buttonGetLuminance = new System.Windows.Forms.Button();
            this.txtLuminance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetGamma = new System.Windows.Forms.Button();
            this.buttonSetGamma = new System.Windows.Forms.Button();
            this.comboBoxDisplaySystemIds = new System.Windows.Forms.ComboBox();
            this.buttonGetColorTemp = new System.Windows.Forms.Button();
            this.buttonSetColorTemp = new System.Windows.Forms.Button();
            this.comboBoxColorTemp = new System.Windows.Forms.ComboBox();
            this.dataBeingSentText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxActiveSource = new System.Windows.Forms.ComboBox();
            this.displaySystemNameText = new System.Windows.Forms.TextBox();
            this.getDisplaySystemNameButton = new System.Windows.Forms.Button();
            this.setDisplaySystemNameButton = new System.Windows.Forms.Button();
            this.gammaNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.sourcePositionXTextBox = new System.Windows.Forms.TextBox();
            this.sourcePositionYTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.getSourcePositionButton = new System.Windows.Forms.Button();
            this.setSourcePositionButton = new System.Windows.Forms.Button();
            this.dataReceivedText = new System.Windows.Forms.RichTextBox();
            this.displaySystemIdsListView = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sourceSizeWidthTextBox = new System.Windows.Forms.TextBox();
            this.sourceSizeHeightTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.supportedTestPatternsComboBox = new System.Windows.Forms.ComboBox();
            this.redTextBox = new System.Windows.Forms.TextBox();
            this.greenTextBox = new System.Windows.Forms.TextBox();
            this.blueTextBox = new System.Windows.Forms.TextBox();
            this.testPatternDirectionsComboBox = new System.Windows.Forms.ComboBox();
            this.movementCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.getTestPatternSettingsButton = new System.Windows.Forms.Button();
            this.setTestPatternSettingsButton = new System.Windows.Forms.Button();
            this.getLightSensorInfoButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.powerSwitchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lightSensorGridView = new System.Windows.Forms.DataGridView();
            this.sensorHostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temperaturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.luminanceDevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.luminanceDevicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getPowerboxButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerSwitchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightSensorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorHostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luminanceDevicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luminanceDevicesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSetActiveSource
            // 
            this.buttonSetActiveSource.Location = new System.Drawing.Point(64, 139);
            this.buttonSetActiveSource.Name = "buttonSetActiveSource";
            this.buttonSetActiveSource.Size = new System.Drawing.Size(220, 23);
            this.buttonSetActiveSource.TabIndex = 0;
            this.buttonSetActiveSource.Text = "Set Active Source";
            this.buttonSetActiveSource.UseVisualStyleBackColor = true;
            this.buttonSetActiveSource.Click += new System.EventHandler(this.buttonSetActiveSource_Click);
            // 
            // buttonGetActiveSource
            // 
            this.buttonGetActiveSource.Location = new System.Drawing.Point(64, 110);
            this.buttonGetActiveSource.Name = "buttonGetActiveSource";
            this.buttonGetActiveSource.Size = new System.Drawing.Size(220, 23);
            this.buttonGetActiveSource.TabIndex = 4;
            this.buttonGetActiveSource.Text = "Get Active Source";
            this.buttonGetActiveSource.UseVisualStyleBackColor = true;
            this.buttonGetActiveSource.Click += new System.EventHandler(this.buttonGetActiveSource_Click);
            // 
            // buttonOpenRestStyleForm
            // 
            this.buttonOpenRestStyleForm.CausesValidation = false;
            this.buttonOpenRestStyleForm.Location = new System.Drawing.Point(302, 894);
            this.buttonOpenRestStyleForm.Name = "buttonOpenRestStyleForm";
            this.buttonOpenRestStyleForm.Size = new System.Drawing.Size(272, 23);
            this.buttonOpenRestStyleForm.TabIndex = 5;
            this.buttonOpenRestStyleForm.Text = "Open up Bulk Updates Form";
            this.buttonOpenRestStyleForm.UseVisualStyleBackColor = true;
            this.buttonOpenRestStyleForm.Click += new System.EventHandler(this.restStyleFormButton_Click);
            // 
            // buttonSetLuminance
            // 
            this.buttonSetLuminance.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSetLuminance.Location = new System.Drawing.Point(64, 234);
            this.buttonSetLuminance.Name = "buttonSetLuminance";
            this.buttonSetLuminance.Size = new System.Drawing.Size(220, 23);
            this.buttonSetLuminance.TabIndex = 6;
            this.buttonSetLuminance.Text = "Set Luminance";
            this.buttonSetLuminance.UseVisualStyleBackColor = false;
            this.buttonSetLuminance.Click += new System.EventHandler(this.setLuminanceButton_Click);
            // 
            // buttonGetLuminance
            // 
            this.buttonGetLuminance.Location = new System.Drawing.Point(64, 205);
            this.buttonGetLuminance.Name = "buttonGetLuminance";
            this.buttonGetLuminance.Size = new System.Drawing.Size(220, 23);
            this.buttonGetLuminance.TabIndex = 7;
            this.buttonGetLuminance.Text = "Get Luminance";
            this.buttonGetLuminance.UseVisualStyleBackColor = true;
            this.buttonGetLuminance.Click += new System.EventHandler(this.getLuminanceButton_Click);
            // 
            // txtLuminance
            // 
            this.txtLuminance.AllowDrop = true;
            this.txtLuminance.Location = new System.Drawing.Point(64, 179);
            this.txtLuminance.Name = "txtLuminance";
            this.txtLuminance.Size = new System.Drawing.Size(220, 20);
            this.txtLuminance.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Display System Id";
            // 
            // buttonGetGamma
            // 
            this.buttonGetGamma.Location = new System.Drawing.Point(68, 406);
            this.buttonGetGamma.Name = "buttonGetGamma";
            this.buttonGetGamma.Size = new System.Drawing.Size(216, 23);
            this.buttonGetGamma.TabIndex = 11;
            this.buttonGetGamma.Text = "Get Gamma";
            this.buttonGetGamma.UseVisualStyleBackColor = true;
            this.buttonGetGamma.Click += new System.EventHandler(this.buttonGetGamma_Click);
            // 
            // buttonSetGamma
            // 
            this.buttonSetGamma.Location = new System.Drawing.Point(68, 435);
            this.buttonSetGamma.Name = "buttonSetGamma";
            this.buttonSetGamma.Size = new System.Drawing.Size(216, 23);
            this.buttonSetGamma.TabIndex = 12;
            this.buttonSetGamma.Text = "Set Gamma";
            this.buttonSetGamma.UseVisualStyleBackColor = true;
            this.buttonSetGamma.Click += new System.EventHandler(this.buttonSetGamma_Click);
            // 
            // comboBoxDisplaySystemIds
            // 
            this.comboBoxDisplaySystemIds.FormattingEnabled = true;
            this.comboBoxDisplaySystemIds.Location = new System.Drawing.Point(167, 32);
            this.comboBoxDisplaySystemIds.Name = "comboBoxDisplaySystemIds";
            this.comboBoxDisplaySystemIds.Size = new System.Drawing.Size(133, 21);
            this.comboBoxDisplaySystemIds.TabIndex = 14;
            this.comboBoxDisplaySystemIds.SelectedIndexChanged += new System.EventHandler(this.comboBoxDisplaySystemIds_SelectedIndexChanged);
            // 
            // buttonGetColorTemp
            // 
            this.buttonGetColorTemp.Location = new System.Drawing.Point(64, 309);
            this.buttonGetColorTemp.Name = "buttonGetColorTemp";
            this.buttonGetColorTemp.Size = new System.Drawing.Size(216, 23);
            this.buttonGetColorTemp.TabIndex = 17;
            this.buttonGetColorTemp.Text = "Get Color Temperature";
            this.buttonGetColorTemp.UseVisualStyleBackColor = true;
            this.buttonGetColorTemp.Click += new System.EventHandler(this.buttonGetColorTemp_Click);
            // 
            // buttonSetColorTemp
            // 
            this.buttonSetColorTemp.Location = new System.Drawing.Point(64, 338);
            this.buttonSetColorTemp.Name = "buttonSetColorTemp";
            this.buttonSetColorTemp.Size = new System.Drawing.Size(216, 23);
            this.buttonSetColorTemp.TabIndex = 18;
            this.buttonSetColorTemp.Text = "Set Color Temperature";
            this.buttonSetColorTemp.UseVisualStyleBackColor = true;
            this.buttonSetColorTemp.Click += new System.EventHandler(this.buttonSetColorTemp_Click);
            // 
            // comboBoxColorTemp
            // 
            this.comboBoxColorTemp.FormattingEnabled = true;
            this.comboBoxColorTemp.Location = new System.Drawing.Point(64, 282);
            this.comboBoxColorTemp.Name = "comboBoxColorTemp";
            this.comboBoxColorTemp.Size = new System.Drawing.Size(216, 21);
            this.comboBoxColorTemp.TabIndex = 19;
            // 
            // dataBeingSentText
            // 
            this.dataBeingSentText.Location = new System.Drawing.Point(63, 747);
            this.dataBeingSentText.Name = "dataBeingSentText";
            this.dataBeingSentText.Size = new System.Drawing.Size(360, 117);
            this.dataBeingSentText.TabIndex = 20;
            this.dataBeingSentText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(395, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data being sent:";
            // 
            // comboBoxActiveSource
            // 
            this.comboBoxActiveSource.FormattingEnabled = true;
            this.comboBoxActiveSource.Location = new System.Drawing.Point(64, 83);
            this.comboBoxActiveSource.Name = "comboBoxActiveSource";
            this.comboBoxActiveSource.Size = new System.Drawing.Size(220, 21);
            this.comboBoxActiveSource.TabIndex = 22;
            // 
            // displaySystemNameText
            // 
            this.displaySystemNameText.Location = new System.Drawing.Point(68, 480);
            this.displaySystemNameText.Name = "displaySystemNameText";
            this.displaySystemNameText.Size = new System.Drawing.Size(212, 20);
            this.displaySystemNameText.TabIndex = 23;
            // 
            // getDisplaySystemNameButton
            // 
            this.getDisplaySystemNameButton.Location = new System.Drawing.Point(68, 506);
            this.getDisplaySystemNameButton.Name = "getDisplaySystemNameButton";
            this.getDisplaySystemNameButton.Size = new System.Drawing.Size(212, 23);
            this.getDisplaySystemNameButton.TabIndex = 24;
            this.getDisplaySystemNameButton.Text = "Get Display System Name";
            this.getDisplaySystemNameButton.UseVisualStyleBackColor = true;
            this.getDisplaySystemNameButton.Click += new System.EventHandler(this.getDisplaySystemNameButton_Click);
            // 
            // setDisplaySystemNameButton
            // 
            this.setDisplaySystemNameButton.Location = new System.Drawing.Point(68, 535);
            this.setDisplaySystemNameButton.Name = "setDisplaySystemNameButton";
            this.setDisplaySystemNameButton.Size = new System.Drawing.Size(212, 23);
            this.setDisplaySystemNameButton.TabIndex = 25;
            this.setDisplaySystemNameButton.Text = "Set Display System Name";
            this.setDisplaySystemNameButton.UseVisualStyleBackColor = true;
            this.setDisplaySystemNameButton.Click += new System.EventHandler(this.setDisplaySystemNameButton_Click);
            // 
            // gammaNumericUpDown1
            // 
            this.gammaNumericUpDown1.DecimalPlaces = 1;
            this.gammaNumericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gammaNumericUpDown1.Location = new System.Drawing.Point(68, 380);
            this.gammaNumericUpDown1.Name = "gammaNumericUpDown1";
            this.gammaNumericUpDown1.Size = new System.Drawing.Size(212, 20);
            this.gammaNumericUpDown1.TabIndex = 26;
            // 
            // sourcePositionXTextBox
            // 
            this.sourcePositionXTextBox.Location = new System.Drawing.Point(86, 577);
            this.sourcePositionXTextBox.Name = "sourcePositionXTextBox";
            this.sourcePositionXTextBox.Size = new System.Drawing.Size(194, 20);
            this.sourcePositionXTextBox.TabIndex = 27;
            // 
            // sourcePositionYTextBox
            // 
            this.sourcePositionYTextBox.Location = new System.Drawing.Point(87, 603);
            this.sourcePositionYTextBox.Name = "sourcePositionYTextBox";
            this.sourcePositionYTextBox.Size = new System.Drawing.Size(193, 20);
            this.sourcePositionYTextBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 577);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "x:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 606);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "y:";
            // 
            // getSourcePositionButton
            // 
            this.getSourcePositionButton.Location = new System.Drawing.Point(69, 680);
            this.getSourcePositionButton.Name = "getSourcePositionButton";
            this.getSourcePositionButton.Size = new System.Drawing.Size(211, 23);
            this.getSourcePositionButton.TabIndex = 31;
            this.getSourcePositionButton.Text = "Get Source Position And Size";
            this.getSourcePositionButton.UseVisualStyleBackColor = true;
            this.getSourcePositionButton.Click += new System.EventHandler(this.getSourcePositionButton_Click);
            // 
            // setSourcePositionButton
            // 
            this.setSourcePositionButton.Location = new System.Drawing.Point(69, 709);
            this.setSourcePositionButton.Name = "setSourcePositionButton";
            this.setSourcePositionButton.Size = new System.Drawing.Size(211, 23);
            this.setSourcePositionButton.TabIndex = 32;
            this.setSourcePositionButton.Text = "Set Source Position And Size";
            this.setSourcePositionButton.UseVisualStyleBackColor = true;
            this.setSourcePositionButton.Click += new System.EventHandler(this.setSourcePositionButton_Click);
            // 
            // dataReceivedText
            // 
            this.dataReceivedText.Location = new System.Drawing.Point(438, 747);
            this.dataReceivedText.Name = "dataReceivedText";
            this.dataReceivedText.Size = new System.Drawing.Size(362, 114);
            this.dataReceivedText.TabIndex = 34;
            this.dataReceivedText.Text = "";
            // 
            // displaySystemIdsListView
            // 
            this.displaySystemIdsListView.Location = new System.Drawing.Point(329, 614);
            this.displaySystemIdsListView.Name = "displaySystemIdsListView";
            this.displaySystemIdsListView.Size = new System.Drawing.Size(121, 89);
            this.displaySystemIdsListView.TabIndex = 35;
            this.displaySystemIdsListView.UseCompatibleStateImageBehavior = false;
            this.displaySystemIdsListView.View = System.Windows.Forms.View.List;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Display System Ids Multi-select";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Clear Selection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sourceSizeWidthTextBox
            // 
            this.sourceSizeWidthTextBox.Location = new System.Drawing.Point(87, 629);
            this.sourceSizeWidthTextBox.Name = "sourceSizeWidthTextBox";
            this.sourceSizeWidthTextBox.Size = new System.Drawing.Size(193, 20);
            this.sourceSizeWidthTextBox.TabIndex = 38;
            // 
            // sourceSizeHeightTextBox
            // 
            this.sourceSizeHeightTextBox.Location = new System.Drawing.Point(87, 655);
            this.sourceSizeHeightTextBox.Name = "sourceSizeHeightTextBox";
            this.sourceSizeHeightTextBox.Size = new System.Drawing.Size(193, 20);
            this.sourceSizeHeightTextBox.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 632);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "w:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 655);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "h:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 923);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Open up Image Processing Params Form";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // supportedTestPatternsComboBox
            // 
            this.supportedTestPatternsComboBox.FormattingEnabled = true;
            this.supportedTestPatternsComboBox.Location = new System.Drawing.Point(435, 86);
            this.supportedTestPatternsComboBox.Name = "supportedTestPatternsComboBox";
            this.supportedTestPatternsComboBox.Size = new System.Drawing.Size(100, 21);
            this.supportedTestPatternsComboBox.TabIndex = 43;
            // 
            // redTextBox
            // 
            this.redTextBox.Location = new System.Drawing.Point(435, 113);
            this.redTextBox.Name = "redTextBox";
            this.redTextBox.Size = new System.Drawing.Size(100, 20);
            this.redTextBox.TabIndex = 44;
            // 
            // greenTextBox
            // 
            this.greenTextBox.Location = new System.Drawing.Point(435, 139);
            this.greenTextBox.Name = "greenTextBox";
            this.greenTextBox.Size = new System.Drawing.Size(100, 20);
            this.greenTextBox.TabIndex = 45;
            // 
            // blueTextBox
            // 
            this.blueTextBox.Location = new System.Drawing.Point(435, 165);
            this.blueTextBox.Name = "blueTextBox";
            this.blueTextBox.Size = new System.Drawing.Size(100, 20);
            this.blueTextBox.TabIndex = 46;
            // 
            // testPatternDirectionsComboBox
            // 
            this.testPatternDirectionsComboBox.FormattingEnabled = true;
            this.testPatternDirectionsComboBox.Location = new System.Drawing.Point(435, 191);
            this.testPatternDirectionsComboBox.Name = "testPatternDirectionsComboBox";
            this.testPatternDirectionsComboBox.Size = new System.Drawing.Size(100, 21);
            this.testPatternDirectionsComboBox.TabIndex = 47;
            // 
            // movementCheckBox
            // 
            this.movementCheckBox.AutoSize = true;
            this.movementCheckBox.Location = new System.Drawing.Point(435, 218);
            this.movementCheckBox.Name = "movementCheckBox";
            this.movementCheckBox.Size = new System.Drawing.Size(15, 14);
            this.movementCheckBox.TabIndex = 48;
            this.movementCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Selected Pattern:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Red:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "Green:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(334, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Blue:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(334, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Direction:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(334, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Movement:";
            // 
            // getTestPatternSettingsButton
            // 
            this.getTestPatternSettingsButton.Location = new System.Drawing.Point(337, 238);
            this.getTestPatternSettingsButton.Name = "getTestPatternSettingsButton";
            this.getTestPatternSettingsButton.Size = new System.Drawing.Size(198, 23);
            this.getTestPatternSettingsButton.TabIndex = 55;
            this.getTestPatternSettingsButton.Text = "Get Test Pattern Settings";
            this.getTestPatternSettingsButton.UseVisualStyleBackColor = true;
            this.getTestPatternSettingsButton.Click += new System.EventHandler(this.getTestPatternSettingsButton_Click);
            // 
            // setTestPatternSettingsButton
            // 
            this.setTestPatternSettingsButton.Location = new System.Drawing.Point(337, 267);
            this.setTestPatternSettingsButton.Name = "setTestPatternSettingsButton";
            this.setTestPatternSettingsButton.Size = new System.Drawing.Size(198, 23);
            this.setTestPatternSettingsButton.TabIndex = 56;
            this.setTestPatternSettingsButton.Text = "Set Test Pattern Settings";
            this.setTestPatternSettingsButton.UseVisualStyleBackColor = true;
            this.setTestPatternSettingsButton.Click += new System.EventHandler(this.setTestPatternSettingsButton_Click);
            // 
            // getLightSensorInfoButton
            // 
            this.getLightSensorInfoButton.Location = new System.Drawing.Point(336, 556);
            this.getLightSensorInfoButton.Name = "getLightSensorInfoButton";
            this.getLightSensorInfoButton.Size = new System.Drawing.Size(183, 23);
            this.getLightSensorInfoButton.TabIndex = 66;
            this.getLightSensorInfoButton.Text = "Get Light Sensor Info";
            this.getLightSensorInfoButton.UseVisualStyleBackColor = true;
            this.getLightSensorInfoButton.Click += new System.EventHandler(this.getLightSensorInfoButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 104);
            this.dataGridView1.TabIndex = 68;
            // 
            // powerSwitchBindingSource
            // 
            this.powerSwitchBindingSource.DataSource = typeof(Barco.Led.NM.JsonRPCDataModel.PowerBox);
            // 
            // lightSensorGridView
            // 
            this.lightSensorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lightSensorGridView.Location = new System.Drawing.Point(336, 452);
            this.lightSensorGridView.Name = "lightSensorGridView";
            this.lightSensorGridView.Size = new System.Drawing.Size(324, 98);
            this.lightSensorGridView.TabIndex = 69;
            // 
            // sensorHostBindingSource
            // 
            this.sensorHostBindingSource.DataSource = typeof(Barco.Led.NM.JsonRPCDataModel.SensorHost);
            // 
            // temperaturesBindingSource
            // 
            this.temperaturesBindingSource.DataMember = "Temperatures";
            this.temperaturesBindingSource.DataSource = this.sensorHostBindingSource;
            // 
            // luminanceDevicesBindingSource
            // 
            this.luminanceDevicesBindingSource.DataMember = "LuminanceDevices";
            this.luminanceDevicesBindingSource.DataSource = this.sensorHostBindingSource;
            // 
            // luminanceDevicesBindingSource1
            // 
            this.luminanceDevicesBindingSource1.DataMember = "LuminanceDevices";
            this.luminanceDevicesBindingSource1.DataSource = this.sensorHostBindingSource;
            // 
            // getPowerboxButton
            // 
            this.getPowerboxButton.Location = new System.Drawing.Point(336, 419);
            this.getPowerboxButton.Name = "getPowerboxButton";
            this.getPowerboxButton.Size = new System.Drawing.Size(184, 23);
            this.getPowerboxButton.TabIndex = 70;
            this.getPowerboxButton.Text = "Get Powerbox Info";
            this.getPowerboxButton.UseVisualStyleBackColor = true;
            this.getPowerboxButton.Click += new System.EventHandler(this.getPowerboxButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(828, 985);
            this.Controls.Add(this.getPowerboxButton);
            this.Controls.Add(this.lightSensorGridView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.getLightSensorInfoButton);
            this.Controls.Add(this.setTestPatternSettingsButton);
            this.Controls.Add(this.getTestPatternSettingsButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.movementCheckBox);
            this.Controls.Add(this.testPatternDirectionsComboBox);
            this.Controls.Add(this.blueTextBox);
            this.Controls.Add(this.greenTextBox);
            this.Controls.Add(this.redTextBox);
            this.Controls.Add(this.supportedTestPatternsComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sourceSizeHeightTextBox);
            this.Controls.Add(this.sourceSizeWidthTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.displaySystemIdsListView);
            this.Controls.Add(this.dataReceivedText);
            this.Controls.Add(this.setSourcePositionButton);
            this.Controls.Add(this.getSourcePositionButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sourcePositionYTextBox);
            this.Controls.Add(this.sourcePositionXTextBox);
            this.Controls.Add(this.gammaNumericUpDown1);
            this.Controls.Add(this.setDisplaySystemNameButton);
            this.Controls.Add(this.getDisplaySystemNameButton);
            this.Controls.Add(this.displaySystemNameText);
            this.Controls.Add(this.comboBoxActiveSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataBeingSentText);
            this.Controls.Add(this.comboBoxColorTemp);
            this.Controls.Add(this.buttonSetColorTemp);
            this.Controls.Add(this.buttonGetColorTemp);
            this.Controls.Add(this.comboBoxDisplaySystemIds);
            this.Controls.Add(this.buttonSetGamma);
            this.Controls.Add(this.buttonGetGamma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLuminance);
            this.Controls.Add(this.buttonGetLuminance);
            this.Controls.Add(this.buttonSetLuminance);
            this.Controls.Add(this.buttonOpenRestStyleForm);
            this.Controls.Add(this.buttonGetActiveSource);
            this.Controls.Add(this.buttonSetActiveSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerSwitchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightSensorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorHostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperaturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luminanceDevicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luminanceDevicesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetActiveSource;
        private System.Windows.Forms.Button buttonGetActiveSource;
        private System.Windows.Forms.Button buttonOpenRestStyleForm;
        private System.Windows.Forms.Button buttonSetLuminance;
        private System.Windows.Forms.Button buttonGetLuminance;
        private System.Windows.Forms.TextBox txtLuminance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetGamma;
        private System.Windows.Forms.Button buttonSetGamma;
        private System.Windows.Forms.ComboBox comboBoxDisplaySystemIds;
        private System.Windows.Forms.Button buttonGetColorTemp;
        private System.Windows.Forms.Button buttonSetColorTemp;
        private System.Windows.Forms.ComboBox comboBoxColorTemp;
        private System.Windows.Forms.RichTextBox dataBeingSentText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxActiveSource;
        private System.Windows.Forms.TextBox displaySystemNameText;
        private System.Windows.Forms.Button getDisplaySystemNameButton;
        private System.Windows.Forms.Button setDisplaySystemNameButton;
        private System.Windows.Forms.NumericUpDown gammaNumericUpDown1;
        private System.Windows.Forms.TextBox sourcePositionXTextBox;
        private System.Windows.Forms.TextBox sourcePositionYTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button getSourcePositionButton;
        private System.Windows.Forms.Button setSourcePositionButton;
        private System.Windows.Forms.RichTextBox dataReceivedText;
        private System.Windows.Forms.ListView displaySystemIdsListView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sourceSizeWidthTextBox;
        private System.Windows.Forms.TextBox sourceSizeHeightTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox supportedTestPatternsComboBox;
        private System.Windows.Forms.TextBox redTextBox;
        private System.Windows.Forms.TextBox greenTextBox;
        private System.Windows.Forms.TextBox blueTextBox;
        private System.Windows.Forms.ComboBox testPatternDirectionsComboBox;
        private System.Windows.Forms.CheckBox movementCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button getTestPatternSettingsButton;
        private System.Windows.Forms.Button setTestPatternSettingsButton;
        private System.Windows.Forms.Button getLightSensorInfoButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource powerSwitchBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView lightSensorGridView;
        private System.Windows.Forms.BindingSource sensorHostBindingSource;
        private System.Windows.Forms.BindingSource temperaturesBindingSource;
        private System.Windows.Forms.BindingSource luminanceDevicesBindingSource;
        private System.Windows.Forms.BindingSource luminanceDevicesBindingSource1;
        private System.Windows.Forms.Button getPowerboxButton;
    }
}

