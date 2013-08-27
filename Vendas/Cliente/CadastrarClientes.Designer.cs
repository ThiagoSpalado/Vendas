namespace Vendas.Cliente
{
    partial class CadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            this.txtEstado = new System.Windows.Forms.TextBox();
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
            this.mtbCep = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelefone2 = new System.Windows.Forms.MaskedTextBox();
            this.lblCep = new System.Windows.Forms.Label();
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
            this.lblMensagem = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.epErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(404, 163);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 54;
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Checked = true;
            this.cbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAtivo.Location = new System.Drawing.Point(290, 335);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(15, 14);
            this.cbAtivo.TabIndex = 65;
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // cbInadiplente
            // 
            this.cbInadiplente.AutoSize = true;
            this.cbInadiplente.Location = new System.Drawing.Point(156, 335);
            this.cbInadiplente.Name = "cbInadiplente";
            this.cbInadiplente.Size = new System.Drawing.Size(15, 14);
            this.cbInadiplente.TabIndex = 64;
            this.cbInadiplente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(225, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Ativo:";
            // 
            // lblPCM
            // 
            this.lblPCM.AutoSize = true;
            this.lblPCM.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCM.Location = new System.Drawing.Point(12, 198);
            this.lblPCM.Name = "lblPCM";
            this.lblPCM.Size = new System.Drawing.Size(107, 16);
            this.lblPCM.TabIndex = 71;
            this.lblPCM.Text = "Paró/Comu/Movi:";
            // 
            // txtPCM
            // 
            this.txtPCM.Location = new System.Drawing.Point(156, 197);
            this.txtPCM.Name = "txtPCM";
            this.txtPCM.Size = new System.Drawing.Size(221, 20);
            this.txtPCM.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(12, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 70;
            this.label1.Text = "Inadiplente:";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Arial", 12F);
            this.lblObservacao.Location = new System.Drawing.Point(12, 298);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(97, 18);
            this.lblObservacao.TabIndex = 69;
            this.lblObservacao.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(156, 299);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(348, 20);
            this.txtObservacao.TabIndex = 63;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEmail.Location = new System.Drawing.Point(15, 263);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 18);
            this.lblEmail.TabIndex = 68;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(156, 264);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(348, 20);
            this.txtEmail.TabIndex = 62;
            // 
            // mtbCep
            // 
            this.mtbCep.Location = new System.Drawing.Point(437, 197);
            this.mtbCep.Mask = "00000-000";
            this.mtbCep.Name = "mtbCep";
            this.mtbCep.Size = new System.Drawing.Size(67, 20);
            this.mtbCep.TabIndex = 57;
            // 
            // mtbTelefone2
            // 
            this.mtbTelefone2.Location = new System.Drawing.Point(420, 228);
            this.mtbTelefone2.Mask = "(99) 0000-0000";
            this.mtbTelefone2.Name = "mtbTelefone2";
            this.mtbTelefone2.Size = new System.Drawing.Size(85, 20);
            this.mtbTelefone2.TabIndex = 60;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCep.Location = new System.Drawing.Point(389, 199);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(42, 18);
            this.lblCep.TabIndex = 67;
            this.lblCep.Text = "Cep:";
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTelefone2.Location = new System.Drawing.Point(325, 228);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(89, 18);
            this.lblTelefone2.TabIndex = 66;
            this.lblTelefone2.Text = "Telefone(2):";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(157, 228);
            this.mtbTelefone.Mask = "(99) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(85, 20);
            this.mtbTelefone.TabIndex = 58;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTelefone.Location = new System.Drawing.Point(11, 228);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(70, 18);
            this.lblTelefone.TabIndex = 56;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEstado.Location = new System.Drawing.Point(315, 165);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(62, 18);
            this.lblEstado.TabIndex = 61;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCidade.Location = new System.Drawing.Point(12, 165);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(55, 18);
            this.lblCidade.TabIndex = 59;
            this.lblCidade.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(156, 165);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(144, 20);
            this.txtBairro.TabIndex = 52;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 12F);
            this.lblEndereco.Location = new System.Drawing.Point(12, 134);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(80, 18);
            this.lblEndereco.TabIndex = 53;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(156, 134);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(348, 20);
            this.txtEndereco.TabIndex = 51;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 103);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(126, 18);
            this.lblNome.TabIndex = 50;
            this.lblNome.Text = "Nome Completo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(156, 102);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(348, 20);
            this.txtNome.TabIndex = 49;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(40, 64);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(465, 19);
            this.lblMensagem.TabIndex = 48;
            this.lblMensagem.Text = "Preencha os dados corretamente  e clique em Gravar Dados";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnGravar,
            this.tsbtnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(532, 55);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnGravar
            // 
            this.tsbtnGravar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnGravar.Image")));
            this.tsbtnGravar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGravar.Name = "tsbtnGravar";
            this.tsbtnGravar.Size = new System.Drawing.Size(129, 52);
            this.tsbtnGravar.Text = "Gravar Dados";
            this.tsbtnGravar.Click += new System.EventHandler(this.tsbtnGravar_Click);
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
            // epErro
            // 
            this.epErro.ContainerControl = this;
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 371);
            this.ControlBox = false;
            this.Controls.Add(this.txtEstado);
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
            this.Controls.Add(this.lblCep);
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
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarClientes";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
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
        private System.Windows.Forms.MaskedTextBox mtbCep;
        private System.Windows.Forms.MaskedTextBox mtbTelefone2;
        private System.Windows.Forms.Label lblCep;
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
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbtnGravar;
        public System.Windows.Forms.ToolStripButton tsbtnCancelar;
        private System.Windows.Forms.ErrorProvider epErro;

    }
}