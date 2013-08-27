using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;
using DAL.Persistence;


namespace Vendas.Produto
{
    public partial class ConsultarProduto : Form
    {
        public ConsultarProduto()
        {
            InitializeComponent();
        }

        #region Botões

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lsvDados.Items.Clear();
            Consultar();
        }

        #endregion

        #region Eventos

        private void rbtEditora_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtId.Checked)
            {
                txtConsulta.Text = string.Empty;
                txtConsulta.Focus();
            }
        }

        private void rbtNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNome.Checked)
            {
                txtConsulta.Text = string.Empty;
                txtConsulta.Focus();
            }
        }

        #endregion

        private void Consultar()
        {
            try
            {
                ProdutoDAL objProdutoDal = new ProdutoDAL();
                List<ProdutoDTO> lstProduto;

                if (rbtNome.Checked)
                {
                    lstProduto = objProdutoDal.Buscar(txtConsulta.Text,"nome");

                    foreach (ProdutoDTO objProduto in lstProduto)
                    {
                        ListViewItem objListViewItem = new ListViewItem();
                        objListViewItem.Text = objProduto.IdProduto.ToString();
                        objListViewItem.SubItems.Add(objProduto.Nome.ToString());
                        objListViewItem.SubItems.Add(objProduto.Texto.ToString());
                        objListViewItem.SubItems.Add(objProduto.Preco.ToString());
                        objListViewItem.SubItems.Add(objProduto.Quantidade.ToString());
                        objListViewItem.SubItems.Add(objProduto.FlagAtiva.ToString());

                        lsvDados.Items.Add(objListViewItem);
                    }
                }
                else if (rbtId.Checked)
                {
                    lstProduto = objProdutoDal.Buscar(txtConsulta.Text, "id");

                    foreach (ProdutoDTO objProduto in lstProduto)
                    {
                        ListViewItem objListViewItem = new ListViewItem();
                        objListViewItem.Text = objProduto.IdProduto.ToString();
                        objListViewItem.SubItems.Add(objProduto.Nome.ToString());
                        objListViewItem.SubItems.Add(objProduto.Texto.ToString());
                        objListViewItem.SubItems.Add(objProduto.Preco.ToString());
                        objListViewItem.SubItems.Add(objProduto.Quantidade.ToString());
                        objListViewItem.SubItems.Add(objProduto.FlagAtiva.ToString());

                        lsvDados.Items.Add(objListViewItem);
                    }
                }
                else
                {
                    lstProduto = objProdutoDal.GetAll();

                    foreach (ProdutoDTO objProduto in lstProduto)
                    {
                        ListViewItem objListViewItem = new ListViewItem();
                        objListViewItem.Text = objProduto.IdProduto.ToString();
                        objListViewItem.SubItems.Add(objProduto.Nome.ToString());
                        objListViewItem.SubItems.Add(objProduto.Texto.ToString());
                        objListViewItem.SubItems.Add(objProduto.Preco.ToString());
                        objListViewItem.SubItems.Add(objProduto.Quantidade.ToString());
                        objListViewItem.SubItems.Add(objProduto.FlagAtiva.ToString());

                        lsvDados.Items.Add(objListViewItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
