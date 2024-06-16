using ChattingApp.Properties;
using System.Runtime.CompilerServices;

namespace ChattingApp
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            emailTxt = new TextBox();
            SignUpButton = new Button();
            emailLabel = new Label();
            passwordTxt = new TextBox();
            passwordLabel = new Label();
            SignInButton = new Button();
            nameLabel = new Label();
            nameTxt = new TextBox();
            SuspendLayout();
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(126, 144);
            emailTxt.Multiline = true;
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(286, 37);
            emailTxt.TabIndex = 0;
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(190, 315);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(144, 37);
            SignUpButton.TabIndex = 1;
            SignUpButton.Text = "Sign-UP";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = SystemColors.ControlLightLight;
            emailLabel.Location = new Point(70, 147);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(52, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "E-Mail";
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(126, 244);
            passwordTxt.Multiline = true;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(286, 37);
            passwordTxt.TabIndex = 6;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = SystemColors.ControlLightLight;
            passwordLabel.Location = new Point(50, 247);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password";
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(365, 443);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(144, 37);
            SignInButton.TabIndex = 8;
            SignInButton.Text = "Sign-IN";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = SystemColors.ControlLightLight;
            nameLabel.Location = new Point(70, 74);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(126, 71);
            nameTxt.Multiline = true;
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(286, 37);
            nameTxt.TabIndex = 9;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(521, 492);
            Controls.Add(nameLabel);
            Controls.Add(nameTxt);
            Controls.Add(SignInButton);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTxt);
            Controls.Add(emailLabel);
            Controls.Add(SignUpButton);
            Controls.Add(emailTxt);
            Name = "Form2";
            Text = "Chatting Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailTxt;
        private Button SignUpButton;
        private Label emailLabel;
        private TextBox passwordTxt;
        private Label passwordLabel;
        private Button SignInButton;
        private Label nameLabel;
        private TextBox nameTxt;
    }
}
