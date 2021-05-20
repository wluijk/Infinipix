namespace Barco.Led.NM.JsonRPCTestClient
{
    partial class TestingRestStyle
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
            this.buttonGetDisplaySystem = new System.Windows.Forms.Button();
            this.buttonSetDisplaySystem = new System.Windows.Forms.Button();
            this.luminanceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.displaySystemsTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonGetDisplaySystems = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.displaySystemNameText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorTempComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonOpenIndividualCallsForm = new System.Windows.Forms.Button();
            this.comboBoxDisplaySystemIds = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxActiveSource = new System.Windows.Forms.ComboBox();
            this.setDisplaySystemsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sourcePositionXText = new System.Windows.Forms.TextBox();
            this.sourcePositionYText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gammaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gammaUndefinedLabel = new System.Windows.Forms.Label();
            this.dataBeingSentText = new System.Windows.Forms.RichTextBox();
            this.dataReceivedText = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.availableTestPatternsComboBox = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.movementCheckBox = new System.Windows.Forms.CheckBox();
            this.directionComboBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.blueTextBox = new System.Windows.Forms.TextBox();
            this.greenTextBox = new System.Windows.Forms.TextBox();
            this.redTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sourceSizeWidthText = new System.Windows.Forms.TextBox();
            this.sourceSizeHeightText = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.powerSwitchGridView = new System.Windows.Forms.DataGridView();
            this.powerBoxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lightSensorGridView = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerSwitchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerBoxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightSensorGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetDisplaySystem
            // 
            this.buttonGetDisplaySystem.Location = new System.Drawing.Point(151, 367);
            this.buttonGetDisplaySystem.Name = "buttonGetDisplaySystem";
            this.buttonGetDisplaySystem.Size = new System.Drawing.Size(114, 23);
            this.buttonGetDisplaySystem.TabIndex = 1;
            this.buttonGetDisplaySystem.Text = "Get Display System";
            this.buttonGetDisplaySystem.UseVisualStyleBackColor = true;
            this.buttonGetDisplaySystem.Click += new System.EventHandler(this.getDisplaySystemButton_Click);
            // 
            // buttonSetDisplaySystem
            // 
            this.buttonSetDisplaySystem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSetDisplaySystem.Location = new System.Drawing.Point(271, 367);
            this.buttonSetDisplaySystem.Name = "buttonSetDisplaySystem";
            this.buttonSetDisplaySystem.Size = new System.Drawing.Size(121, 23);
            this.buttonSetDisplaySystem.TabIndex = 3;
            this.buttonSetDisplaySystem.Text = "Set Display System";
            this.buttonSetDisplaySystem.UseVisualStyleBackColor = true;
            this.buttonSetDisplaySystem.Click += new System.EventHandler(this.setDisplaySystemButton_Click);
            // 
            // luminanceTextBox
            // 
            this.luminanceTextBox.Location = new System.Drawing.Point(131, 99);
            this.luminanceTextBox.Name = "luminanceTextBox";
            this.luminanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.luminanceTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Active Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Luminance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Color Temperature";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(36, 367);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(108, 23);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // displaySystemsTextBox
            // 
            this.displaySystemsTextBox.Location = new System.Drawing.Point(34, 405);
            this.displaySystemsTextBox.Name = "displaySystemsTextBox";
            this.displaySystemsTextBox.Size = new System.Drawing.Size(436, 228);
            this.displaySystemsTextBox.TabIndex = 13;
            this.displaySystemsTextBox.Text = "";
            // 
            // buttonGetDisplaySystems
            // 
            this.buttonGetDisplaySystems.Location = new System.Drawing.Point(34, 649);
            this.buttonGetDisplaySystems.Name = "buttonGetDisplaySystems";
            this.buttonGetDisplaySystems.Size = new System.Drawing.Size(256, 23);
            this.buttonGetDisplaySystems.TabIndex = 14;
            this.buttonGetDisplaySystems.Text = "Get Display Systems";
            this.buttonGetDisplaySystems.UseVisualStyleBackColor = true;
            this.buttonGetDisplaySystems.Click += new System.EventHandler(this.getDisplaySystemsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Gamma";
            // 
            // displaySystemNameText
            // 
            this.displaySystemNameText.Location = new System.Drawing.Point(129, 190);
            this.displaySystemNameText.Name = "displaySystemNameText";
            this.displaySystemNameText.Size = new System.Drawing.Size(100, 20);
            this.displaySystemNameText.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Name";
            // 
            // colorTempComboBox
            // 
            this.colorTempComboBox.FormattingEnabled = true;
            this.colorTempComboBox.Location = new System.Drawing.Point(131, 125);
            this.colorTempComboBox.Name = "colorTempComboBox";
            this.colorTempComboBox.Size = new System.Drawing.Size(100, 21);
            this.colorTempComboBox.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(996, 99);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(165, 437);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // buttonOpenIndividualCallsForm
            // 
            this.buttonOpenIndividualCallsForm.Location = new System.Drawing.Point(373, 735);
            this.buttonOpenIndividualCallsForm.Name = "buttonOpenIndividualCallsForm";
            this.buttonOpenIndividualCallsForm.Size = new System.Drawing.Size(222, 23);
            this.buttonOpenIndividualCallsForm.TabIndex = 21;
            this.buttonOpenIndividualCallsForm.Text = "Open up Individual Calls Form";
            this.buttonOpenIndividualCallsForm.UseVisualStyleBackColor = true;
            this.buttonOpenIndividualCallsForm.Click += new System.EventHandler(this.buttonIndividualCallsForm_Click);
            // 
            // comboBoxDisplaySystemIds
            // 
            this.comboBoxDisplaySystemIds.FormattingEnabled = true;
            this.comboBoxDisplaySystemIds.Location = new System.Drawing.Point(131, 46);
            this.comboBoxDisplaySystemIds.Name = "comboBoxDisplaySystemIds";
            this.comboBoxDisplaySystemIds.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDisplaySystemIds.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Display System Id";
            // 
            // comboBoxActiveSource
            // 
            this.comboBoxActiveSource.FormattingEnabled = true;
            this.comboBoxActiveSource.Location = new System.Drawing.Point(131, 73);
            this.comboBoxActiveSource.Name = "comboBoxActiveSource";
            this.comboBoxActiveSource.Size = new System.Drawing.Size(100, 21);
            this.comboBoxActiveSource.TabIndex = 24;
            this.comboBoxActiveSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxActiveSource_SelectedIndexChanged);
            // 
            // setDisplaySystemsButton
            // 
            this.setDisplaySystemsButton.Location = new System.Drawing.Point(34, 678);
            this.setDisplaySystemsButton.Name = "setDisplaySystemsButton";
            this.setDisplaySystemsButton.Size = new System.Drawing.Size(256, 23);
            this.setDisplaySystemsButton.TabIndex = 25;
            this.setDisplaySystemsButton.Text = "Set Display Systems";
            this.setDisplaySystemsButton.UseVisualStyleBackColor = true;
            this.setDisplaySystemsButton.Click += new System.EventHandler(this.setDisplaySystemsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Source Position";
            // 
            // sourcePositionXText
            // 
            this.sourcePositionXText.Location = new System.Drawing.Point(149, 225);
            this.sourcePositionXText.Name = "sourcePositionXText";
            this.sourcePositionXText.Size = new System.Drawing.Size(80, 20);
            this.sourcePositionXText.TabIndex = 27;
            // 
            // sourcePositionYText
            // 
            this.sourcePositionYText.Location = new System.Drawing.Point(149, 251);
            this.sourcePositionYText.Name = "sourcePositionYText";
            this.sourcePositionYText.Size = new System.Drawing.Size(80, 20);
            this.sourcePositionYText.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "x:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "y:";
            // 
            // gammaNumericUpDown
            // 
            this.gammaNumericUpDown.DecimalPlaces = 1;
            this.gammaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.gammaNumericUpDown.Location = new System.Drawing.Point(131, 153);
            this.gammaNumericUpDown.Name = "gammaNumericUpDown";
            this.gammaNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.gammaNumericUpDown.TabIndex = 31;
            // 
            // gammaUndefinedLabel
            // 
            this.gammaUndefinedLabel.AutoSize = true;
            this.gammaUndefinedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gammaUndefinedLabel.Location = new System.Drawing.Point(128, 176);
            this.gammaUndefinedLabel.Name = "gammaUndefinedLabel";
            this.gammaUndefinedLabel.Size = new System.Drawing.Size(103, 13);
            this.gammaUndefinedLabel.TabIndex = 32;
            this.gammaUndefinedLabel.Text = "Gamma is undefined";
            // 
            // dataBeingSentText
            // 
            this.dataBeingSentText.Location = new System.Drawing.Point(536, 269);
            this.dataBeingSentText.Name = "dataBeingSentText";
            this.dataBeingSentText.Size = new System.Drawing.Size(419, 166);
            this.dataBeingSentText.TabIndex = 33;
            this.dataBeingSentText.Text = "";
            // 
            // dataReceivedText
            // 
            this.dataReceivedText.Location = new System.Drawing.Point(536, 490);
            this.dataReceivedText.Name = "dataReceivedText";
            this.dataReceivedText.Size = new System.Drawing.Size(421, 143);
            this.dataReceivedText.TabIndex = 34;
            this.dataReceivedText.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Data being sent:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(535, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Data received:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(993, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Dynamically generated Links";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.availableTestPatternsComboBox);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.movementCheckBox);
            this.panel1.Controls.Add(this.directionComboBox);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.blueTextBox);
            this.panel1.Controls.Add(this.greenTextBox);
            this.panel1.Controls.Add(this.redTextBox);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(251, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 201);
            this.panel1.TabIndex = 38;
            this.panel1.Visible = false;
            // 
            // availableTestPatternsComboBox
            // 
            this.availableTestPatternsComboBox.FormattingEnabled = true;
            this.availableTestPatternsComboBox.Location = new System.Drawing.Point(117, 35);
            this.availableTestPatternsComboBox.Name = "availableTestPatternsComboBox";
            this.availableTestPatternsComboBox.Size = new System.Drawing.Size(102, 21);
            this.availableTestPatternsComboBox.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Selected Pattern";
            // 
            // movementCheckBox
            // 
            this.movementCheckBox.AutoSize = true;
            this.movementCheckBox.Location = new System.Drawing.Point(121, 173);
            this.movementCheckBox.Name = "movementCheckBox";
            this.movementCheckBox.Size = new System.Drawing.Size(15, 14);
            this.movementCheckBox.TabIndex = 11;
            this.movementCheckBox.UseVisualStyleBackColor = true;
            // 
            // directionComboBox
            // 
            this.directionComboBox.FormattingEnabled = true;
            this.directionComboBox.Location = new System.Drawing.Point(119, 143);
            this.directionComboBox.Name = "directionComboBox";
            this.directionComboBox.Size = new System.Drawing.Size(100, 21);
            this.directionComboBox.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Movement";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Direction";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Blue";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Green";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Red";
            // 
            // blueTextBox
            // 
            this.blueTextBox.Location = new System.Drawing.Point(119, 117);
            this.blueTextBox.Name = "blueTextBox";
            this.blueTextBox.Size = new System.Drawing.Size(100, 20);
            this.blueTextBox.TabIndex = 3;
            // 
            // greenTextBox
            // 
            this.greenTextBox.Location = new System.Drawing.Point(119, 91);
            this.greenTextBox.Name = "greenTextBox";
            this.greenTextBox.Size = new System.Drawing.Size(100, 20);
            this.greenTextBox.TabIndex = 2;
            // 
            // redTextBox
            // 
            this.redTextBox.Location = new System.Drawing.Point(119, 65);
            this.redTextBox.Name = "redTextBox";
            this.redTextBox.Size = new System.Drawing.Size(100, 20);
            this.redTextBox.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Test Pattern Settings";
            // 
            // sourceSizeWidthText
            // 
            this.sourceSizeWidthText.Location = new System.Drawing.Point(149, 282);
            this.sourceSizeWidthText.Name = "sourceSizeWidthText";
            this.sourceSizeWidthText.Size = new System.Drawing.Size(80, 20);
            this.sourceSizeWidthText.TabIndex = 39;
            // 
            // sourceSizeHeightText
            // 
            this.sourceSizeHeightText.Location = new System.Drawing.Point(149, 310);
            this.sourceSizeHeightText.Name = "sourceSizeHeightText";
            this.sourceSizeHeightText.Size = new System.Drawing.Size(80, 20);
            this.sourceSizeHeightText.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(112, 282);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "width:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(112, 310);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(39, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "height:";
            // 
            // powerSwitchGridView
            // 
            this.powerSwitchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.powerSwitchGridView.Location = new System.Drawing.Point(536, 128);
            this.powerSwitchGridView.Name = "powerSwitchGridView";
            this.powerSwitchGridView.Size = new System.Drawing.Size(356, 59);
            this.powerSwitchGridView.TabIndex = 43;
            // 
            // powerBoxBindingSource
            // 
            this.powerBoxBindingSource.DataSource = typeof(Barco.Led.NM.JsonRPCDataModel.PowerBox);
            // 
            // lightSensorGridView
            // 
            this.lightSensorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lightSensorGridView.Location = new System.Drawing.Point(536, 49);
            this.lightSensorGridView.Name = "lightSensorGridView";
            this.lightSensorGridView.Size = new System.Drawing.Size(356, 57);
            this.lightSensorGridView.TabIndex = 44;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(533, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 13);
            this.label22.TabIndex = 45;
            this.label22.Text = "Light Sensor Info:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(535, 112);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "Powerswitch Info:";
            // 
            // TestingRestStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(974, 794);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lightSensorGridView);
            this.Controls.Add(this.powerSwitchGridView);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.sourceSizeHeightText);
            this.Controls.Add(this.sourceSizeWidthText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataReceivedText);
            this.Controls.Add(this.dataBeingSentText);
            this.Controls.Add(this.gammaUndefinedLabel);
            this.Controls.Add(this.gammaNumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sourcePositionYText);
            this.Controls.Add(this.sourcePositionXText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.setDisplaySystemsButton);
            this.Controls.Add(this.comboBoxActiveSource);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxDisplaySystemIds);
            this.Controls.Add(this.buttonOpenIndividualCallsForm);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.colorTempComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.displaySystemNameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGetDisplaySystems);
            this.Controls.Add(this.displaySystemsTextBox);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luminanceTextBox);
            this.Controls.Add(this.buttonSetDisplaySystem);
            this.Controls.Add(this.buttonGetDisplaySystem);
            this.Name = "TestingRestStyle";
            this.Text = "TestingRestStyle";
            this.Load += new System.EventHandler(this.TestingRestStyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerSwitchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerBoxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightSensorGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetDisplaySystem;
        private System.Windows.Forms.Button buttonSetDisplaySystem;
        private System.Windows.Forms.TextBox luminanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RichTextBox displaySystemsTextBox;
        private System.Windows.Forms.Button buttonGetDisplaySystems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox displaySystemNameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox colorTempComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonOpenIndividualCallsForm;
        private System.Windows.Forms.ComboBox comboBoxDisplaySystemIds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxActiveSource;
        private System.Windows.Forms.Button setDisplaySystemsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sourcePositionXText;
        private System.Windows.Forms.TextBox sourcePositionYText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown gammaNumericUpDown;
        private System.Windows.Forms.Label gammaUndefinedLabel;
        private System.Windows.Forms.RichTextBox dataBeingSentText;
        private System.Windows.Forms.RichTextBox dataReceivedText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox movementCheckBox;
        private System.Windows.Forms.ComboBox directionComboBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox blueTextBox;
        private System.Windows.Forms.TextBox greenTextBox;
        private System.Windows.Forms.TextBox redTextBox;
        private System.Windows.Forms.ComboBox availableTestPatternsComboBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox sourceSizeWidthText;
        private System.Windows.Forms.TextBox sourceSizeHeightText;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView powerSwitchGridView;
        private System.Windows.Forms.DataGridView lightSensorGridView;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.BindingSource powerBoxBindingSource;
    }
}