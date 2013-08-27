namespace Vendas
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblMensagem = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnClientes = new System.Windows.Forms.ToolStripButton();
            this.tsbProduto = new System.Windows.Forms.ToolStripButton();
            this.tsbVendas = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(12, 128);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(327, 22);
            this.lblMensagem.TabIndex = 5;
            this.lblMensagem.Text = "Clique na opção desejada e aguarde!";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSair});
            this.toolStrip2.Location = new System.Drawing.Point(0, 203);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(353, 55);
            this.toolStrip2.TabIndex = 4;
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnClientes,
            this.tsbProduto,
            this.tsbVendas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(353, 69);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnClientes
            // 
            this.tsbtnClientes.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClientes.Image")));
            this.tsbtnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClientes.Name = "tsbtnClientes";
            this.tsbtnClientes.Size = new System.Drawing.Size(101, 66);
            this.tsbtnClientes.Text = "Clientes";
            this.tsbtnClientes.Click += new System.EventHandler(this.tsbtnClientes_Click);
            // 
            // tsbProduto
            // 
            this.tsbProduto.Image = ((System.Drawing.Image)(resources.GetObject("tsbProduto.Image")));
            this.tsbProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProduto.Name = "tsbProduto";
            this.tsbProduto.Size = new System.Drawing.Size(121, 66);
            this.tsbProduto.Text = "Produtos";
            this.tsbProduto.Click += new System.EventHandler(this.tsbProduto_Click);
            // 
            // tsbVendas
            // 
            this.tsbVendas.Image = ((System.Drawing.Image)(resources.GetObject("tsbVendas.Image")));
            this.tsbVendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVendas.Name = "tsbVendas";
            this.tsbVendas.Size = new System.Drawing.Size(106, 66);
            this.tsbVendas.Text = "Vendas";
            this.tsbVendas.Click += new System.EventHandler(this.tsbVendas_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 258);
            this.ControlBox = false;
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eco 1.0";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnClientes;
        private System.Windows.Forms.ToolStripButton tsbProduto;
        private System.Windows.Forms.ToolStripButton tsbVendas;
    }
}

