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
            //Crio uma variável booleana que irá verificar se os campos estão validados
            bool camposValidados = true;

            try
            {
                //Instancio a classe de conexão passando como parâmetro a string de conexão ao DataBase LibrarySystem
                SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Thiago\Desktop\Thiago\Coti\Manager\Vendas\Banco.mdf;Integrated Security=True");

                //Armazeno em uma variável do tipo string minha instrução SQL referente à inserção do registro,
                //concatenando os valores parametrizados, referentes aos campos que serão preenchidos no form
                string strConn = "INSERT INTO Cliente (Nome, Endereco, Bairro, Estado, Cep, Telefone, Telefone2, Email, FlagInadiplente ,FlagAtiva, Observacao, PCM)" +
                                     "VALUES (@Nome, @Endereco, @Bairro, @Estado, @Cep, @Telefone, @Telefone2, @Email, @FlagInadiplente, @FlagAtiva, @Observacao, @PCM)";

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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
