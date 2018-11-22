namespace Carboss_Automotive__Ver.Final_
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuHome = new System.Windows.Forms.MenuStrip();
            this.menuOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrcamento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBemVindo = new System.Windows.Forms.Label();
            this.linkAjuda = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHome
            // 
            this.menuHome.BackColor = System.Drawing.Color.DarkOrchid;
            this.menuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpcoes,
            this.menuSobre,
            this.menuLogout});
            this.menuHome.Location = new System.Drawing.Point(0, 0);
            this.menuHome.Name = "menuHome";
            this.menuHome.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuHome.Size = new System.Drawing.Size(585, 24);
            this.menuHome.TabIndex = 0;
            this.menuHome.Text = "menuStrip1";
            this.menuHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuHome_MouseDown);
            this.menuHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuHome_MouseMove);
            this.menuHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuHome_MouseUp);
            // 
            // menuOpcoes
            // 
            this.menuOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOrcamento});
            this.menuOpcoes.Name = "menuOpcoes";
            this.menuOpcoes.Size = new System.Drawing.Size(59, 20);
            this.menuOpcoes.Text = "Opções";
            // 
            // menuOrcamento
            // 
            this.menuOrcamento.Name = "menuOrcamento";
            this.menuOrcamento.Size = new System.Drawing.Size(166, 22);
            this.menuOrcamento.Text = "Novo Orçamento";
            this.menuOrcamento.Click += new System.EventHandler(this.menuOrcamento_Click);
            // 
            // menuSobre
            // 
            this.menuSobre.Name = "menuSobre";
            this.menuSobre.Size = new System.Drawing.Size(49, 20);
            this.menuSobre.Text = "Sobre";
            this.menuSobre.Click += new System.EventHandler(this.menuSobre_Click);
            // 
            // menuLogout
            // 
            this.menuLogout.Name = "menuLogout";
            this.menuLogout.Size = new System.Drawing.Size(57, 20);
            this.menuLogout.Text = "Logout";
            this.menuLogout.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // labelBemVindo
            // 
            this.labelBemVindo.AutoSize = true;
            this.labelBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.labelBemVindo.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBemVindo.ForeColor = System.Drawing.Color.Honeydew;
            this.labelBemVindo.Location = new System.Drawing.Point(81, 37);
            this.labelBemVindo.Name = "labelBemVindo";
            this.labelBemVindo.Size = new System.Drawing.Size(401, 33);
            this.labelBemVindo.TabIndex = 1;
            this.labelBemVindo.Text = "Bem Vindo ao Carboss Automotive";
            // 
            // linkAjuda
            // 
            this.linkAjuda.AutoSize = true;
            this.linkAjuda.BackColor = System.Drawing.Color.Transparent;
            this.linkAjuda.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAjuda.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkAjuda.Location = new System.Drawing.Point(165, 345);
            this.linkAjuda.Name = "linkAjuda";
            this.linkAjuda.Size = new System.Drawing.Size(262, 15);
            this.linkAjuda.TabIndex = 2;
            this.linkAjuda.TabStop = true;
            this.linkAjuda.Text = "Quer começa um novo orçamento ? Clique Aqui";
            this.linkAjuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAjuda_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(509, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Versão 3.0";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkAjuda);
            this.Controls.Add(this.labelBemVindo);
            this.Controls.Add(this.menuHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuHome;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Home - Carboss Automotive";
            this.menuHome.ResumeLayout(false);
            this.menuHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHome;
        private System.Windows.Forms.ToolStripMenuItem menuOpcoes;
        private System.Windows.Forms.ToolStripMenuItem menuSobre;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuOrcamento;
        private System.Windows.Forms.Label labelBemVindo;
        private System.Windows.Forms.LinkLabel linkAjuda;
        private System.Windows.Forms.Label label1;
    }
}