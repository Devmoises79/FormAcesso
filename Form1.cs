using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = int.Parse(txtIdade.Text);

            bool nomeNaLista = nome == "Moisés" || nome == "Ana" || nome == "Carlos";

            if (idade < 18)
            {
                lblResultado.Text = "Entrada negada: você é menor de idade.";
            }
            else if (!nomeNaLista)
            {
                lblResultado.Text = "Entrada negada: seu nome não está na lista.";
            }
            else
            {
                lblResultado.Text = $"Bem-vindo ao evento, {nome}!";
            }
        }
    }
}
