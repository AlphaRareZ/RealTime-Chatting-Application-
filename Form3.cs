﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChattingApp
{
    // Form 3 Sign In Page
    public partial class Form3 : Form
    {
        ProxyDatabase database = ProxyDatabase.getInstance();
        public Form3()
        {
            InitializeComponent();
        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            User user= await database.UserExistsSignIn(emailTxt.Text, passwordTxt.Text);
            if (user == null)
            {
                MessageBox.Show("This User Doesn't Exist");
            }
            else
            {
                Form chatAppForm = new Form1(user.name,user.portNumber);
                chatAppForm.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }
        Form signUpForm = null;
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (signUpForm == null) signUpForm = new Form2();
            signUpForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
