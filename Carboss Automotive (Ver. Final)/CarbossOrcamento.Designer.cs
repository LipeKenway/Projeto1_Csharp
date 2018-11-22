namespace Carboss_Automotive__Ver.Final_
{
    partial class frmOrcamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrcamento));
            this.menuOrcamento = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupOpcoes = new System.Windows.Forms.GroupBox();
            this.ckSilenciador = new System.Windows.Forms.CheckBox();
            this.ckOleo = new System.Windows.Forms.CheckBox();
            this.ckTransmissao = new System.Windows.Forms.CheckBox();
            this.ckPneu = new System.Windows.Forms.CheckBox();
            this.ckRadiador = new System.Windows.Forms.CheckBox();
            this.ckLubrificacao = new System.Windows.Forms.CheckBox();
            this.ckInspecao = new System.Windows.Forms.CheckBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.menuOrcamento.SuspendLayout();
            this.groupOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuOrcamento
            // 
            this.menuOrcamento.BackColor = System.Drawing.Color.DarkOrange;
            this.menuOrcamento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome,
            this.menuSobre});
            this.menuOrcamento.Location = new System.Drawing.Point(0, 0);
            this.menuOrcamento.Name = "menuOrcamento";
            this.menuOrcamento.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuOrcamento.Size = new System.Drawing.Size(531, 24);
            this.menuOrcamento.TabIndex = 0;
            this.menuOrcamento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuOrcamento_MouseDown);
            this.menuOrcamento.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuOrcamento_MouseMove);
            this.menuOrcamento.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuOrcamento_MouseUp);
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(52, 20);
            this.menuHome.Text = "Home";
            this.menuHome.Click += new System.EventHandler(this.menuHome_Click);
            // 
            // menuSobre
            // 
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(49, 20);
            this.menuSobre.Text = "Sobre";
            this.menuSobre.Click += new System.EventHandler(this.menuSobre_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // groupOpcoes
            // 
            this.groupOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.groupOpcoes.Controls.Add(this.ckSilenciador);
            this.groupOpcoes.Controls.Add(this.ckOleo);
            this.groupOpcoes.Controls.Add(this.ckTransmissao);
            this.groupOpcoes.Controls.Add(this.ckPneu);
            this.groupOpcoes.Controls.Add(this.ckRadiador);
            this.groupOpcoes.Controls.Add(this.ckLubrificacao);
            this.groupOpcoes.Controls.Add(this.ckInspecao);
            this.groupOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupOpcoes.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupOpcoes.Location = new System.Drawing.Point(10, 50);
            this.groupOpcoes.Name = "groupOpcoes";
            this.groupOpcoes.Size = new System.Drawing.Size(242, 223);
            this.groupOpcoes.TabIndex = 1;
            this.groupOpcoes.TabStop = false;
            this.groupOpcoes.Text = "Menu de Opções";
            // 
            // ckSilenciador
            // 
            this.ckSilenciador.AutoSize = true;
            this.ckSilenciador.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSilenciador.Location = new System.Drawing.Point(6, 195);
            this.ckSilenciador.Name = "ckSilenciador";
            this.ckSilenciador.Size = new System.Drawing.Size(234, 19);
            this.ckSilenciador.TabIndex = 0;
            this.ckSilenciador.Text = "Substituição do Silenciador: R$ 100,00";
            this.ckSilenciador.UseVisualStyleBackColor = true;
            // 
            // ckOleo
            // 
            this.ckOleo.AutoSize = true;
            this.ckOleo.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckOleo.Location = new System.Drawing.Point(6, 117);
            this.ckOleo.Name = "ckOleo";
            this.ckOleo.Size = new System.Drawing.Size(155, 19);
            this.ckOleo.TabIndex = 0;
            this.ckOleo.Text = "Troca de Óleo: R$ 26,00";
            this.ckOleo.UseVisualStyleBackColor = true;
            // 
            // ckTransmissao
            // 
            this.ckTransmissao.AutoSize = true;
            this.ckTransmissao.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTransmissao.Location = new System.Drawing.Point(6, 169);
            this.ckTransmissao.Name = "ckTransmissao";
            this.ckTransmissao.Size = new System.Drawing.Size(236, 19);
            this.ckTransmissao.TabIndex = 0;
            this.ckTransmissao.Text = "Nivelamento de Transmissão: R$ 80,00";
            this.ckTransmissao.UseVisualStyleBackColor = true;
            // 
            // ckPneu
            // 
            this.ckPneu.AutoSize = true;
            this.ckPneu.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckPneu.Location = new System.Drawing.Point(6, 91);
            this.ckPneu.Name = "ckPneu";
            this.ckPneu.Size = new System.Drawing.Size(198, 19);
            this.ckPneu.TabIndex = 0;
            this.ckPneu.Text = "Alinhamento do Pneu: R$ 20,00";
            this.ckPneu.UseVisualStyleBackColor = true;
            // 
            // ckRadiador
            // 
            this.ckRadiador.AutoSize = true;
            this.ckRadiador.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckRadiador.Location = new System.Drawing.Point(6, 143);
            this.ckRadiador.Name = "ckRadiador";
            this.ckRadiador.Size = new System.Drawing.Size(192, 19);
            this.ckRadiador.TabIndex = 0;
            this.ckRadiador.Text = "Revisão do Radiador: R$ 30,00";
            this.ckRadiador.UseVisualStyleBackColor = true;
            // 
            // ckLubrificacao
            // 
            this.ckLubrificacao.AutoSize = true;
            this.ckLubrificacao.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckLubrificacao.Location = new System.Drawing.Point(6, 65);
            this.ckLubrificacao.Name = "ckLubrificacao";
            this.ckLubrificacao.Size = new System.Drawing.Size(207, 19);
            this.ckLubrificacao.TabIndex = 0;
            this.ckLubrificacao.Text = "Revisão de Lubrificação: R$ 18,00";
            this.ckLubrificacao.UseVisualStyleBackColor = true;
            // 
            // ckInspecao
            // 
            this.ckInspecao.AutoSize = true;
            this.ckInspecao.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckInspecao.Location = new System.Drawing.Point(6, 39);
            this.ckInspecao.Name = "ckInspecao";
            this.ckInspecao.Size = new System.Drawing.Size(128, 19);
            this.ckInspecao.TabIndex = 0;
            this.ckInspecao.Text = "Inspeção: R$ 15,00";
            this.ckInspecao.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(10, 279);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(242, 23);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Finalizar seu Orçamento";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 306);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.groupOpcoes);
            this.Controls.Add(this.menuOrcamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuOrcamento;
            this.Name = "frmOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarbossOrcamento";
            this.menuOrcamento.ResumeLayout(false);
            this.menuOrcamento.PerformLayout();
            this.groupOpcoes.ResumeLayout(false);
            this.groupOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuOrcamento;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.ToolStripMenuItem menuSobre;
        private System.Windows.Forms.GroupBox groupOpcoes;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.CheckBox ckSilenciador;
        private System.Windows.Forms.CheckBox ckOleo;
        private System.Windows.Forms.CheckBox ckTransmissao;
        private System.Windows.Forms.CheckBox ckPneu;
        private System.Windows.Forms.CheckBox ckRadiador;
        private System.Windows.Forms.CheckBox ckLubrificacao;
        private System.Windows.Forms.CheckBox ckInspecao;
    }
}