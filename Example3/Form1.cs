using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void a(object sender, MouseEventArgs e)
        {
            MessageBox.Show("ok");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            informationLabel.Text = "button1 clicked!";
        }
    }
}
