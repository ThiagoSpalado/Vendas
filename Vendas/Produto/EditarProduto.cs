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
using DAL.Model;
using DAL.Persistence;

namespace Vendas.Produto
{
    public partial class EditarProduto : Form
    {
        public EditarProduto()
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

                string strConn = @"UPDATE Produto set Nome = @Nome, Preco = @Preco, Quantidade = @Quantidade,
                                    Texto = @Texto, FlagAtiva = @FlagAtiva  WHERE Id = @Id";

                SqlCommand Cmd = new SqlCommand(strConn, Con);

                #region Validações dos Campos

                if (!String.IsNullOrEmpty(txtNome.Text))
                {
                    Cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                }
                else
                {
                    errorPro.SetError(txtNome, "O campo Nome é obrigatório!");
                    camposValidados = false;
                }

                if (!String.IsNullOrEmpty(txtTexto.Text))
                {
                    Cmd.Parameters.AddWithValue("@Texto", txtTexto.Text);
                }
                else
                {
                    errorPro.SetError(txtTexto, "O campo Texto é obrigatório!");
                    camposValidados = false;
                }

                if (!String.IsNullOrEmpty(txtPreco.Text))
                {
                    Cmd.Parameters.AddWithValue("@Preco", txtPreco.Text);
                }
                else
                {
                    errorPro.SetError(txtPreco, "O campo Preco é obrigatório!");
                    camposValidados = false;
                }

                if (!String.IsNullOrEmpty(txtQuantidade.Text))
                {
                    Cmd.Parameters.AddWithValue("@Quantidade", txtQuantidade.Text);
                }
                else
                {
                    errorPro.SetError(txtQuantidade, "O campo Quantidade é obrigatório!");
                    camposValidados = false;
                }

                if (cbAtivo.Checked)
                {
                    Cmd.Parameters.AddWithValue("@FlagAtiva", 1);
                }
                else
                {
                    Cmd.Parameters.AddWithValue("@FlagAtiva", 0);
                }

                Cmd.Parameters.AddWithValue("@Id", txtId.Text);
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
                throw;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDAL objProdutoDal = new ProdutoDAL();
                List<ProdutoDTO> lstProduto;
                if (!cbCombo.Checked)
                {
                    if (rbtNome.Checked && txtEditar.Text != string.Empty)
                    {
                        lstProduto = objProdutoDal.Buscar(txtEditar.Text, "nome");
                        PreencherCombo(lstProduto);
                    }
                    else if (rbtnId.Checked && txtEditar.Text != string.Empty)
                    {
                        lstProduto = objProdutoDal.Buscar(txtEditar.Text, "id");
                        PreencherCombo(lstProduto);
                    }
                    else
                    {
                        MessageBox.Show("Prencha o campo de busca", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (rbtNome.Checked && cmbProdutos.Text != string.Empty)
                    {
                        lstProduto = objProdutoDal.Buscar(cmbProdutos.Text, "nome");
                        PreencherCombo(lstProduto);
                    }
                    else if (rbtnId.Checked && cmbProdutos.Text != string.Empty)
                    {
                        lstProduto = objProdutoDal.Buscar(cmbProdutos.Text, "id");
                        PreencherCombo(lstProduto);
                    }
                    else
                    {
                        MessageBox.Show("Prencha o campo de busca", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            catch (Exception ex)
            {

            }

        }

        private void txtLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion

        #region Métodos

        private void PreencherCombo(List<ProdutoDTO> lstProduto)
        {
            if (lstProduto.Count != 0)
            {
                PreencherCampos(lstProduto[0]);
                cmbProdutos.Items.Clear();

                for (int i = 0; i < lstProduto.Count; i++)
                {
                    cmbProdutos.Items.Add(lstProduto[i].Nome);
                }
            }
        }

        private void PreencherCampos(ProdutoDTO produto)
        {
            txtId.Text = produto.IdProduto.ToString();
            txtNome.Text = produto.Nome.ToString();
            txtPreco.Text = produto.Preco.ToString();
            txtQuantidade.Text = produto.Quantidade.ToString();
            txtTexto.Text = produto.Texto;

            if (produto.FlagAtiva.ToString().Replace("True", "Sim") == "Sim")
                cbAtivo.Checked = true;
            else
                cbAtivo.Checked = false;
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtTexto.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            cbAtivo.Checked = false;
            txtEditar.Text = string.Empty;
        }
        
        
        #endregion

        #region Rotina

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
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

        private void rbtnId_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void rbtTexto_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void rbtNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparCampos();
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

        #endregion

 


    }
}
