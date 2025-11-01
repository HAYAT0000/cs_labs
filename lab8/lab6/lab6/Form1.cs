using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
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

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string Nameofclick = "";
            if (e.Button == MouseButtons.Left) Nameofclick = "лкм";
            else if (e.Button == MouseButtons.Right) Nameofclick = "пкм";
            else if (e.Button == MouseButtons.Middle) Nameofclick = "скм";
            Newlabel(Nameofclick,e.X,e.Y);
        }
        private void Newlabel(string text, int x, int y)
        {
            Label mylabel = new Label();
            mylabel.Text = text;
            mylabel.Location = new Point(x, y);
            this.Controls.Add(mylabel);
        }
    }
}
