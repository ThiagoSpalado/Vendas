namespace Vendas.Cliente
{
    partial class ConsultarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarClientes));
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Fazparte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Obs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Inadiplente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelefoneCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnderecoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodigoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvDados = new System.Windows.Forms.ListView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.toolStrip2.SuspendLayout();
            this.gpbOpcoes.SuspendLayout();
            this.SuspendLayout();
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
            this.tsbtnVoltar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 317);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(544, 55);
            this.toolStrip2.TabIndex = 12;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Fazparte
            // 
            this.Fazparte.Text = "Faz parte de";
            // 
            // Email
            // 
            this.Email.Text = "Email";
            // 
            // Obs
            // 
            this.Obs.Text = "Obs";
            // 
            // Inadiplente
            // 
            this.Inadiplente.DisplayIndex = 8;
            this.Inadiplente.Text = "Inadiplente";
            // 
            // Cep
            // 
            this.Cep.DisplayIndex = 7;
            this.Cep.Text = "Cep";
            // 
            // Telefone2
            // 
            this.Telefone2.DisplayIndex = 9;
            this.Telefone2.Text = "Telefone2";
            // 
            // StatusCliente
            // 
            this.StatusCliente.Text = "Ativo";
            this.StatusCliente.Width = 70;
            // 
            // TelefoneCliente
            // 
            this.TelefoneCliente.Text = "Telefone";
            this.TelefoneCliente.Width = 70;
            // 
            // EstadoCliente
            // 
            this.EstadoCliente.Text = "Estado";
            this.EstadoCliente.Width = 50;
            // 
            // Bairro
            // 
            this.Bairro.Text = "Bairro";
            this.Bairro.Width = 80;
            // 
            // EnderecoCliente
            // 
            this.EnderecoCliente.Text = "Endereço";
            this.EnderecoCliente.Width = 120;
            // 
            // NomeCliente
            // 
            this.NomeCliente.Text = "Nome";
            this.NomeCliente.Width = 93;
            // 
            // CodigoCliente
            // 
            this.CodigoCliente.Text = "Id";
            this.CodigoCliente.Width = 40;
            // 
            // lsvDados
            // 
            this.lsvDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodigoCliente,
            this.NomeCliente,
            this.EnderecoCliente,
            this.Bairro,
            this.EstadoCliente,
            this.TelefoneCliente,
            this.StatusCliente,
            this.Telefone2,
            this.Cep,
            this.Inadiplente,
            this.Obs,
            this.Email,
            this.Fazparte});
            this.lsvDados.FullRowSelect = true;
            this.lsvDados.GridLines = true;
            this.lsvDados.Location = new System.Drawing.Point(12, 80);
            this.lsvDados.MultiSelect = false;
            this.lsvDados.Name = "lsvDados";
            this.lsvDados.Size = new System.Drawing.Size(520, 218);
            this.lsvDados.TabIndex = 10;
            this.lsvDados.UseCompatibleStateImageBehavior = false;
            this.lsvDados.View = System.Windows.Forms.View.Details;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(457, 45);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(247, 14);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(285, 20);
            this.txtConsulta.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busca Por Nome:";
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Location = new System.Drawing.Point(303, 49);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(99, 17);
            this.cbAtivo.TabIndex = 8;
            this.cbAtivo.Text = "Somente ativos";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.label1);
            this.gpbOpcoes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOpcoes.ForeColor = System.Drawing.Color.Black;
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 6);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(229, 62);
            this.gpbOpcoes.TabIndex = 6;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Filtro:";
            // 
            // ConsultarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 372);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.lsvDados);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.gpbOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConsultarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarClientes";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ColumnHeader Fazparte;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Obs;
        private System.Windows.Forms.ColumnHeader Inadiplente;
        private System.Windows.Forms.ColumnHeader Cep;
        private System.Windows.Forms.ColumnHeader Telefone2;
        private System.Windows.Forms.ColumnHeader StatusCliente;
        private System.Windows.Forms.ColumnHeader TelefoneCliente;
        private System.Windows.Forms.ColumnHeader EstadoCliente;
        private System.Windows.Forms.ColumnHeader Bairro;
        private System.Windows.Forms.ColumnHeader EnderecoCliente;
        private System.Windows.Forms.ColumnHeader NomeCliente;
        private System.Windows.Forms.ColumnHeader CodigoCliente;
        private System.Windows.Forms.ListView lsvDados;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.GroupBox gpbOpcoes;
    }
}