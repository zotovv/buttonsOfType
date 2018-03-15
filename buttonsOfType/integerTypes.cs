using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttonsOfType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -32768 till 32767", "Range");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 till 255", "Range");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -2147483648 till 2147483647", "Range");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 9223372036854775808 till 9223372036854775807", "Range");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -127 till 128", "Range");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 till 65535", "Range");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 till 4294967295", "Range");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 till 18466744073709551615", "Range");
        }
    }
}
