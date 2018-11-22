namespace Carboss_Automotive__Ver.Final_
{
    partial class frmIniSistema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniSistema));
            this.labelSistema = new System.Windows.Forms.Label();
            this.progBarSistema = new System.Windows.Forms.ProgressBar();
            this.timerSistema = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelSistema
            // 
            this.labelSistema.AutoSize = true;
            this.labelSistema.BackColor = System.Drawing.Color.Transparent;
            this.labelSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSistema.ForeColor = System.Drawing.Color.Gold;
            this.labelSistema.Location = new System.Drawing.Point(65, 35);
            this.labelSistema.Name = "labelSistema";
            this.labelSistema.Size = new System.Drawing.Size(420, 29);
            this.labelSistema.TabIndex = 0;
            this.labelSistema.Text = "INICIANDO SISTEMA... AGUARDE!";
            // 
            // progBarSistema
            // 
            this.progBarSistema.Location = new System.Drawing.Point(31, 95);
            this.progBarSistema.Name = "progBarSistema";
            this.progBarSistema.Size = new System.Drawing.Size(505, 34);
            this.progBarSistema.TabIndex = 1;
            // 
            // timerSistema
            // 
            this.timerSistema.Enabled = true;
            this.timerSistema.Tick += new System.EventHandler(this.timerSistema_Tick);
            // 
            // frmIniSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 175);
            this.Controls.Add(this.progBarSistema);
            this.Controls.Add(this.labelSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIniSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IniciandoSistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSistema;
        private System.Windows.Forms.ProgressBar progBarSistema;
        private System.Windows.Forms.Timer timerSistema;
    }
}