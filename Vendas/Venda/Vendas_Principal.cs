using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas.Venda
{
    public partial class Vendas_Principal : Form
    {
        public Vendas_Principal()
        {
            InitializeComponent();
        }

        #region Botões

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsbtnVenda_Click(object sender, EventArgs e)
        {
            CadastrarVendas objFrmCadastrarvendas = new CadastrarVendas();

            //Informo a aplicação que o frmCadastrarClientes é o form filho do frmClientes
            objFrmCadastrarvendas.MdiParent = this;

            //Chamo o método que desativa os botões do formulário pai
            this.DesabilitaBotoes(sender, e);

            //Vinculo ao botão Cancelar Cadastro, do form filho, o método para ativar os botões do formulário pai, por meio de delegate
            objFrmCadastrarvendas.tsbtnVoltar.Click += new EventHandler(this.HabilitaBotoes);

            //Vinculo ao botão Voltar, do form filho, o método para ativar os botões do formulário pai, por meio de delegate
            objFrmCadastrarvendas.tsbtnVoltar.Click += new EventHandler(this.HabilitaBotoes);

            //Verifico se o form já está aberto. Se estiver impeço a abertura de um novo e exibo uma mensagem ao usuário
            if (objFrmCadastrarvendas.Visible == false)
            {
                objFrmCadastrarvendas.Show();
            }
            else
            {
                MessageBox.Show("O formulário já está aberto com a gravação dos dados em andamento! Feche este formulário para abrir outro!",
                                                                    "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsbtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarVendas objConsultarVendas = new ConsultarVendas();

            //Informo a aplicação que o frmConsultarLivros é o form filho do frmLivros
            objConsultarVendas.MdiParent = this;

            //Chamo o método que desativa os botões do formulário pai
            this.DesabilitaBotoes(sender, e);

            //Vinculo ao botão Voltar, do form filho o método para ativar os botões do formulário pai, usando delegates
            objConsultarVendas.tsbtnVoltar.Click += new EventHandler(this.HabilitaBotoes);

            //Verifico se o form já está aberto. Se estiver impeço a abertura de um novo e exibo uma mensagem ao usuário
            if (objConsultarVendas.Visible == false)
            {
                objConsultarVendas.Show();
            }
            else
            {
                MessageBox.Show("O formulário já está aberto com a gravação dos dados em andamento! Feche este formulário para abrir outro!",
                                                                    "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            //tsbtnAlterarExcluir.Enabled = false;
            tsbtnVenda.Enabled = false;
            tsbtnConsultar.Enabled = false;
            tsbtnVoltar.Enabled = false;
            tsbtnSair.Enabled = false;
        }

        private void HabilitaBotoes(object sender, EventArgs e)
        {
            //tsbtnAlterarExcluir.Enabled = true;
            tsbtnVenda.Enabled = true;
            tsbtnConsultar.Enabled = true;
            tsbtnVoltar.Enabled = true;
            tsbtnSair.Enabled = true;
        }

        #endregion




    }
}