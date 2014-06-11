using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipagent
{
    public partial class MainForm : Form
    {
        private readonly Regex ipRegex = 
            new Regex(@"((25[0-5]|2[0-4][0-9]|1\d\d|\d{1,2})\.){3}(25[0-5]|2[0-4][0-9]|1\d\d|\d{1,2})",
                RegexOptions.Compiled);
        private readonly Queue<IPAddress> ipQueue = new Queue<IPAddress>();
        private readonly List<Socket> sockets = new List<Socket>();

        public MainForm()
        {
            InitializeComponent();
            IP.ValueType = typeof(IPAddress);
            Ping.ValueType = typeof(double);
            TCP80.ValueType = typeof(double);
            TCP443.ValueType = typeof(double);
            SSL.ValueType = typeof(double);
            Score.ValueType = typeof(double);
        }

        private void clipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
