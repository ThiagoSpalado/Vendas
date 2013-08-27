using Vendas.Cliente;
using Vendas.Produto;
using Vendas.Venda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsbtnClientes_Click(object sender, EventArgs e)
        {
            Principal_Clientes objFrmClientes = new Principal_Clientes();
            objFrmClientes.ShowDialog();
        }

        private void tsbProduto_Click(object sender, EventArgs e)
        {
            Principal_Produto objPro = new Principal_Produto();
            objPro.ShowDialog();
        }

        private void tsbVendas_Click(object sender, EventArgs e)
        {
            Vendas_Principal objVendas = new Vendas_Principal();
            objVendas.ShowDialog();
        }
    }
}
