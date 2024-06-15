using System.Formats.Asn1;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Schema;
namespace ChattingApp
{
    public partial class Form1 : Form
    {
        UdpClient server;
        IPEndPoint remoteIP_Address;
        int port;
        int remotePort;
        String clientName;

        public Form1(String clientName, int port, int remotePort)
        {
            this.port = port;
            this.remotePort = remotePort;
            this.clientName = clientName;
            InitializeComponent();
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            server = new UdpClient(port);
            remoteIP_Address = new IPEndPoint(IPAddress.Parse(IPAddressTextBox.Text), remotePort);
            server.BeginReceive(new AsyncCallback(onRecieve), server);
            button1.Enabled = false;
            messageBox.Enabled = true;
        }

        private void onRecieve(IAsyncResult ar)
        {
            byte[] buff = server.EndReceive(ar, ref remoteIP_Address);
            server.BeginReceive(new AsyncCallback(onRecieve), server);
            ControlInvoke(richTextBox1, () => richTextBox1.AppendText(":>> " + Encoding.ASCII.GetString(buff) + Environment.NewLine));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            server.Connect(remoteIP_Address);
            String s = messageBox.Text;
            String toBeSent = clientName + ": " + s;
            server.Send(Encoding.ASCII.GetBytes(toBeSent), toBeSent.Length);
            ControlInvoke(richTextBox1, () => richTextBox1.AppendText("Me: "+s+Environment.NewLine));
            messageBox.Clear();
        }
        public static void ControlInvoke(Control control,Action function)
        {
            if(control.Disposing || control.IsDisposed)
            {
                return;
            }
            if (control.InvokeRequired)
            {
                control.Invoke(() =>  ControlInvoke(control, function));
                return;
            }
            function();
        }
    }
}
