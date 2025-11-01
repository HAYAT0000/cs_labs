using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pnkt1_Click(object sender, EventArgs e)
        {

        }
        private void pnkt2_Click(object sender, EventArgs e)
        {

        }

        private void ppnkt1_1_Click(object sender, EventArgs e)
        {
            otcritie();
            MessageBox.Show("Вы находитесь в подпункте 1.1");
            ppnkt1_1.Enabled = false;
        }

        private void ppnkt1_2_Click(object sender, EventArgs e)
        {
            otcritie();
            MessageBox.Show("Вы находитесь в подпункте 1.2");
            ppnkt1_2.Enabled = false;
        }

        private void ppnkt2_1_Click(object sender, EventArgs e)
        {
            otcritie();
            MessageBox.Show("Вы находитесь в подпункте 2.1");
            ppnkt2_1.Enabled = false;
        }

        private void ppnkt2_2_Click(object sender, EventArgs e)
        {
            otcritie();
            MessageBox.Show("Вы находитесь в подпункте 2.2");
            ppnkt2_2.Enabled = false;
        }

        public void otcritie()
        {
            ppnkt1_1.Enabled = true;
            ppnkt1_2.Enabled = true;
            ppnkt2_1.Enabled = true;
            ppnkt2_2.Enabled = true;
        }


    }
}
