using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_V._1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text + ".";
        }
    }
}
