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

namespace Vendas.Venda
{
   public partial class ConsultarVendas : Form
    {
        public ConsultarVendas()
        {
            InitializeComponent();
        }

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDetalhar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            objListCompra.Items.Clear();
            Consultar();
        }

        protected void Consultar()
        {
            try
            {
                VendaDAL objVendaDAL = new VendaDAL();

                List<VendaDTO> listVenda;

                if (rbtNome.Checked && cboxPendente.Checked)
                {
                    listVenda = objVendaDAL.Buscar(txtConsulta.Text, "nomeependente");

                    foreach (VendaDTO objVenda in listVenda)
                    {
                        //Instancio a classe ListViewItem e vou adicionando o item e subitens
                        ListViewItem objListViewItem = new ListViewItem();

                        objListViewItem.Text = objVenda.Id.ToString();
                        objListViewItem.SubItems.Add(objVenda.Cliente.ToString());
                        objListViewItem.SubItems.Add(objVenda.Data.ToString());
                        objListViewItem.SubItems.Add(objVenda.Total.ToString());
                        objListViewItem.SubItems.Add(objVenda.Status.ToString());

                        objListCompra.Items.Add(objListViewItem);
                    }
                }
                else if (rbtNome.Checked && !cboxPendente.Checked)
                {
                    //objClienteTable.FillByName(objClienteDataTable, txtConsulta.Text);
                    listVenda = objVendaDAL.Buscar(txtConsulta.Text, "nome");

                    foreach (VendaDTO objVenda in listVenda)
                    {
                        //Instancio a classe ListViewItem e vou adicionando o item e subitens
                        ListViewItem objListViewItem = new ListViewItem();

                        objListViewItem.Text = objVenda.Id.ToString();
                        objListViewItem.SubItems.Add(objVenda.Cliente.ToString());
                        objListViewItem.SubItems.Add(objVenda.Data.ToString());
                        objListViewItem.SubItems.Add(objVenda.Total.ToString());
                        objListViewItem.SubItems.Add(objVenda.Status.ToString());

                        objListCompra.Items.Add(objListViewItem);
                    }
                }
                else
                {
                    listVenda = objVendaDAL.Buscar(txtConsulta.Text, "data");

                    foreach (VendaDTO objVenda in listVenda)
                    {
                        //Instancio a classe ListViewItem e vou adicionando o item e subitens
                        ListViewItem objListViewItem = new ListViewItem();

                        objListViewItem.Text = objVenda.Id.ToString();
                        objListViewItem.SubItems.Add(objVenda.Cliente.ToString());
                        objListViewItem.SubItems.Add(objVenda.Data.ToString());
                        objListViewItem.SubItems.Add(objVenda.Total.ToString());
                        objListViewItem.SubItems.Add(objVenda.Status.ToString());

                        objListCompra.Items.Add(objListViewItem);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDetalhar_Click(object sender, EventArgs e)
        {
            listVenda.Items.Clear();
            try
            {
                DetalheDAL objDetalheDAL = new DetalheDAL();

                List<DetalheDTO> listDetalhe = objDetalheDAL.GetById(txtDetalhar.Text);

                foreach (DetalheDTO objDetalhe in listDetalhe)
                {

                    //Instancio a classe ListViewItem e vou adicionando o item e subitens
                    ListViewItem objListViewItem = new ListViewItem();
                    //id
                    objListViewItem.Text = objDetalhe.Produto.ToString();
                    //nome
                    objListViewItem.SubItems.Add(objDetalhe.Texto);
                    //data
                    objListViewItem.SubItems.Add(objDetalhe.Quantidade.ToString());
                    //total
                    objListViewItem.SubItems.Add(objDetalhe.Preco.ToString());


                    listVenda.Items.Add(objListViewItem);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ou o Id informado não existe", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txtAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Thiago\Desktop\Thiago\Coti\Manager\Vendas\Banco.mdf;Integrated Security=True");

                string strConn = @"UPDATE Compra set status = @status WHERE Id = @Id";

                SqlCommand Cmd = new SqlCommand(strConn, Con);


                Cmd.Parameters.AddWithValue("@status", cboxStatus.Text);
                Cmd.Parameters.AddWithValue("@Id", txtDetalhar.Text);

                Con.Open();
                Cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("Registro Alterado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                objListCompra.Items.Clear();
                Consultar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ops, ocorreram erros!\n\nPreencha os campos e tente novamente",
                                      "Mensagem : ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void rbtnData_CheckedChanged(object sender, EventArgs e)
        {
            cboxPendente.Checked = false;
            cboxPendente.Visible = false;
            txtConsulta.Visible = true;
            monthCalendar1.Visible = true;
            txtCalendario.Visible = true;
        }

        private void rbtNome_CheckedChanged(object sender, EventArgs e)
        {
            cboxPendente.Visible = true;
            txtConsulta.Text = string.Empty;
            txtConsulta.Visible = true;
            monthCalendar1.Visible = false;
            txtCalendario.Visible = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtConsulta.Text = monthCalendar1.SelectionRange.Start.ToString("dd/MM/yyyy");
            monthCalendar1.Visible = false;
        }

        private void txtCalendario_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = !(monthCalendar1.Visible);
        }
    }
}
