namespace Vendas.Venda
{
    partial class CadastrarVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarVendas));
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxProduto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxCliente = new System.Windows.Forms.ComboBox();
            this.CboxStatus = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtQnt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.objListCompra = new System.Windows.Forms.ListView();
            this.Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(498, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.Control;
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(554, 7);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(69, 20);
            this.txtPreco.TabIndex = 61;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxProduto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboxCliente);
            this.groupBox1.Controls.Add(this.CboxStatus);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.btnInserir);
            this.groupBox1.Controls.Add(this.lblEndereco);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.txtQnt);
            this.groupBox1.Location = new System.Drawing.Point(468, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 290);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // cboxProduto
            // 
            this.cboxProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProduto.FormattingEnabled = true;
            this.cboxProduto.Location = new System.Drawing.Point(13, 71);
            this.cboxProduto.Name = "cboxProduto";
            this.cboxProduto.Size = new System.Drawing.Size(121, 21);
            this.cboxProduto.TabIndex = 63;
            this.cboxProduto.SelectedIndexChanged += new System.EventHandler(this.cboxProduto_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "Status do Pedido:";
            // 
            // cboxCliente
            // 
            this.cboxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCliente.FormattingEnabled = true;
            this.cboxCliente.Location = new System.Drawing.Point(13, 28);
            this.cboxCliente.Name = "cboxCliente";
            this.cboxCliente.Size = new System.Drawing.Size(121, 21);
            this.cboxCliente.TabIndex = 52;
            this.cboxCliente.SelectedIndexChanged += new System.EventHandler(this.cboxCliente_SelectedIndexChanged);
            // 
            // CboxStatus
            // 
            this.CboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxStatus.FormattingEnabled = true;
            this.CboxStatus.Items.AddRange(new object[] {
            "Pendente",
            "Pago"});
            this.CboxStatus.Location = new System.Drawing.Point(14, 216);
            this.CboxStatus.Name = "CboxStatus";
            this.CboxStatus.Size = new System.Drawing.Size(120, 21);
            this.CboxStatus.TabIndex = 50;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(42, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 17);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Cliente:";
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(14, 142);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(120, 23);
            this.btnInserir.TabIndex = 49;
            this.btnInserir.Text = "Inserir Produto";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(42, 52);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(63, 17);
            this.lblEndereco.TabIndex = 6;
            this.lblEndereco.Text = "Produto:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(60, 255);
            this.txtTotal.MaxLength = 6;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(74, 20);
            this.txtTotal.TabIndex = 38;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCidade.Location = new System.Drawing.Point(30, 95);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(93, 18);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Quantidade:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEstado.Location = new System.Drawing.Point(10, 255);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(44, 18);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Total:";
            // 
            // txtQnt
            // 
            this.txtQnt.Location = new System.Drawing.Point(60, 116);
            this.txtQnt.MaxLength = 6;
            this.txtQnt.Name = "txtQnt";
            this.txtQnt.Size = new System.Drawing.Size(30, 20);
            this.txtQnt.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(250, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(12, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "Cliente";
            // 
            // txtProduto
            // 
            this.txtProduto.BackColor = System.Drawing.SystemColors.Control;
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(319, 7);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.ReadOnly = true;
            this.txtProduto.Size = new System.Drawing.Size(164, 20);
            this.txtProduto.TabIndex = 57;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(75, 7);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(160, 20);
            this.txtCliente.TabIndex = 56;
            // 
            // objListCompra
            // 
            this.objListCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numero,
            this.Produto,
            this.Quantidade,
            this.Preco});
            this.objListCompra.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objListCompra.FullRowSelect = true;
            this.objListCompra.GridLines = true;
            this.objListCompra.Location = new System.Drawing.Point(15, 43);
            this.objListCompra.Name = "objListCompra";
            this.objListCompra.Size = new System.Drawing.Size(431, 290);
            this.objListCompra.TabIndex = 55;
            this.objListCompra.UseCompatibleStateImageBehavior = false;
            this.objListCompra.View = System.Windows.Forms.View.Details;
            // 
            // Numero
            // 
            this.Numero.Text = "Nº";
            this.Numero.Width = 33;
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            this.Produto.Width = 280;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Qtde";
            this.Quantidade.Width = 42;
            // 
            // Preco
            // 
            this.Preco.Text = "Preço";
            this.Preco.Width = 72;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnGravar,
            this.tsbtnVoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 354);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(635, 55);
            this.toolStrip1.TabIndex = 54;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnGravar
            // 
            this.tsbtnGravar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGravar.Image")));
            this.tsbtnGravar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGravar.Name = "tsbtnGravar";
            this.tsbtnGravar.Size = new System.Drawing.Size(139, 52);
            this.tsbtnGravar.Text = "Gravar Compra";
            this.tsbtnGravar.Click += new System.EventHandler(this.tsbtnGravar_Click);
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
            // CadastrarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 409);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.objListCompra);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastrarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Vendas";
            this.Load += new System.EventHandler(this.CadastrarVendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboxStatus;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtQnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ListView objListCompra;
        private System.Windows.Forms.ColumnHeader Numero;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbtnGravar;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
        private System.Windows.Forms.ComboBox cboxProduto;
        private System.Windows.Forms.ComboBox cboxCliente;
    }
}