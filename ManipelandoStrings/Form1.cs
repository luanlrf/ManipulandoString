using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipelandoStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.ToUpper();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.ToLower();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.Substring(3) ;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           int posicao   = textBox1.Text.IndexOf("teste");
            

            if(posicao == -1)
            {
                label1.Text = "nao localizado";
            }else label1.Text = "" + posicao;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("teste"))
                MessageBox.Show("sim");
            else
                MessageBox.Show("nao");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.EndsWith("teste"))
                MessageBox.Show("sim");
            else
                MessageBox.Show("nao");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.PadLeft(3, '*');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text.PadRight(30, '*');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //trim vai eliminar os espaços do label1
            label1.Text = "resultado : "+textBox1.Text.Trim();
        }
    }
    }

