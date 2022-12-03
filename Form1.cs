using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        int globaldeger = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = globaldeger.ToString();
            globaldeger = 555;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Text = globaldeger.ToString();
            globaldeger = 888;

        }
    }
}
