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
    public partial class frmIniSistema : Form
    {
        public frmIniSistema()
        {
            InitializeComponent();
        }

        private void timerSistema_Tick(object sender, EventArgs e)
        {

            if(progBarSistema.Value < 100)
            {
                progBarSistema.Value = progBarSistema.Value + 2;
            }

            else
            { 
                timerSistema.Dispose();
                frmHome form3 = new frmHome();
                this.Hide(); // Esconder Form
                form3.ShowDialog();
            }

        }
    }
}
