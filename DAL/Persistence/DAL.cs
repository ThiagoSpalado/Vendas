using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class DAL
    {
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        public void OpenConnection()
        {
            //Data Source=(LocalDB)\v11.0;AttachDbFilename=T:\Thiago\Estudos\C#\Manager\Vendas\Banco.mdf;Integrated Security=True
            //Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Manager\Vendas\Banco.mdf;Integrated Security=True
            //Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Thiago\Desktop\Thiago\Coti\Manager\Vendas\Banco.mdf;Integrated Security=True
            Con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Git\Vendas\Vendas\Banco.mdf;Integrated Security=True");
            Con.Open();
        }

        public void CloseConnection()
        {
            if (Con != null)
            {
                Con.Close();
            }
        }
    }
}
