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
<<<<<<< HEAD
        

=======
>>>>>>> 1cce52bb4fc0aeaf81af48f7b7dd53d87b8a7d91
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
<<<<<<< HEAD

        private void button10_Click(object sender, EventArgs e)
        {

            string[] arrayTexto = textBox1.Text.Split();
            int tamanhoArray = arrayTexto.Length;
            MessageBox.Show("tamanho = "+ tamanhoArray);
            for (int i = 0; i < tamanhoArray; i++)
                MessageBox.Show("conteudo da posicao"+i+"="+tamanhoArray+" nesta posicao");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string[] nomes_array = new string[5];
            nomes_array[0] = "teste";
            nomes_array[1] = "dsad";
            nomes_array[2] = "ola";
            // nomes_array[2] = textBox1.Text;

            string nomeString = String.Join("*", nomes_array);

            label1.Text = nomeString;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // passando parametros entre {}
            int numero = 20;
            string numero_formatado = String.Format("Numero{0}"," teste");
            MessageBox.Show(numero_formatado);



        }

    }
    }

