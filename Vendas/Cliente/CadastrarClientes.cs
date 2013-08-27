using DAL.Model;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas.Cliente
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        #region Botões

        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            epErro.Clear();
            Gravar();
        }

        #endregion

        #region Métodos

        private void Gravar()
        {
            try
            {
                PessoaDAL objPessoaDAL = new PessoaDAL();
                PessoaDTO objPessoa = new PessoaDTO();
                bool camposValidados = true;

                #region Validações dos Campos

                string verificarTel = mtbTelefone.Text.Replace("_", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim();

                if (String.IsNullOrEmpty(txtNome.Text))
                {
                    epErro.SetError(txtNome, "O campo Nome é obrigatório!");
                    camposValidados = false;
                }

                if (String.IsNullOrEmpty(verificarTel))
                {
                    epErro.SetError(mtbTelefone, "O campo Telefone é obrigatório!");
                    camposValidados = false;
                }

                #endregion

                if (camposValidados)
                {
                    TransferirCampos(objPessoa);
                    objPessoaDAL.Insert(objPessoa);

                    MessageBox.Show("Registro inserido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Ops, ocorreram erros!\nPreencha os campos com o balãozinho vermelho e tente novamente",
                        "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimparCampos()
        {
            mtbCep.Text = string.Empty;
            mtbTelefone2.Text = string.Empty;
            txtObservacao.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtEstado.Text = string.Empty;
            mtbTelefone.Text = string.Empty;
            cbInadiplente.Checked = false;
            cbAtivo.Checked = false;
            txtPCM.Text = string.Empty;
        }

        private void TransferirCampos(PessoaDTO pessoa)
        {
            pessoa.Nome = txtNome.Text;
            pessoa.Endereco = txtEndereco.Text;
            pessoa.Bairro = txtBairro.Text;
            pessoa.Estado = txtEstado.Text;
            pessoa.Cep = mtbCep.Text;
            pessoa.Telefone = mtbTelefone.Text;
            pessoa.Telefone2 = mtbTelefone2.Text;
            pessoa.Email = txtEmail.Text;
            pessoa.FlagInadiplente = cbInadiplente.Checked;
            pessoa.FlagAtiva = cbAtivo.Checked;
            pessoa.Observacao = txtObservacao.Text;
            pessoa.PCM = txtPCM.Text;

        }

        #endregion
    }
}
