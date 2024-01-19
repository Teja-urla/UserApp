using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
namespace UserAppLatest
{
    public partial class InternetConnectivity : Form
    {
        public InternetConnectivity()
        {
            InitializeComponent();
        }

        public bool pingStatus()
        {
            bool pingstatus = false;
            string hostNameOrAddress = "Google.com";
            using (Ping p = new Ping())
            {
                string data = "aaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 1000;
                try
                {
                    PingReply reply = p.Send(hostNameOrAddress, timeout, buffer);
                    pingstatus = (reply.Status == IPStatus.Success);
                }
                catch (Exception ex)
                {
                    pingstatus = false;
                }
                return pingstatus;
            }
        }

        private void InternetConnectivity_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pingStatus() == true)
            {
                internetStatusText.Text = "Internet Connected";
                wifiPic.Image = Image.FromFile("wifiConnected.png");
                internetStatusText.ForeColor = Color.Green;
            }
            else
            {
                internetStatusText.Text = "Internet Disconnected";
                wifiPic.Image = Image.FromFile("wifiDisconnected.jpg");
                internetStatusText.ForeColor = Color.Red;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
