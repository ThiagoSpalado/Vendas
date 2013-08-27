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

        #region Eventos

        private void frmConsultarClientes_Load(object sender, EventArgs e)
        {
            txtConsulta.Focus();
        }

        //private void rbtCidade_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rbtCidade.Checked)
        //    {
        //        txtConsulta.Text = string.Empty;
        //        txtConsulta.Focus();
        //    }
        //}

        //private void rbtNome_CheckedChanged(object sender, EventArgs e)
        //{
        //    //Se o RadioButton Nome estiver checado, limpo o campo txtConsulta e passo o foco a ele
        //    if (rbtNome.Checked)
        //    {
        //        txtConsulta.Text = string.Empty;
        //        txtConsulta.Focus();
        //    }
        //}

        //private void rbtStatus_CheckedChanged(object sender, EventArgs e)
        //{
        //    //Se o RadioButton Status estiver checado, ativo os RadioButtons, desabilito o txtConsulta e checo o RadioButton Ativo
        //    if (rbtStatus.Checked)
        //    {
        //        rbtAtivo.Visible = true;
        //        rbtInativo.Visible = true;
        //        txtConsulta.Enabled = false;
        //        rbtAtivo.Checked = true;
        //    }
        //    else
        //    {
        //        rbtAtivo.Visible = false;
        //        rbtInativo.Visible = false;
        //        txtConsulta.Enabled = true;
        //    }
        //}

        #endregion

        protected void Consultar()
        {
            try
            {
                PessoaDAL objPessoaDal = new PessoaDAL();

                if (!cbAtivo.Checked)
                {
                    List<PessoaDTO> lstPessoa = objPessoaDal.Buscar(txtConsulta.Text,"nome");

                    foreach (PessoaDTO objPessoa in lstPessoa)
                    {
                        //Instancio a classe ListViewItem e vou adicionando o item e subitens
                        ListViewItem objListViewItem = new ListViewItem();
                        //id
                        objListViewItem.Text = objPessoa.IdPessoa.ToString();
                        //nome
                        objListViewItem.SubItems.Add(objPessoa.Nome);
                        //endereço
                        objListViewItem.SubItems.Add(objPessoa.Endereco);
                        //bairro
                        objListViewItem.SubItems.Add(objPessoa.Bairro);
                        //estado
                        objListViewItem.SubItems.Add(objPessoa.Estado);
                        //telefone
                        objListViewItem.SubItems.Add(objPessoa.Telefone);
                        //ativo
                        objListViewItem.SubItems.Add(objPessoa.FlagAtiva.ToString().Replace("True", "Sim").Replace("False", "Não"));
                        //cep
                        objListViewItem.SubItems.Add(objPessoa.Cep);

                        objListViewItem.SubItems.Add(objPessoa.Telefone2);
                        //inadiplente
                        objListViewItem.SubItems.Add(objPessoa.FlagInadiplente.ToString().Replace("True", "Sim").Replace("False", "Não"));
                        //obs
                        objListViewItem.SubItems.Add(objPessoa.Observacao);
                        //email
                        objListViewItem.SubItems.Add(objPessoa.Email);

                        //No final adiciono os itens em meu ListView, passando como parâmetro o objListViewItem carregado
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
