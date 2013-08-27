namespace Vendas.Venda
{
    partial class ConsultarVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarVendas));
            this.cboxStatus = new System.Windows.Forms.ComboBox();
            this.txtAlterar = new System.Windows.Forms.Button();
            this.cboxPendente = new System.Windows.Forms.CheckBox();
            this.btnDetalhar = new System.Windows.Forms.Button();
            this.txtDetalhar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbtnData = new System.Windows.Forms.RadioButton();
            this.rbtNome = new System.Windows.Forms.RadioButton();
            this.listVenda = new System.Windows.Forms.ListView();
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.objListCompra = new System.Windows.Forms.ListView();
            this.Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtCalendario = new System.Windows.Forms.Button();
            this.gpbOpcoes.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxStatus
            // 
            this.cboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxStatus.FormattingEnabled = true;
            this.cboxStatus.Items.AddRange(new object[] {
            "Pendente",
            "Pago"});
            this.cboxStatus.Location = new System.Drawing.Point(601, 125);
            this.cboxStatus.Name = "cboxStatus";
            this.cboxStatus.Size = new System.Drawing.Size(102, 23);
            this.cboxStatus.TabIndex = 61;
            // 
            // txtAlterar
            // 
            this.txtAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlterar.Location = new System.Drawing.Point(711, 128);
            this.txtAlterar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAlterar.Name = "txtAlterar";
            this.txtAlterar.Size = new System.Drawing.Size(89, 20);
            this.txtAlterar.TabIndex = 60;
            this.txtAlterar.Text = "Alterar Status";
            this.txtAlterar.UseVisualStyleBackColor = true;
            this.txtAlterar.Click += new System.EventHandler(this.txtAlterar_Click);
            // 
            // cboxPendente
            // 
            this.cboxPendente.AutoSize = true;
            this.cboxPendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPendente.Location = new System.Drawing.Point(736, 51);
            this.cboxPendente.Name = "cboxPendente";
            this.cboxPendente.Size = new System.Drawing.Size(85, 20);
            this.cboxPendente.TabIndex = 59;
            this.cboxPendente.Text = "Pendente";
            this.cboxPendente.UseVisualStyleBackColor = true;
            // 
            // btnDetalhar
            // 
            this.btnDetalhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhar.Location = new System.Drawing.Point(518, 128);
            this.btnDetalhar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDetalhar.Name = "btnDetalhar";
            this.btnDetalhar.Size = new System.Drawing.Size(75, 20);
            this.btnDetalhar.TabIndex = 58;
            this.btnDetalhar.Text = "Detalhar";
            this.btnDetalhar.UseVisualStyleBackColor = true;
            this.btnDetalhar.Click += new System.EventHandler(this.btnDetalhar_Click);
            // 
            // txtDetalhar
            // 
            this.txtDetalhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalhar.Location = new System.Drawing.Point(426, 128);
            this.txtDetalhar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDetalhar.Name = "txtDetalhar";
            this.txtDetalhar.Size = new System.Drawing.Size(82, 20);
            this.txtDetalhar.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 32);
            this.label1.TabIndex = 56;
            this.label1.Text = "Para alterar o status o campo detalhar deve estar preenchido\r\n                   " +
    "           com o número da compra";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(636, 24);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(164, 20);
            this.btnConsultar.TabIndex = 55;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(384, 24);
            this.txtConsulta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(227, 20);
            this.txtConsulta.TabIndex = 54;
            this.txtConsulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbtnData);
            this.gpbOpcoes.Controls.Add(this.rbtNome);
            this.gpbOpcoes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOpcoes.ForeColor = System.Drawing.Color.Black;
            this.gpbOpcoes.Location = new System.Drawing.Point(20, 13);
            this.gpbOpcoes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gpbOpcoes.Size = new System.Drawing.Size(329, 74);
            this.gpbOpcoes.TabIndex = 53;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Filtro:";
            // 
            // rbtnData
            // 
            this.rbtnData.AutoSize = true;
            this.rbtnData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnData.Location = new System.Drawing.Point(182, 35);
            this.rbtnData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbtnData.Name = "rbtnData";
            this.rbtnData.Size = new System.Drawing.Size(62, 23);
            this.rbtnData.TabIndex = 5;
            this.rbtnData.Text = "Data";
            this.rbtnData.UseVisualStyleBackColor = true;
            this.rbtnData.CheckedChanged += new System.EventHandler(this.rbtnData_CheckedChanged);
            // 
            // rbtNome
            // 
            this.rbtNome.AutoSize = true;
            this.rbtNome.Checked = true;
            this.rbtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtNome.Location = new System.Drawing.Point(45, 35);
            this.rbtNome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbtNome.Name = "rbtNome";
            this.rbtNome.Size = new System.Drawing.Size(72, 23);
            this.rbtNome.TabIndex = 4;
            this.rbtNome.TabStop = true;
            this.rbtNome.Text = "Nome";
            this.rbtNome.UseVisualStyleBackColor = true;
            this.rbtNome.CheckedChanged += new System.EventHandler(this.rbtNome_CheckedChanged);
            // 
            // listVenda
            // 
            this.listVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Produto,
            this.Tipo,
            this.Quantidade,
            this.Preco});
            this.listVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVenda.FullRowSelect = true;
            this.listVenda.GridLines = true;
            this.listVenda.Location = new System.Drawing.Point(426, 166);
            this.listVenda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listVenda.Name = "listVenda";
            this.listVenda.Size = new System.Drawing.Size(381, 197);
            this.listVenda.TabIndex = 52;
            this.listVenda.UseCompatibleStateImageBehavior = false;
            this.listVenda.View = System.Windows.Forms.View.Details;
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            this.Produto.Width = 132;
            // 
            // Tipo
            // 
            this.Tipo.Text = "Tipo";
            this.Tipo.Width = 110;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quantidade";
            this.Quantidade.Width = 71;
            // 
            // Preco
            // 
            this.Preco.Text = "Preço";
            this.Preco.Width = 64;
            // 
            // objListCompra
            // 
            this.objListCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numero,
            this.Cliente,
            this.Data,
            this.Total,
            this.Status});
            this.objListCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objListCompra.FullRowSelect = true;
            this.objListCompra.GridLines = true;
            this.objListCompra.Location = new System.Drawing.Point(20, 95);
            this.objListCompra.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.objListCompra.Name = "objListCompra";
            this.objListCompra.Size = new System.Drawing.Size(389, 268);
            this.objListCompra.TabIndex = 51;
            this.objListCompra.UseCompatibleStateImageBehavior = false;
            this.objListCompra.View = System.Windows.Forms.View.Details;
            // 
            // Numero
            // 
            this.Numero.Text = "Nº";
            this.Numero.Width = 33;
            // 
            // Cliente
            // 
            this.Cliente.Text = "Cliente";
            this.Cliente.Width = 163;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 74;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.Width = 47;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 67;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnVoltar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 385);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(821, 55);
            this.toolStrip1.TabIndex = 50;
            this.toolStrip1.Text = "toolStrip1";
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
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(384, 48);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 62;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // txtCalendario
            // 
            this.txtCalendario.Location = new System.Drawing.Point(636, 51);
            this.txtCalendario.Name = "txtCalendario";
            this.txtCalendario.Size = new System.Drawing.Size(75, 20);
            this.txtCalendario.TabIndex = 63;
            this.txtCalendario.Text = "Calendário";
            this.txtCalendario.UseVisualStyleBackColor = true;
            this.txtCalendario.Visible = false;
            this.txtCalendario.Click += new System.EventHandler(this.txtCalendario_Click);
            // 
            // ConsultarVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 440);
            this.ControlBox = false;
            this.Controls.Add(this.txtCalendario);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.cboxStatus);
            this.Controls.Add(this.txtAlterar);
            this.Controls.Add(this.cboxPendente);
            this.Controls.Add(this.btnDetalhar);
            this.Controls.Add(this.txtDetalhar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.gpbOpcoes);
            this.Controls.Add(this.listVenda);
            this.Controls.Add(this.objListCompra);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConsultarVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Vendas";
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxStatus;
        private System.Windows.Forms.Button txtAlterar;
        private System.Windows.Forms.CheckBox cboxPendente;
        private System.Windows.Forms.Button btnDetalhar;
        private System.Windows.Forms.TextBox txtDetalhar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbtnData;
        private System.Windows.Forms.RadioButton rbtNome;
        private System.Windows.Forms.ListView listVenda;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Tipo;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.ListView objListCompra;
        private System.Windows.Forms.ColumnHeader Numero;
        private System.Windows.Forms.ColumnHeader Cliente;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button txtCalendario;
    }
}