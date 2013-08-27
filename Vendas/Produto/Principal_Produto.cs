using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas.Produto
{
    public partial class Principal_Produto : Form
    {
        public Principal_Produto()
        {
            InitializeComponent();
        }

        #region Botões

        private void tsbnEditar_Click(object sender, EventArgs e)
        {
            EditarProduto objEditar = new EditarProduto();

            objEditar.MdiParent = this;

            //Chamo o método que desativa os botões do formulário pai
            this.DesabilitaBotoes(sender, e);

            //Vinculo ao botão Voltar, do form filho, o método para ativar os botões do formulário pai, por meio de delegate
            objEditar.tsbtnVoltar.Click += new EventHandler(this.HabilitaBotoes);

            //Verifico se o form já está aberto. Se estiver impeço a abertura de um novo e exibo uma mensagem ao usuário
            if (objEditar.Visible == false)
            {
                objEditar.Show();
            }
            else
            {
                MessageBox.Show("O formulário já está aberto com a gravação dos dados em andamento! Feche este formulário para abrir outro!",
                                                                    "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsbtnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarProduto objFrmCadastrarProduto = new CadastrarProduto();

            //Informo a aplicação que o frmCadastrarLivros é o form filho do frmLivros
            objFrmCadastrarProduto.MdiParent = this;

            //Chamo o método que desativa os botões do formulário pai
            this.DesabilitaBotoes(sender, e);

            //Vinculo ao botão Cancelar Cadastro, do form filho o método para ativar os botões do formulário pai, por meio de delegate
            objFrmCadastrarProduto.tsbtnVoltar.Click += new EventHandler(this.HabilitaBotoes);

            //Vinculo ao botão Voltar, do form filho, o método para ativar os botões do formulário pai, por meio de delegate
            objFrmCadastrarProduto.tsbtnVoltar.Click += new EventHandler(this.HabilitaBotoes);

            //Verifico se o form já está aberto. Se estiver impeço a abertura de um novo e exibo uma mensagem ao usuário
            if (objFrmCadastrarProduto.Visible == false)
            {
                objFrmCadastrarProduto.Show();
            }
            else
            {
                MessageBox.Show("O formulário já está aberto com a gravação dos dados em andamento! Feche este formulário para abrir outro!",
                                                                    "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsbtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarProduto objFrmConsultarProdutos = new ConsultarProduto();

            //Informo a aplicação que o frmConsultarLivros é o form filho do frmLivros
            objFrmConsultarProdutos.MdiParent = this;

            //Chamo o método que desativa os botões do formulário pai
            this.DesabilitaBotoes(sender, e);

            //Vinculo ao botão Voltar, do form filho o método para ativar os botões do formulário pai, usando delegates
            objFrmConsultarProdutos.tsbtnVoltar.Click += new EventHandler(this.HabilitaBotoes);

            //Verifico se o form já está aberto. Se estiver impeço a abertura de um novo e exibo uma mensagem ao usuário
            if (objFrmConsultarProdutos.Visible == false)
            {
                objFrmConsultarProdutos.Show();
            }
            else
            {
                MessageBox.Show("O formulário já está aberto com a gravação dos dados em andamento! Feche este formulário para abrir outro!",
                                                                    "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            tsbnEditar.Enabled = false;
        }

        private void HabilitaBotoes(object sender, EventArgs e)
        {
            tsbtnCadastrar.Enabled = true;
            tsbtnConsultar.Enabled = true;
            tsbtnVoltar.Enabled = true;
            tsbtnSair.Enabled = true;
            tsbnEditar.Enabled = true;
        }

        #endregion
    }
}