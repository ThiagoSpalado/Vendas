using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas.Cliente
{
    public partial class Principal_Clientes : Form
    {
        public Principal_Clientes()
        {
            InitializeComponent();
        }

        #region Botões

        private void tsbtnEditar_Click(object sender, EventArgs e)
        {
            EditarClientes objEditarCliente = new EditarClientes();

            //Informo a aplicação que o frmAlterarExcluirClientes é o form filho do frmClientes
            objEditarCliente.MdiParent = this;

            //Chamo o método que desativa os botões do formulário pai
            this.DesabilitaBotoes(sender, e);

            //Vinculo ao botão Cancelar Cadastro, do form filho, o método para ativar os botões do formulário pai, por meio de delegate
            objEditarCliente.tsbtnCancelar.Click += new EventHandler(this.HabilitaBotoes);

            if (Application.OpenForms.OfType<EditarClientes>().Count() > 0)
            {
                MessageBox.Show("O formulário já está aberto! Feche este formulário para abrir outro!",
                                "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                objEditarCliente.Show();
            }
        }

        private void tsbtnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarCliente objCadastrarClientes = new CadastrarCliente();

            //Informo a aplicação que o frmCadastrarClientes é o form filho do frmClientes
            objCadastrarClientes.MdiParent = this;

            //Chamo o método que desativa os botões do formulário pai
            this.DesabilitaBotoes(sender, e);

            //Vinculo ao botão Cancelar Cadastro, do form filho, o método para ativar os botões do formulário pai, por meio de delegate
            objCadastrarClientes.tsbtnCancelar.Click += new EventHandler(this.HabilitaBotoes);

            //Verifico se o form já está aberto. Se estiver impeço a abertura de um novo e exibo uma mensagem ao usuário
            if (Application.OpenForms.OfType<CadastrarCliente>().Count() > 0)
            {
                MessageBox.Show("O formulário já está aberto! Feche este formulário para abrir outro!",
                                "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                objCadastrarClientes.Show();
            }
        }

        private void tsbtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarClientes objConsultarClientes = new ConsultarClientes();

            //Informo a aplicação que o frmConsultarClientes é o form filho do frmClientes
            objConsultarClientes.MdiParent = this;

            //Chamo o método que desativa os botões do formulário pai
            this.DesabilitaBotoes(sender, e);

            //Vinculo ao botão Voltar, do form filho o método para ativar os botões do formulário pai, usando delegates
            objConsultarClientes.tsbtnVoltar.Click += new EventHandler(this.HabilitaBotoes);

            //Verifico se o form já está aberto. Se estiver impeço a abertura de um novo e exibo uma mensagem ao usuário
            if (Application.OpenForms.OfType<ConsultarClientes>().Count() > 0)
            {
                MessageBox.Show("O formulário já está aberto! Feche este formulário para abrir outro!",
                                "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                objConsultarClientes.Show();
            }
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Métodos

        private void DesabilitaBotoes(object sender, EventArgs e)
        {
            tsbtnCadastrar.Enabled = false;
            tsbtnConsultar.Enabled = false;
            tsbtnVoltar.Enabled = false;
            tsbtnSair.Enabled = false;
            tsbtnEditar.Enabled = false;
        }

        private void HabilitaBotoes(object sender, EventArgs e)
        {
            tsbtnCadastrar.Enabled = true;
            tsbtnConsultar.Enabled = true;
            tsbtnVoltar.Enabled = true;
            tsbtnSair.Enabled = true;
            tsbtnEditar.Enabled = true;
        }
        #endregion
    }
}
