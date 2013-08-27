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
            bool camposValidados = true;

            try
            {
                SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Thiago\Desktop\Thiago\Coti\Manager\Vendas\Banco.mdf;Integrated Security=True");

                string strConn = @"UPDATE Cliente SET Nome = @Nome, Endereco = @Endereco, Bairro = @Bairro,Estado = @Estado, 
                                    Cep = @Cep, Telefone = @Telefone, Telefone2 = @Telefone2, Email = @Email, FlagInadiplente = @FlagInadiplente,
                                    FlagAtiva = @FlagAtiva, Observacao = @Observacao, PCM = @PCM WHERE Id = @Id";

                SqlCommand Cmd = new SqlCommand(strConn, Con);

                #region Validações dos Campos

                string verificarTel = mtbTelefone.Text.Replace("_", "").Replace("(", "").Replace(")", "").Replace("-", "").Trim();

                if (!String.IsNullOrEmpty(txtNome.Text))
                {
                    Cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                }
                else
                {
                    epErro.SetError(txtNome, "O campo Nome é obrigatório!");
                    camposValidados = false;
                }

                if (!String.IsNullOrEmpty(verificarTel))
                {
                    Cmd.Parameters.AddWithValue("@Telefone", mtbTelefone.Text);
                }
                else
                {
                    epErro.SetError(mtbTelefone, "O campo Telefone é obrigatório!");
                    camposValidados = false;
                }

                if (cbInadiplente.Checked)
                {
                    Cmd.Parameters.AddWithValue("@FlagInadiplente", 1);
                }
                else
                {
                    Cmd.Parameters.AddWithValue("@FlagInadiplente", 0);
                }

                if (cbAtivo.Checked)
                {
                    Cmd.Parameters.AddWithValue("@FlagAtiva", 1);
                }
                else
                {
                    Cmd.Parameters.AddWithValue("@FlagAtiva", 0);
                }

                //Campos sem validação

                Cmd.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                Cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
                Cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text);
                Cmd.Parameters.AddWithValue("@Cep", mtbCep.Text);
                Cmd.Parameters.AddWithValue("@Telefone2", mtbTelefone2.Text);
                Cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                Cmd.Parameters.AddWithValue("@Observacao", txtObservacao.Text);
                Cmd.Parameters.AddWithValue("@PCM", txtPCM.Text);

                #endregion

                if (camposValidados)
                {
                    Con.Open();
                    Cmd.ExecuteNonQuery();
                    Con.Close();

                    MessageBox.Show("Registro Alterado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    txtEditar.Focus();
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
                    if (txtEditar.Text == "".Trim() || txtEditar.Text.Replace(" ", "") == string.Empty)
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
                    if (cmbPessoas.Text == "".Trim() || cmbPessoas.Text.Replace(" ", "") == string.Empty)
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

            if (pessoa.FlagAtiva.ToString().Replace("True", "Sim") == "Sim")
                cbAtivo.Checked = true;
            else
                cbAtivo.Checked = false;

            if (pessoa.FlagInadiplente.ToString().Replace("True", "Sim") == "Sim")
                cbInadiplente.Checked = true;
            else
                cbInadiplente.Checked = false;

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