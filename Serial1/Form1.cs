using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Serial1
{
    public partial class Serial1 : Form
    {
        public Serial1()
        {
            InitializeComponent();
            getAvailablePortNames();
        }

        private void Serial1_Load(object sender, EventArgs e)
        {

        }

        void getAvailablePortNames()
        {
            String[] ports = SerialPort.GetPortNames();
            comboBoxPort.Items.AddRange(ports);

        }
    }
}
