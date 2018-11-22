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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;

        private void menuLogout_Click(object sender, EventArgs e)
        {
            string aviso = "Deseja realmente sair ?";

            DialogResult dialogResult = MessageBox.Show(aviso, "Aviso - Carboss Automotive",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Obrigado pela Confiança !", "Aviso - Carboss Automotive");

                frmLogin form1 = new frmLogin();
                this.Hide(); // Esconder Form
                form1.ShowDialog();
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

        private void linkAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string ajuda = "Clique em (Opções) depois clique em (Novo Orçamento) e pronto, agora você poderá fazer seu orçamento.";

            MessageBox.Show(ajuda, "Aviso - Carboss Automotive",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
        }

        private void menuOrcamento_Click(object sender, EventArgs e)
        {
            frmOrcamento form4 = new frmOrcamento();
            this.Hide(); // Esconder Form
            form4.ShowDialog();
        }

        private void menuHome_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void menuHome_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void menuHome_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }
    }
}
