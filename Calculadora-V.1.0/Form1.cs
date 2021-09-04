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
        double primero;
        double segundo;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }
        Clases.Div obj = new Clases.Div();
        Clases.Mult obj1 = new Clases.Mult();
        Clases.Resta obj2 = new Clases.Resta();
        Clases.Suma obj3 = new Clases.Suma();
        private void button7_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text + ".";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text + "2";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text + "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text + "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtPanel.Text = txtPanel.Text + "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtPanel.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtPanel.Text.Length == 1)
                txtPanel.Text = "";
            else
                txtPanel.Text = txtPanel.Text.Substring(0, txtPanel.Text.Length - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(txtPanel.Text);
            txtPanel.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(txtPanel.Text);
            txtPanel.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(txtPanel.Text);
            txtPanel.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(txtPanel.Text);
            txtPanel.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txtPanel.Text);
            double Sum;
            double res;
            double div;
            double mult;

            switch (operacion)
            {
                case "+":
                    Sum = obj3.Summ(primero, segundo);
                    txtPanel.Text = Sum.ToString();
                    break;

                case "-":
                    res = obj2.Rest((primero), (segundo));
                    txtPanel.Text = res.ToString();
                    break;

                case "*":
                    mult = obj1.MUlti((primero), (segundo));
                    txtPanel.Text = mult.ToString();
                    break;

                case "/":
                    div = obj.DivSIon((primero), (segundo));
                    txtPanel.Text = div.ToString();
                    break;
            }
        }

        private void modosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel2.Enabled == true)
            {
                calculadoraEstandarToolStripMenuItem.Enabled = true;
            }
        }

        private void calculadoraCientificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Enabled = true;
            panel1.Visible = false;
        }

        private void calculadoraEstandarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;
            panel2.Visible = false;
            panel2.Enabled = false;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe Acercade = new AcercaDe();

            Acercade.ShowDialog();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda ayuda = new Ayuda();

            ayuda.ShowDialog();
        }
    }
    }

