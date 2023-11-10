using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroForms
{
    public partial class appMedia : Form
    {
        public appMedia()
        {
            InitializeComponent();
        }
           


        private void button1_Click(object sender, EventArgs e)
        {
            float nota1, nota2, nota3, nota4, media;
            bool verifica;
            string status;  

            verifica = float.TryParse(textN1.Text, out nota1);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na nota 1.");
                return;
            }

            verifica = float.TryParse(txtN2.Text, out nota2);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na nota 2.");
                return;
            }

            verifica = float.TryParse(txtN3.Text, out nota3);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na nota 3.");
                return;
            }

            verifica = float.TryParse(txtN4.Text, out nota4);
            if (verifica == false)
            {
                MessageBox.Show("Formato de valor inválido na nota 4.");
                return;
            }

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 6)
                status = "Aluno aprovado!";
            else if (media >= 4 && media < 5)
                status = "Necessário realizar recuperação";
            else
                status = "Aluno reprovado!";

            lMedia.Text = string.Format("Média: {0} - {1}", media, status);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textN1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
