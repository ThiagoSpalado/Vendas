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

namespace Vendas.Cliente
{
    public partial class ConsultarClientes : Form
    {
        public ConsultarClientes()
        {
            InitializeComponent();
        }

        #region Botões

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            lsvDados.Items.Clear();
            Consultar();
        }

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void frmConsultarClientes_Load(object sender, EventArgs e)
        {
            txtConsulta.Focus();
        }

        protected void Consultar()
        {
            try
            {
                PessoaDAL objPessoaDal = new PessoaDAL();

                if (!cbAtivo.Checked)
                {
                    List<PessoaDTO> lstPessoa = objPessoaDal.Buscar(txtConsulta.Text, "nome");

                    foreach (PessoaDTO objPessoa in lstPessoa)
                    {
                        //Instancio a classe ListViewItem e vou adicionando o item e subitens
                        ListViewItem objListViewItem = new ListViewItem();

                        objListViewItem.Text = objPessoa.IdPessoa.ToString();

                        objListViewItem.SubItems.Add(objPessoa.Nome);
                        objListViewItem.SubItems.Add(objPessoa.Endereco);
                        objListViewItem.SubItems.Add(objPessoa.Bairro);
                        objListViewItem.SubItems.Add(objPessoa.Estado);
                        objListViewItem.SubItems.Add(objPessoa.Telefone);
                        objListViewItem.SubItems.Add(objPessoa.FlagAtiva.ToString().Replace("True", "Sim").Replace("False", "Não"));
                        objListViewItem.SubItems.Add(objPessoa.Cep);
                        objListViewItem.SubItems.Add(objPessoa.Telefone2);
                        objListViewItem.SubItems.Add(objPessoa.FlagInadiplente.ToString().Replace("True", "Sim").Replace("False", "Não"));
                        objListViewItem.SubItems.Add(objPessoa.Observacao);
                        objListViewItem.SubItems.Add(objPessoa.Email);

                        lsvDados.Items.Add(objListViewItem);
                    }
                }
                else
                {
                    List<PessoaDTO> lstPessoa = objPessoaDal.Buscar(txtConsulta.Text, "nomeeativo");

                    foreach (PessoaDTO objPessoa in lstPessoa)
                    {

                        ListViewItem objListViewItem = new ListViewItem();

                        objListViewItem.Text = objPessoa.IdPessoa.ToString();
                        objListViewItem.SubItems.Add(objPessoa.Nome);
                        objListViewItem.SubItems.Add(objPessoa.Endereco);
                        objListViewItem.SubItems.Add(objPessoa.Bairro);
                        objListViewItem.SubItems.Add(objPessoa.Estado);
                        objListViewItem.SubItems.Add(objPessoa.Telefone);
                        objListViewItem.SubItems.Add(objPessoa.FlagAtiva.ToString().Replace("True", "Sim").Replace("False", "Não"));
                        objListViewItem.SubItems.Add(objPessoa.Cep);
                        objListViewItem.SubItems.Add(objPessoa.Telefone2);
                        objListViewItem.SubItems.Add(objPessoa.FlagInadiplente.ToString().Replace("True", "Sim").Replace("False", "Não"));
                        objListViewItem.SubItems.Add(objPessoa.Observacao);
                        objListViewItem.SubItems.Add(objPessoa.Email);

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
