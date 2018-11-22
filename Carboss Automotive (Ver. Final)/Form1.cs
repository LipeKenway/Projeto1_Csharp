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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string erroLogin = "Preencha todos os campos !!!";
            string sucessoLogin = "Bem Vindo ao Sistema Carboss Automotive !";
            string usuarioSenha = "Usuário ou Senha Incorretos !!!";

           

            if (txtLogin.Text == "" || maskSenha.Text == "")
            {
                    MessageBox.Show(erroLogin, "Aviso - Carboss Automotive",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }

            if (txtLogin.Text == "Admin" && maskSenha.Text == "Admin")
            {
                MessageBox.Show(sucessoLogin, "Aviso - Carboss Automotive",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

                // Limpar campos de Login e Senha //
                txtLogin.Text = "";
                maskSenha.Text = "";

                // Depois de Clicar em Entrar, ir para o proximo form //
                frmIniSistema form2 = new frmIniSistema();
                this.Hide(); // Esconder Form
                form2.ShowDialog();

            }

            else if (txtLogin.Text != "Admin" || maskSenha.Text != "Admin")
            {
                    MessageBox.Show(usuarioSenha, "Aviso - Carboss Automotive",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            
               
        }

        private void linkAjuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string ajuda = "Login: Admin & Senha: Admin";

            MessageBox.Show(ajuda, "Aviso - Carboss Automotive",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string sair = "Deseja Realmente Sair ?";

            DialogResult dialogResult = MessageBox.Show(sair, "Aviso - Carboss Automotive",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
