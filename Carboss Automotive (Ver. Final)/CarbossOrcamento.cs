using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carboss_Automotive__Ver.Final_
{
    public partial class frmOrcamento : Form
    {
        public frmOrcamento()
        {
            InitializeComponent();
        }

        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;

        private void menuHome_Click(object sender, EventArgs e)
        {
            string aviso = "Deseja voltar para o inicio ?";

            DialogResult dialogResult = MessageBox.Show(aviso, "Aviso - Carboss Automotive",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                frmHome form3 = new frmHome();
                this.Hide(); // Esconder Form
                form3.ShowDialog();
            }

            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void menuSobre_Click(object sender, EventArgs e)
        {
            string sobre = "Criado e desenvolvido por Felipe Soares e Vitor Barbosa.";

            MessageBox.Show(sobre, "Carboss Automotive",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
        }

        private void menuOrcamento_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void menuOrcamento_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void menuOrcamento_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            string resultado = "O Total do seu Orçamento ficou em R$";

            int total = 0;

            if (ckInspecao.Checked == true)
                total = total + 15;

            if (ckLubrificacao.Checked == true)
                total = total + 18;

            if (ckPneu.Checked == true)
                total = total + 20;

            if (ckOleo.Checked == true)
                total = total + 26;

            if (ckRadiador.Checked == true)
                total = total + 30;

            if (ckTransmissao.Checked == true)
                total = total + 80;

            if (ckSilenciador.Checked == true)
                total = total + 100;


            MessageBox.Show(resultado + total.ToString(), "Carboss Automotive",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);

        }

        
    }
}
