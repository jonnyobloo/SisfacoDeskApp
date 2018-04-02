using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisfacoDeskApp.Presentation_Layer
{
    public partial class Calculator : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;
        public Calculator()
        {
            InitializeComponent();
        }

        private void closepb_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = resultadotxt.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = resultadotxt.Text + "1";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = resultadotxt.Text + "2";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = resultadotxt.Text + "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = resultadotxt.Text + "4";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = resultadotxt.Text + "5";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = resultadotxt.Text + "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = resultadotxt.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = resultadotxt.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = resultadotxt.Text + "9";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            resultadotxt.Text = resultadotxt.Text + ".";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(resultadotxt.Text);
            resultadotxt.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(resultadotxt.Text);
            resultadotxt.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(resultadotxt.Text);
            resultadotxt.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(resultadotxt.Text);
            resultadotxt.Text = "";
        }
    }
}
