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
                    objProdutoDAL.Update(objProduto);

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
                cbStatus.Checked = true;
            else
                cbStatus.Checked = false;
        }

        private void LimparCampos()
        {
            txtNome.Text = string.Empty;
            txtTexto.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            cbStatus.Checked = false;
            txtEditar.Text = string.Empty;
        }

        private void TransferirCampos(ProdutoDTO produto)
        {
            produto.IdProduto = Convert.ToInt32(txtId.Text);
            produto.Nome = txtNome.Text;
            produto.Texto = txtTexto.Text;
            produto.Preco = txtPreco.Text;
            produto.Quantidade = Convert.ToInt32(txtQuantidade.Text);
            produto.FlagAtiva = cbStatus.Checked;
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
