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
            IPAddressTextBox.Location = new Point(148, 56);
            IPAddressTextBox.Multiline = true;
            IPAddressTextBox.Name = "IPAddressTextBox";
            IPAddressTextBox.Size = new Size(218, 47);
            IPAddressTextBox.TabIndex = 0;
            IPAddressTextBox.Text = "127.0.0.1";
            // 
            // button1
            // 
            button1.Location = new Point(790, 56);
            button1.Name = "button1";
            button1.Size = new Size(199, 47);
            button1.TabIndex = 1;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(38, 116);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1037, 376);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // messageBox
            // 
            messageBox.Location = new Point(38, 505);
            messageBox.Multiline = true;
            messageBox.Enabled = false;
            messageBox.Name = "messageBox";
            messageBox.Size = new Size(951, 68);
            messageBox.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(995, 505);
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
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 5;
            label1.Text = "RemoteIP Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(504, 56);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 6;
            label2.Text = this.clientName;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 585);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(messageBox);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(IPAddressTextBox);
            Name = "Chatting Application";
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
