namespace Vendas.Produto
{
    partial class Principal_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_Produto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbnEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbnEditar,
            this.tsbtnCadastrar,
            this.tsbtnConsultar,
            this.tsbtnVoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(607, 55);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbnEditar
            // 
            this.tsbnEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbnEditar.Image")));
            this.tsbnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbnEditar.Name = "tsbnEditar";
            this.tsbnEditar.Size = new System.Drawing.Size(89, 52);
            this.tsbnEditar.Text = "Editar";
            this.tsbnEditar.Click += new System.EventHandler(this.tsbnEditar_Click);
            // 
            // tsbtnCadastrar
            // 
            this.tsbtnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCadastrar.Image")));
            this.tsbtnCadastrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCadastrar.Name = "tsbtnCadastrar";
            this.tsbtnCadastrar.Size = new System.Drawing.Size(109, 52);
            this.tsbtnCadastrar.Text = "Cadastrar";
            this.tsbtnCadastrar.Click += new System.EventHandler(this.tsbtnCadastrar_Click);
            // 
            // tsbtnConsultar
            // 
            this.tsbtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConsultar.Image")));
            this.tsbtnConsultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConsultar.Name = "tsbtnConsultar";
            this.tsbtnConsultar.Size = new System.Drawing.Size(110, 52);
            this.tsbtnConsultar.Text = "Consultar";
            this.tsbtnConsultar.Click += new System.EventHandler(this.tsbtnConsultar_Click);
            // 
            // tsbtnVoltar
            // 
            this.tsbtnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnVoltar.Image")));
            this.tsbtnVoltar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnVoltar.Name = "tsbtnVoltar";
            this.tsbtnVoltar.Size = new System.Drawing.Size(90, 52);
            this.tsbtnVoltar.Text = "Voltar";
            this.tsbtnVoltar.Click += new System.EventHandler(this.tsbtnVoltar_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSair});
            this.toolStrip2.Location = new System.Drawing.Point(0, 470);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(607, 55);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbtnSair
            // 
            this.tsbtnSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSair.Image")));
            this.tsbtnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSair.Name = "tsbtnSair";
            this.tsbtnSair.Size = new System.Drawing.Size(78, 52);
            this.tsbtnSair.Text = "Sair";
            this.tsbtnSair.Click += new System.EventHandler(this.tsbtnSair_Click);
            // 
            // Principal_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 525);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "Principal_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbnEditar;
        public System.Windows.Forms.ToolStripButton tsbtnCadastrar;
        public System.Windows.Forms.ToolStripButton tsbtnConsultar;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStripButton tsbtnSair;
    }
}