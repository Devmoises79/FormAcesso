using System.Windows.Forms;

namespace WindowsFormsApp
{
    partial class Form1
    {
        private TextBox txtNome;
        private TextBox txtIdade;
        private Label lblResultado;
        private Button btnVerificar;

        private void InitializeComponent()
        {
            this.txtNome = new TextBox();
            this.txtIdade = new TextBox();
            this.btnVerificar = new Button();
            this.lblResultado = new Label();

            // txtNome
            this.txtNome.Location = new System.Drawing.Point(30, 30);
            this.txtNome.Size = new System.Drawing.Size(200, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Digite seu nome";

            // txtIdade
            this.txtIdade.Location = new System.Drawing.Point(30, 70);
            this.txtIdade.Size = new System.Drawing.Size(200, 23);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.PlaceholderText = "Digite sua idade";

            // btnVerificar
            this.btnVerificar.Location = new System.Drawing.Point(30, 110);
            this.btnVerificar.Size = new System.Drawing.Size(200, 30);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Text = "Verificar Acesso";
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);

            // lblResultado
            this.lblResultado.Location = new System.Drawing.Point(30, 160);
            this.lblResultado.Size = new System.Drawing.Size(250, 40);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Text = "";

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "Verify Acess";
        }
    }
}
