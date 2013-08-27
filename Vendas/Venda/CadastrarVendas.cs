using DAL.Model;
using DAL.Persistence;
using Vendas.Cliente;
using Vendas.Produto;
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

namespace Vendas.Venda
{
    public partial class CadastrarVendas : Form
    {
        public CadastrarVendas()
        {
            InitializeComponent();
        }

        ListViewItem objListViewItem;
        string IdCliente;
        double contTotal = 0;
        string produto = "";
        string qnt = "";
        string preco = "";
        string codRef;
        string IdProduto;

        #region Botões

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
            objListCompra.Items.Clear();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ConsultarClientes objCliente = new ConsultarClientes();
            objCliente.ShowDialog();
        }

        private void InserirCliente()
        {
            try
            {
                PessoaDAL objPessoaDAL = new PessoaDAL();
                List<PessoaDTO> lstCliente = objPessoaDAL.Buscar(cboxCliente.Text, "nome");

                txtCliente.Text = lstCliente.FirstOrDefault().Nome;
                IdCliente = lstCliente.FirstOrDefault().IdPessoa.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void InserirProduto()
        {
            try
            {
                ProdutoDAL objProdutoDAL = new ProdutoDAL();
                List<ProdutoDTO> lstProduto = objProdutoDAL.Buscar(cboxProduto.Text,"nome");

                txtProduto.Text = lstProduto.FirstOrDefault().Nome;
                txtPreco.Text = lstProduto.FirstOrDefault().Preco;
                IdProduto = lstProduto.FirstOrDefault().IdProduto.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtQnt.Text == string.Empty)
            {
                MessageBox.Show("O campo Quantidade não foi preenchido!",
                        "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            objListViewItem = new ListViewItem();

            objListViewItem.SubItems.Add(txtProduto.Text);
            objListViewItem.SubItems.Add(txtQnt.Text);
            objListViewItem.SubItems.Add(txtPreco.Text);

            preco = preco + (txtPreco.Text + "%");
            produto = produto + (IdProduto + "%");
            qnt = qnt + (txtQnt.Text + "%");

            objListCompra.Items.Add(objListViewItem);

            contTotal = contTotal + (Convert.ToDouble(txtPreco.Text) * Convert.ToDouble(txtQnt.Text));

            txtTotal.Text = contTotal.ToString();

        }

        #endregion

        #region Métodos

        private void Gravar()
        {
            try
            {
                SqlConnection objConexao = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Thiago\Desktop\Thiago\Coti\Manager\Vendas\Banco.mdf;Integrated Security=True");
                string strConn = "insert into compra(idcliente,data,total,codreferencia,Status)" +
                                    "values (@idcliente, @Data, @Total, @Codref, @Status)";

                SqlCommand Cmd = new SqlCommand(strConn, objConexao);

                codRef = DateTime.Now.ToString("yyyyMMddHHmmssff");

                Cmd.Parameters.AddWithValue("@idcliente", IdCliente);
                Cmd.Parameters.AddWithValue("@Data", DateTime.Today.ToString().Replace("00:00:00", ""));
                Cmd.Parameters.AddWithValue("@Total", Convert.ToDouble(txtTotal.Text));
                Cmd.Parameters.AddWithValue("@CodRef", Convert.ToInt64(codRef));
                Cmd.Parameters.AddWithValue("@Status", CboxStatus.Text);

                objConexao.Open();
                Cmd.ExecuteNonQuery();
                objConexao.Close();

                string[] aryProduto = produto.Split('%');
                string[] aryQnt = qnt.Split('%');

                for (int i = 0; i < (produto.Length / 2); i++)
                {
                    string strConn2 = "INSERT INTO compraproduto(IdProduto, CodReferencia, Quantidade, IdCliente)" +
                    "Values (@IdProduto, @CodRef, @Quantidade, @IdCliente)";

                    Cmd = new SqlCommand(strConn2, objConexao);

                    Cmd.Parameters.AddWithValue("@IdProduto", aryProduto[i]);
                    Cmd.Parameters.AddWithValue("@CodRef", Convert.ToInt64(codRef));
                    Cmd.Parameters.AddWithValue("@Quantidade", aryQnt[i]);
                    Cmd.Parameters.AddWithValue("@IdCliente", IdCliente);

                    objConexao.Open();
                    Cmd.ExecuteNonQuery();
                    objConexao.Close();
                }
                MessageBox.Show("Registro inserido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops, ocorreram erros!\n\nPreencha os campos e tente novamente",
                        "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                SqlConnection objConexao = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Thiago\Desktop\Thiago\Coti\Manager\Vendas\Banco.mdf;Integrated Security=True");
                string strDelete = "delete from compra where CodReferencia = @CodRef";
                SqlCommand Cmd = new SqlCommand(strDelete, objConexao);

                Cmd.Parameters.AddWithValue("@CodRef", codRef);

                objConexao.Open();
                Cmd.ExecuteNonQuery();
                objConexao.Close();

                string strDelete2 = "delete from compraproduto where CodReferencia = @CodRef";
                SqlCommand Cmd2 = new SqlCommand(strDelete2, objConexao);

                Cmd2.Parameters.AddWithValue("@CodRef", codRef);

                objConexao.Open();
                Cmd.ExecuteNonQuery();
                objConexao.Close();

            }
            finally
            {
                produto = "";
                qnt = "";
                preco = "";
            }
        }

        private void LimparCampos()
        {
            txtQnt.Text = string.Empty;
            CboxStatus.Text = string.Empty;
            txtTotal.Text = string.Empty;
            contTotal = 0;
        }

        #endregion

        private void txtClienteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtProdutoId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtQnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void CadastrarVendas_Load(object sender, EventArgs e)
        {
            PessoaDAL objPessoaDAL = new PessoaDAL();
            ProdutoDAL objProdutoDAL = new ProdutoDAL();
            List<PessoaDTO> lstPessoa = objPessoaDAL.GetAll();
            List<ProdutoDTO> lstProduto = objProdutoDAL.GetAll();

            for (int i = 0; i < lstPessoa.Count; i++)
            {
                cboxCliente.Items.Add(lstPessoa[i].Nome);
            }

            for (int i = 0; i < lstProduto.Count; i++)
            {
                cboxProduto.Items.Add(lstProduto[i].Nome);
            }
        }

        private void cboxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            InserirCliente();
        }

        private void cboxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            InserirProduto();
        }
    }
}