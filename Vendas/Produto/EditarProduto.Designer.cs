namespace Vendas.Produto
{
    partial class EditarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProduto));
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.rbtNome = new System.Windows.Forms.RadioButton();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblNomeLivro = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAlterar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.errorPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbCombo = new System.Windows.Forms.CheckBox();
            this.cmbProdutos = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbOpcoes.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Location = new System.Drawing.Point(87, 206);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(15, 14);
            this.cbAtivo.TabIndex = 60;
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(345, 67);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 57;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtEditar
            // 
            this.txtEditar.Location = new System.Drawing.Point(192, 14);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(228, 20);
            this.txtEditar.TabIndex = 56;
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbtnId);
            this.gpbOpcoes.Controls.Add(this.rbtNome);
            this.gpbOpcoes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOpcoes.ForeColor = System.Drawing.Color.Black;
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 6);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(159, 48);
            this.gpbOpcoes.TabIndex = 58;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Filtro:";
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Location = new System.Drawing.Point(97, 16);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(38, 20);
            this.rbtnId.TabIndex = 4;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "Id";
            this.rbtnId.UseVisualStyleBackColor = true;
            // 
            // rbtNome
            // 
            this.rbtNome.AutoSize = true;
            this.rbtNome.Checked = true;
            this.rbtNome.Location = new System.Drawing.Point(6, 16);
            this.rbtNome.Name = "rbtNome";
            this.rbtNome.Size = new System.Drawing.Size(63, 20);
            this.rbtNome.TabIndex = 2;
            this.rbtNome.TabStop = true;
            this.rbtNome.Text = "Nome";
            this.rbtNome.UseVisualStyleBackColor = true;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPaginas.Location = new System.Drawing.Point(203, 166);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(93, 18);
            this.lblPaginas.TabIndex = 55;
            this.lblPaginas.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(317, 167);
            this.txtQuantidade.MaxLength = 6;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(60, 20);
            this.txtQuantidade.TabIndex = 50;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F);
            this.lblStatus.Location = new System.Drawing.Point(12, 206);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 18);
            this.lblStatus.TabIndex = 53;
            this.lblStatus.Text = "Ativo:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAno.Location = new System.Drawing.Point(11, 166);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(54, 18);
            this.lblAno.TabIndex = 54;
            this.lblAno.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(87, 167);
            this.txtPreco.MaxLength = 6;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(60, 20);
            this.txtPreco.TabIndex = 49;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAutor.Location = new System.Drawing.Point(12, 126);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(48, 18);
            this.lblAutor.TabIndex = 52;
            this.lblAutor.Text = "Texto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(87, 131);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(333, 20);
            this.txtTexto.TabIndex = 48;
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLivro.Location = new System.Drawing.Point(12, 95);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(54, 18);
            this.lblNomeLivro.TabIndex = 51;
            this.lblNomeLivro.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(87, 96);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(333, 20);
            this.txtNome.TabIndex = 47;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAlterar,
            this.tsbtnVoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 245);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(441, 55);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAlterar
            // 
            this.tsbtnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAlterar.Image")));
            this.tsbtnAlterar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAlterar.Name = "tsbtnAlterar";
            this.tsbtnAlterar.Size = new System.Drawing.Size(140, 52);
            this.tsbtnAlterar.Text = "Alterar e Gravar";
            this.tsbtnAlterar.Click += new System.EventHandler(this.tsbtnAlterar_Click);
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
            // errorPro
            // 
            this.errorPro.ContainerControl = this;
            // 
            // cbCombo
            // 
            this.cbCombo.AutoSize = true;
            this.cbCombo.Location = new System.Drawing.Point(280, 71);
            this.cbCombo.Name = "cbCombo";
            this.cbCombo.Size = new System.Drawing.Size(59, 17);
            this.cbCombo.TabIndex = 112;
            this.cbCombo.Text = "Combo";
            this.cbCombo.UseVisualStyleBackColor = true;
            // 
            // cmbProdutos
            // 
            this.cmbProdutos.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "B",
            "C"});
            this.cmbProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdutos.FormattingEnabled = true;
            this.cmbProdutos.Location = new System.Drawing.Point(192, 40);
            this.cmbProdutos.Name = "cmbProdutos";
            this.cmbProdutos.Size = new System.Drawing.Size(228, 21);
            this.cmbProdutos.TabIndex = 111;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(87, 71);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(64, 20);
            this.txtId.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 113;
            this.label3.Text = "Id:";
            // 
            // EditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 300);
            this.ControlBox = false;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCombo);
            this.Controls.Add(this.cmbProdutos);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.gpbOpcoes);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblNomeLivro);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProduto";
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbtnId;
        private System.Windows.Forms.RadioButton rbtNome;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label lblNomeLivro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbtnAlterar;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
        private System.Windows.Forms.ErrorProvider errorPro;
        private System.Windows.Forms.CheckBox cbCombo;
        private System.Windows.Forms.ComboBox cmbProdutos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
    }
}