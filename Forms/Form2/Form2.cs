
using ChattingApp.Database;

namespace ChattingApp.Forms.Form2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ProxyDatabase database = ProxyDatabase.getInstance();

        private async void SignUpButton_Click(object sender, EventArgs e)
        {
            if (await database.userExists(emailTxt.Text, passwordTxt.Text))
            {
                MessageBox.Show("User Already Exists In Database");
            }
            else
            {
                await database.insertUserAsync(nameTxt.Text,emailTxt.Text, passwordTxt.Text);
                MessageBox.Show("User Added Successfully");
            }
        }
        Form SignInForm = null;
        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (SignInForm == null) SignInForm = new Form3.Form3();
            SignInForm.Show();
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
