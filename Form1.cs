using System.Net;
using System.Net.Sockets;
using System.Text;
namespace ChattingApp
{
    public partial class Form1 : Form
    {
        UdpClient server;
        IPEndPoint remoteIP_Address;
        ProxyDatabase proxyDatabase = ProxyDatabase.getInstance();
        String clientName;
        int port;
        int remotePort;

        public Form1(String clientName, int port)
        {
            this.port = port;
            this.clientName = clientName;
            InitializeComponent();

        }


        // connect to remote port Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                remotePort = int.Parse(IPAddressTextBox.Text);
                server = new UdpClient(port);
                remoteIP_Address = new IPEndPoint(IPAddress.Parse("127.0.0.1"), remotePort);
                server.BeginReceive(new AsyncCallback(onRecieve), server);
                button1.Enabled = false;
                button3.Enabled = true;
                button2.Enabled = true;
                messageBox.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void onRecieve(IAsyncResult ar)
        {
            try
            {
                byte[] buff = server.EndReceive(ar, ref remoteIP_Address);
                server.BeginReceive(new AsyncCallback(onRecieve), server);
                ControlInvoke(richTextBox1, () => richTextBox1.AppendText(":>> " + Encoding.ASCII.GetString(buff) + Environment.NewLine));
            }
            catch (ObjectDisposedException)
            {
                // Handle the case when the server is closed
                ControlInvoke(richTextBox1, () => richTextBox1.AppendText(":>> Connection closed" + Environment.NewLine));
            }
            catch (Exception ex)
            {
                // Handle any other exceptions
                ControlInvoke(richTextBox1, () => richTextBox1.AppendText(":>> Error: " + ex.Message + Environment.NewLine));
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button3.Enabled = false;
                button2.Enabled = false;
                server.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            server.Connect(remoteIP_Address);
            String s = messageBox.Text;
            if (String.IsNullOrEmpty(s)) return;
            await proxyDatabase.insertHistoryAsync(clientName, remotePort.ToString(), s);
            String toBeSent = clientName + ": " + s;
            server.Send(Encoding.ASCII.GetBytes(toBeSent), toBeSent.Length);
            ControlInvoke(richTextBox1, () => richTextBox1.AppendText("Me: " + s + Environment.NewLine));
            messageBox.Clear();
        }
        public static void ControlInvoke(Control control, Action function)
        {
            if (control.Disposing || control.IsDisposed)
            {
                return;
            }
            if (control.InvokeRequired)
            {
                control.Invoke(() => ControlInvoke(control, function));
                return;
            }
            function();
        }

        
    }
}
