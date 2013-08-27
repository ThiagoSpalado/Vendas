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
using DAL.Persistence;
using DAL.Model;

namespace Vendas.Cliente
{
    public partial class EditarClientes : Form
    {
        public EditarClientes()
        {
            InitializeComponent();
        }

        #region Botões

        private void tsbtnAlterar_Click(object sender, EventArgs e)
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
                    objPessoaDAL.Update(objPessoa);

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
            catch (Exception)
            {
                MessageBox.Show("Ops, ocorreram erros!\n\nPreencha os campos e tente novamente",
                                    "Mensagem : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }
        
        private void tsbtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Métodos

        private void LimparCampos()
        {
            try
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
                txtEditar.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CarregarDados()
        {
            try
            {
                PessoaDAL objPessoaDAL = new PessoaDAL();

                if (cbCombo.Checked == false)
                {
                    if (txtEditar.Text == "".Trim() || txtEditar.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Prencha o campo de busca", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (rbtnId.Checked == true && txtEditar.Text != string.Empty)
                    {
                        List<PessoaDTO> lstPessoa = objPessoaDAL.Buscar(txtEditar.Text, "id");
                        PreencherCombo(lstPessoa);
                    }
                    else
                    {
                        if (rbtnNome.Checked == true && txtEditar.Text != string.Empty)
                        {
                            List<PessoaDTO> lstPessoa = objPessoaDAL.Buscar(txtEditar.Text, "nome");
                            PreencherCombo(lstPessoa);
                        }
                    }
                }
                else
                {
                    if (cmbPessoas.Text == "".Trim() || cmbPessoas.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Prencha o campo de busca", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (rbtnId.Checked == true && cmbPessoas.Text != string.Empty)
                    {
                        List<PessoaDTO> lstPessoa = objPessoaDAL.Buscar(cmbPessoas.Text, "id");
                        PreencherCampos(lstPessoa[0]);
                    }
                    else
                    {
                        if (rbtnNome.Checked == true && cmbPessoas.Text != string.Empty)
                        {
                            List<PessoaDTO> lstPessoa = objPessoaDAL.Buscar(cmbPessoas.Text, "nome");
                            PreencherCampos(lstPessoa[0]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro inesperedo verifique se está tudo preenchido corretamente.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbtnId.Checked == true)
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
        }

        private void PreencherCombo(List<PessoaDTO> lstPessoa)
        {
            if (lstPessoa.Count != 0)
            {
                PreencherCampos(lstPessoa[0]);
                cmbPessoas.Items.Clear();

                for (int i = 0; i < lstPessoa.Count; i++)
                {
                    cmbPessoas.Items.Add(lstPessoa[i].Nome);
                }
            }
        }

        private void PreencherCampos(PessoaDTO pessoa)
        {
            txtId.Text = pessoa.IdPessoa.ToString();
            txtNome.Text = pessoa.Nome;
            txtEndereco.Text = pessoa.Endereco;
            txtBairro.Text = pessoa.Bairro;
            txtEstado.Text = pessoa.Estado;
            txtEmail.Text = pessoa.Email;
            txtObservacao.Text = pessoa.Observacao;
            txtPCM.Text = pessoa.PCM;
            mtbCep.Text = pessoa.Cep;
            mtbTelefone.Text = pessoa.Telefone;
            mtbTelefone2.Text = pessoa.Telefone2;

            if (pessoa.FlagAtiva)
                cbAtivo.Checked = true;
            else
                cbAtivo.Checked = false;

            if (pessoa.FlagInadiplente)
                cbInadiplente.Checked = true;
            else
                cbInadiplente.Checked = false;           
        }

        private void TransferirCampos(PessoaDTO pessoa)
        {
            pessoa.IdPessoa = Convert.ToInt32(txtId.Text);
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

        private void rbtnId_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void rbtnNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }

        #endregion

    }
}