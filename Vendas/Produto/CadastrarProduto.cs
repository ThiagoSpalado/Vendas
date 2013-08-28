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
            try
            {
                ProdutoDAL objProdutoDAL = new ProdutoDAL();
                ProdutoDTO objProduto = new ProdutoDTO();
                bool camposValidados = true;

                #region Validações dos Campos

                if (String.IsNullOrEmpty(txtNome.Text))
                {
                    epErro.SetError(txtNome, "O campo Nome é obrigatório!");
                    camposValidados = false;
                }

                if (String.IsNullOrEmpty(txtPreco.Text))
                {
                    epErro.SetError(txtPreco, "O campo Preco é obrigatório!");
                    camposValidados = false;
                }

                #endregion

                if (camposValidados)
                {
                    TransferirCampos(objProduto);
                    objProdutoDAL.Insert(objProduto);

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

        private void TransferirCampos(ProdutoDTO produto)
        {
            produto.Nome = txtNome.Text;
            produto.Texto = txtTexto.Text;
            produto.Preco = txtPreco.Text;
            produto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            produto.FlagAtiva = cbStatus.Checked;
        }

        #endregion




    }
}
