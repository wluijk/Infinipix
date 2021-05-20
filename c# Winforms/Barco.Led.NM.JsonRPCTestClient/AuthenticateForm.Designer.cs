namespace Barco.Led.NM.JsonRPCTestClient
{
    partial class AuthenticateForm
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.authenticateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getPublicKeyButton = new System.Windows.Forms.Button();
            this.publicKeyTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptedTextBox = new System.Windows.Forms.RichTextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.defaultUserSaveButton = new System.Windows.Forms.Button();
            this.defaultUsernameText = new System.Windows.Forms.TextBox();
            this.defaultPasswordText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Location = new System.Drawing.Point(154, 100);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(154, 20);
            this.usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Location = new System.Drawing.Point(154, 126);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(154, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // authenticateButton
            // 
            this.authenticateButton.Enabled = false;
            this.authenticateButton.Location = new System.Drawing.Point(154, 152);
            this.authenticateButton.Name = "authenticateButton";
            this.authenticateButton.Size = new System.Drawing.Size(154, 23);
            this.authenticateButton.TabIndex = 2;
            this.authenticateButton.Text = "Authenticate";
            this.authenticateButton.UseVisualStyleBackColor = true;
            this.authenticateButton.Click += new System.EventHandler(this.authenticateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(90, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter the name and password for the user";
            // 
            // getPublicKeyButton
            // 
            this.getPublicKeyButton.Location = new System.Drawing.Point(154, 294);
            this.getPublicKeyButton.Name = "getPublicKeyButton";
            this.getPublicKeyButton.Size = new System.Drawing.Size(154, 23);
            this.getPublicKeyButton.TabIndex = 6;
            this.getPublicKeyButton.Text = "Get Public Key";
            this.getPublicKeyButton.UseVisualStyleBackColor = true;
            this.getPublicKeyButton.Click += new System.EventHandler(this.getPublicKeyButton_Click);
            // 
            // publicKeyTextBox
            // 
            this.publicKeyTextBox.Location = new System.Drawing.Point(129, 192);
            this.publicKeyTextBox.Name = "publicKeyTextBox";
            this.publicKeyTextBox.Size = new System.Drawing.Size(198, 96);
            this.publicKeyTextBox.TabIndex = 7;
            this.publicKeyTextBox.Text = "";
            // 
            // encryptedTextBox
            // 
            this.encryptedTextBox.Location = new System.Drawing.Point(129, 352);
            this.encryptedTextBox.Name = "encryptedTextBox";
            this.encryptedTextBox.Size = new System.Drawing.Size(198, 55);
            this.encryptedTextBox.TabIndex = 8;
            this.encryptedTextBox.Text = "";
            this.encryptedTextBox.Visible = false;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(154, 323);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(154, 23);
            this.encryptButton.TabIndex = 9;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Visible = false;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // defaultUserSaveButton
            // 
            this.defaultUserSaveButton.Location = new System.Drawing.Point(129, 519);
            this.defaultUserSaveButton.Name = "defaultUserSaveButton";
            this.defaultUserSaveButton.Size = new System.Drawing.Size(198, 23);
            this.defaultUserSaveButton.TabIndex = 10;
            this.defaultUserSaveButton.Text = "Save Default User";
            this.defaultUserSaveButton.UseVisualStyleBackColor = true;
            this.defaultUserSaveButton.Click += new System.EventHandler(this.defaultUserSaveButton_Click);
            // 
            // defaultUsernameText
            // 
            this.defaultUsernameText.Location = new System.Drawing.Point(129, 467);
            this.defaultUsernameText.Name = "defaultUsernameText";
            this.defaultUsernameText.Size = new System.Drawing.Size(198, 20);
            this.defaultUsernameText.TabIndex = 11;
            // 
            // defaultPasswordText
            // 
            this.defaultPasswordText.Location = new System.Drawing.Point(129, 493);
            this.defaultPasswordText.Name = "defaultPasswordText";
            this.defaultPasswordText.Size = new System.Drawing.Size(198, 20);
            this.defaultPasswordText.TabIndex = 12;
            // 
            // AuthenticateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 659);
            this.Controls.Add(this.defaultPasswordText);
            this.Controls.Add(this.defaultUsernameText);
            this.Controls.Add(this.defaultUserSaveButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.encryptedTextBox);
            this.Controls.Add(this.publicKeyTextBox);
            this.Controls.Add(this.getPublicKeyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authenticateButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "AuthenticateForm";
            this.Text = "AuthenticateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button authenticateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getPublicKeyButton;
        private System.Windows.Forms.RichTextBox publicKeyTextBox;
        private System.Windows.Forms.RichTextBox encryptedTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button defaultUserSaveButton;
        private System.Windows.Forms.TextBox defaultUsernameText;
        private System.Windows.Forms.TextBox defaultPasswordText;
    }
}