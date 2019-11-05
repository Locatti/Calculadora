using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double resultado, valor1, valor2;
        char operacao;
        float virg;


        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            textBox2.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += ',' ;
            textBox2.Text += ',';

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
            textBox2.Text += 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
            textBox2.Text += 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
            textBox2.Text += 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
            textBox2.Text += 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
            textBox2.Text += 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
            textBox2.Text += 5;
        }


        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
            textBox2.Text += 6;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
            textBox2.Text += 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
            textBox2.Text += 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
            textBox2.Text += 9;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox2.Text);
            textBox1.Text += "+";
            operacao = '+';
            textBox2.Clear();
            

        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox2.Text);
            textBox1.Text += "-";
            operacao = '-';
            textBox2.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(textBox2.Text);
            textBox1.Text += "*";
            operacao = '*';
            textBox2.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);

            }
            catch
            {
                MessageBox.Show("Visor vazio", "Calculadora diz: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {

            valor1 = double.Parse(textBox2.Text);
            textBox1.Text += "/";
            operacao = '/';
            textBox2.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(textBox2.Text);

            switch (operacao)
            {
                case '+':
                    resultado = valor1 + valor2;
                    break;

                case '-':
                    resultado = valor1 - valor2;
                    break;

                case '*':
                    resultado = valor1 * valor2;
                    break;

                case '/':
                    if (valor2 == 0)
                    {
                        MessageBox.Show("Valor inválido");
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
            }
            textBox2.Clear();
            textBox2.Text = resultado.ToString();
            textBox1.Text += " = " + resultado;
            
        }
    }
}
