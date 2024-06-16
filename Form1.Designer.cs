using System.Runtime.CompilerServices;

namespace ChattingApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            IPAddressTextBox = new TextBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            messageBox = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // IPAddressTextBox
            // 
            IPAddressTextBox.Location = new Point(32, 39);
            IPAddressTextBox.Multiline = true;
            IPAddressTextBox.Name = "IPAddressTextBox";
            IPAddressTextBox.Size = new Size(100, 33);
            IPAddressTextBox.TabIndex = 0;
            IPAddressTextBox.Text = "127.0.0.1";
            // 
            // button1
            // 
            button1.Location = new Point(360, 39);
            button1.Name = "button1";
            button1.Size = new Size(128, 35);
            button1.TabIndex = 1;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.Font = new Font("Segoe UI", 11.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(32, 78);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(456, 313);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // messageBox
            // 
            messageBox.Enabled = false;
            messageBox.Location = new Point(32, 397);
            messageBox.Multiline = true;
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(369, 68);
            messageBox.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(408, 397);
            button2.Name = "button2";
            button2.Size = new Size(80, 68);
            button2.TabIndex = 4;
            button2.Text = "Send";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(32, 13);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 5;
            label1.Text = "RemoteIP Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(218, 42);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 6;
            label2.Text = clientName;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(521, 492);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(messageBox);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(IPAddressTextBox);
            Name = "Form1";
            Text = "Chatting Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IPAddressTextBox;
        private Button button1;
        private RichTextBox richTextBox1;
        private TextBox messageBox;
        private Button button2;
        private Label label1;
        private Label label2;
    }
}
