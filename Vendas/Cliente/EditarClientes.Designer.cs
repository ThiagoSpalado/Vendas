namespace Vendas.Cliente
{
    partial class EditarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarClientes));
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbtnNome = new System.Windows.Forms.RadioButton();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.cbInadiplente = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPCM = new System.Windows.Forms.Label();
            this.txtPCM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAlterar = new System.Windows.Forms.ToolStripButton();
            this.lblCep = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbPessoas = new System.Windows.Forms.ComboBox();
            this.cbCombo = new System.Windows.Forms.CheckBox();
            this.gpbOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbtnNome);
            this.gpbOpcoes.Controls.Add(this.rbtnId);
            this.gpbOpcoes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOpcoes.ForeColor = System.Drawing.Color.Black;
            this.gpbOpcoes.Location = new System.Drawing.Point(22, 6);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(174, 43);
            this.gpbOpcoes.TabIndex = 105;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Filtro:";
            // 
            // rbtnNome
            // 
            this.rbtnNome.AutoSize = true;
            this.rbtnNome.Location = new System.Drawing.Point(82, 17);
            this.rbtnNome.Name = "rbtnNome";
            this.rbtnNome.Size = new System.Drawing.Size(63, 20);
            this.rbtnNome.TabIndex = 1;
            this.rbtnNome.TabStop = true;
            this.rbtnNome.Text = "Nome";
            this.rbtnNome.UseVisualStyleBackColor = true;
            // 
            // rbtnId
            // 
            this.rbtnId.Checked = true;
            this.rbtnId.Location = new System.Drawing.Point(29, 15);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(47, 24);
            this.rbtnId.TabIndex = 2;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "Id";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(411, 135);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 83;
            // 
            // txtEditar
            // 
            this.txtEditar.Location = new System.Drawing.Point(202, 13);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(309, 20);
            this.txtEditar.TabIndex = 103;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(444, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 23);
            this.btnBuscar.TabIndex = 104;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Location = new System.Drawing.Point(402, 309);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(15, 14);
            this.cbAtivo.TabIndex = 95;
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // cbInadiplente
            // 
            this.cbInadiplente.AutoSize = true;
            this.cbInadiplente.Location = new System.Drawing.Point(258, 309);
            this.cbInadiplente.Name = "cbInadiplente";
            this.cbInadiplente.Size = new System.Drawing.Size(15, 14);
            this.cbInadiplente.TabIndex = 94;
            this.cbInadiplente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(347, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 102;
            this.label2.Text = "Ativo:";
            // 
            // lblPCM
            // 
            this.lblPCM.AutoSize = true;
            this.lblPCM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCM.Location = new System.Drawing.Point(19, 170);
            this.lblPCM.Name = "lblPCM";
            this.lblPCM.Size = new System.Drawing.Size(107, 16);
            this.lblPCM.TabIndex = 101;
            this.lblPCM.Text = "Paró/Comu/Movi:";
            // 
            // txtPCM
            // 
            this.txtPCM.Location = new System.Drawing.Point(163, 169);
            this.txtPCM.Name = "txtPCM";
            this.txtPCM.Size = new System.Drawing.Size(221, 20);
            this.txtPCM.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(160, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 100;
            this.label1.Text = "Inadiplente:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Arial", 12F);
            this.lblObservacao.Location = new System.Drawing.Point(19, 270);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(97, 18);
            this.lblObservacao.TabIndex = 99;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(163, 271);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(348, 20);
            this.txtObservacao.TabIndex = 93;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEmail.Location = new System.Drawing.Point(22, 235);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 18);
            this.lblEmail.TabIndex = 98;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(163, 236);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(348, 20);
            this.txtEmail.TabIndex = 91;
            // 
            // epErro
            // 
            this.epErro.ContainerControl = this;
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(444, 169);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(67, 20);
            this.mtbCep.TabIndex = 86;
            // 
            // mtbTelefone2
            // 
            this.mtbTelefone2.Location = new System.Drawing.Point(423, 200);
            this.mtbTelefone2.Mask = "(99) 0000-0000";
            this.mtbTelefone2.Name = "mtbTelefone2";
            this.mtbTelefone2.Size = new System.Drawing.Size(85, 20);
            this.mtbTelefone2.TabIndex = 89;
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTelefone2.Location = new System.Drawing.Point(328, 200);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(89, 18);
            this.lblTelefone2.TabIndex = 96;
            this.lblTelefone2.Text = "Telefone(2):";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(164, 200);
            this.mtbTelefone.Mask = "(99) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(85, 20);
            this.mtbTelefone.TabIndex = 88;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTelefone.Location = new System.Drawing.Point(18, 200);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(70, 18);
            this.lblTelefone.TabIndex = 87;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEstado.Location = new System.Drawing.Point(322, 137);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 18);
            this.lblEstado.TabIndex = 92;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCidade.Location = new System.Drawing.Point(19, 137);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(55, 18);
            this.lblCidade.TabIndex = 90;
            this.lblCidade.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(163, 137);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(144, 20);
            this.txtBairro.TabIndex = 82;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEndereco.Location = new System.Drawing.Point(19, 106);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(80, 18);
            this.lblEndereco.TabIndex = 84;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(163, 106);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(348, 20);
            this.txtEndereco.TabIndex = 80;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(19, 75);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(126, 18);
            this.lblNome.TabIndex = 81;
            this.lblNome.Text = "Nome Completo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(163, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(348, 20);
            this.txtNome.TabIndex = 79;
            // 
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancelar.Image")));
            this.tsbtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(90, 52);
            this.tsbtnCancelar.Text = "Voltar";
            this.tsbtnCancelar.Click += new System.EventHandler(this.tsbtnCancelar_Click);
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
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCep.Location = new System.Drawing.Point(396, 171);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(42, 18);
            this.lblCep.TabIndex = 97;
            this.lblCep.Text = "Cep:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAlterar,
            this.tsbtnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 330);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(544, 55);
            this.toolStrip1.TabIndex = 78;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(22, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 107;
            this.label3.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(52, 52);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(64, 20);
            this.txtId.TabIndex = 108;
            // 
            // cmbPessoas
            // 
            this.cmbPessoas.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "B",
            "C"});
            this.cmbPessoas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPessoas.FormattingEnabled = true;
            this.cmbPessoas.Location = new System.Drawing.Point(202, 39);
            this.cmbPessoas.Name = "cmbPessoas";
            this.cmbPessoas.Size = new System.Drawing.Size(168, 21);
            this.cmbPessoas.TabIndex = 109;
            // 
            // cbCombo
            // 
            this.cbCombo.AutoSize = true;
            this.cbCombo.Location = new System.Drawing.Point(379, 41);
            this.cbCombo.Name = "cbCombo";
            this.cbCombo.Size = new System.Drawing.Size(59, 17);
            this.cbCombo.TabIndex = 110;
            this.cbCombo.Text = "Combo";
            this.cbCombo.UseVisualStyleBackColor = true;
            // 
            // EditarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 385);
            this.ControlBox = false;
            this.Controls.Add(this.cbCombo);
            this.Controls.Add(this.cmbPessoas);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpbOpcoes);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.cbInadiplente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPCM);
            this.Controls.Add(this.txtPCM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mtbCep);
            this.Controls.Add(this.mtbTelefone2);
            this.Controls.Add(this.lblTelefone2);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarClientes";
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbtnNome;
        private System.Windows.Forms.RadioButton rbtnId;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.CheckBox cbInadiplente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPCM;
        private System.Windows.Forms.TextBox txtPCM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ErrorProvider epErro;
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.MaskedTextBox mtbTelefone2;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbtnAlterar;
        public System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPessoas;
        private System.Windows.Forms.CheckBox cbCombo;
    }
}