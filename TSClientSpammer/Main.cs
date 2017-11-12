using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSClientSpammer {
    public partial class Main : Form {
        private static string address;
        private static int clientcount;
        public Main() {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
            address = textBox1.Text;
            clientcount = Convert.ToInt32(textBox2.Text);
            MessageBox.Show("Address: " + address + "\r\n" + "Clients: " + clientcount);
        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }
}
