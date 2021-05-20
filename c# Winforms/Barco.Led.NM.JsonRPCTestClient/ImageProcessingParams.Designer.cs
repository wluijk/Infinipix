namespace Barco.Led.NM.JsonRPCTestClient
{
    partial class ImageProcessingParams
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
            this.brightnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sharpnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.displaySystemIdsComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.steepnessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.clipToSubblackNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.availableSourcesComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpnessNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steepnessNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipToSubblackNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // brightnessNumericUpDown
            // 
            this.brightnessNumericUpDown.DecimalPlaces = 1;
            this.brightnessNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.brightnessNumericUpDown.Location = new System.Drawing.Point(130, 118);
            this.brightnessNumericUpDown.Name = "brightnessNumericUpDown";
            this.brightnessNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.brightnessNumericUpDown.TabIndex = 0;
            // 
            // hueNumericUpDown
            // 
            this.hueNumericUpDown.Location = new System.Drawing.Point(130, 148);
            this.hueNumericUpDown.Name = "hueNumericUpDown";
            this.hueNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.hueNumericUpDown.TabIndex = 1;
            // 
            // sharpnessNumericUpDown
            // 
            this.sharpnessNumericUpDown.Location = new System.Drawing.Point(130, 172);
            this.sharpnessNumericUpDown.Name = "sharpnessNumericUpDown";
            this.sharpnessNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.sharpnessNumericUpDown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Brightness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sharpness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hue";
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(93, 266);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(75, 23);
            this.getButton.TabIndex = 6;
            this.getButton.Text = "Get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(174, 266);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 7;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // displaySystemIdsComboBox
            // 
            this.displaySystemIdsComboBox.FormattingEnabled = true;
            this.displaySystemIdsComboBox.Location = new System.Drawing.Point(129, 61);
            this.displaySystemIdsComboBox.Name = "displaySystemIdsComboBox";
            this.displaySystemIdsComboBox.Size = new System.Drawing.Size(121, 21);
            this.displaySystemIdsComboBox.TabIndex = 8;
            this.displaySystemIdsComboBox.SelectedIndexChanged += new System.EventHandler(this.displaySystemIdsComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Display System Ids:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Steepness";
            // 
            // steepnessNumericUpDown
            // 
            this.steepnessNumericUpDown.Location = new System.Drawing.Point(129, 199);
            this.steepnessNumericUpDown.Name = "steepnessNumericUpDown";
            this.steepnessNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.steepnessNumericUpDown.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cliptosubblack";
            // 
            // clipToSubblackNumericUpDown
            // 
            this.clipToSubblackNumericUpDown.Location = new System.Drawing.Point(129, 225);
            this.clipToSubblackNumericUpDown.Name = "clipToSubblackNumericUpDown";
            this.clipToSubblackNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.clipToSubblackNumericUpDown.TabIndex = 15;
            // 
            // availableSourcesComboBox
            // 
            this.availableSourcesComboBox.FormattingEnabled = true;
            this.availableSourcesComboBox.Location = new System.Drawing.Point(129, 91);
            this.availableSourcesComboBox.Name = "availableSourcesComboBox";
            this.availableSourcesComboBox.Size = new System.Drawing.Size(121, 21);
            this.availableSourcesComboBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Source Type:";
            // 
            // ImageProcessingParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 352);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.availableSourcesComboBox);
            this.Controls.Add(this.clipToSubblackNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.steepnessNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.displaySystemIdsComboBox);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sharpnessNumericUpDown);
            this.Controls.Add(this.hueNumericUpDown);
            this.Controls.Add(this.brightnessNumericUpDown);
            this.Name = "ImageProcessingParams";
            this.Text = "ImageProcessingParams";
            this.Load += new System.EventHandler(this.ImageProcessingParams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.brightnessNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpnessNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steepnessNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clipToSubblackNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown brightnessNumericUpDown;
        private System.Windows.Forms.NumericUpDown hueNumericUpDown;
        private System.Windows.Forms.NumericUpDown sharpnessNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.ComboBox displaySystemIdsComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown steepnessNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown clipToSubblackNumericUpDown;
        private System.Windows.Forms.ComboBox availableSourcesComboBox;
        private System.Windows.Forms.Label label7;
    }
}