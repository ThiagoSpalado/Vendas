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

namespace Vendas.Produto
{
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        #region Botões

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            epErro.Clear();
            Gravar();
        }

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Métodos

        private void Gravar()
        {
            //Crio uma variável booleana que irá verificar se os campos estão validados
            bool camposValidados = true;

            try
            {
               SqlConnection objConexao = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Thiago\Desktop\Thiago\Coti\Manager\Vendas\Banco.mdf;Integrated Security=True");

                string strConn = @"INSERT INTO Produto (Nome, Preco, Quantidade, Texto, FlagAtiva)" +
                                " VALUES (@Nome, @Preco, @Quantidade, @Texto, @FlagAtiva)";

               SqlCommand objCommand = new SqlCommand(strConn, objConexao);

                #region Validações dos Campos

                if (!String.IsNullOrEmpty(txtNome.Text))
                {
                    objCommand.Parameters.AddWithValue("@Nome", txtNome.Text);
                }
                else
                {
                    epErro.SetError(txtNome, "O campo Nome é obrigatório!");
                    camposValidados = false;
                }

                if (!String.IsNullOrEmpty(txtTexto.Text))
                {
                    objCommand.Parameters.AddWithValue("@Texto", txtTexto.Text);
                }
                else
                {
                    camposValidados = false;
                }

                if (!String.IsNullOrEmpty(txtPreco.Text))
                {
                    objCommand.Parameters.AddWithValue("@Preco", txtPreco.Text);
                }
                else
                {
                    epErro.SetError(txtPreco, "O campo Preco é obrigatório!");
                    camposValidados = false;
                }

                if (!String.IsNullOrEmpty(txtQuantidade.Text))
                {
                    objCommand.Parameters.AddWithValue("@Quantidade", txtQuantidade.Text);
                }
                else
                {
                    epErro.SetError(txtQuantidade, "O campo Quantidade é obrigatório!");
                    camposValidados = false;
                }

                if (cbStatus.Checked)
                {
                    objCommand.Parameters.AddWithValue("@FlagAtiva", 1);
                }
                else
                {
                    objCommand.Parameters.AddWithValue("@FlagAtiva", 0);
                }

                #endregion

                if (camposValidados)
                {
                    objConexao.Open();
                    objCommand.ExecuteNonQuery();
                    objConexao.Close();

                    MessageBox.Show("Registro inserido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Ops, ocorreram erros!\n\nPreencha os campos e tente novamente",
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
            txtNome.Text = string.Empty;
            txtTexto.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            cbStatus.Checked = true;
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != ',')
            {
                if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        #endregion




    }
}
