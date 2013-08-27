using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class VendaDAL : DAL
    {
        public bool Salvar(VendaDTO venda)
        {
            try
            {
                OpenConnection();

                string strConn = "INSERT INTO ViewVenda (Id , cliente , Data , Total , status)" +
                                     "VALUES (@Id , @cliente , @Data , @Total , @status)";

                Cmd = new SqlCommand(strConn, Con);

                Cmd.Parameters.AddWithValue("@Id", venda.Id);
                Cmd.Parameters.AddWithValue("@cliente ", venda.Cliente);
                Cmd.Parameters.AddWithValue("@Data ", venda.Data);
                Cmd.Parameters.AddWithValue("@Total ", venda.Total);
                Cmd.Parameters.AddWithValue("@status ", venda.Status);

                return Cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void ExcluirEditar(VendaDTO venda, string opcao)
        {
            try
            {
                OpenConnection();

                string strConn = "";

                if (opcao.ToLower() == "editar")
                {
                    strConn = @"UPDATE ViewVenda set Data = @Data, Total = @Total, 
                                            Cliente = @Cliente, Status = @Status,
                                            WHERE Id = @Id";
                }
                else
                {
                    strConn = @"DELETE from ViewVenda WHERE Id = @Id";
                }

                Cmd = new SqlCommand(strConn, Con);

                Cmd.Parameters.AddWithValue("@Id", venda.Id);
                Cmd.Parameters.AddWithValue("@Cliente", venda.Cliente);
                Cmd.Parameters.AddWithValue("@Data", venda.Data);
                Cmd.Parameters.AddWithValue("@Total", venda.Total);
                Cmd.Parameters.AddWithValue("@Status", venda.Status);

                Cmd.ExecuteNonQuery();
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<VendaDTO> Buscar(string busca, string opcao)
        {
            List<VendaDTO> listVenda = new List<VendaDTO>();

            try
            {
                OpenConnection();

                string strConn;

                if (opcao.ToLower() == "data")
                {
                    strConn = @"SELECT * from ViewVenda WHERE Data = @Data";
                }
                else if (opcao.ToLower() == "nomeependente")
                {
                    strConn = @"SELECT * from ViewVenda WHERE Cliente like @Cliente AND Status = 'Pendente'";
                }
                else if (opcao.ToLower() == "nome")
                {
                    strConn = @"SELECT * from ViewVenda WHERE Cliente like @Cliente";
                }
                else
                {
                    return listVenda = GetAll();
                }

                Cmd = new SqlCommand(strConn, Con);

                Cmd.Parameters.AddWithValue("@Cliente", "%" + busca + "%");
                Cmd.Parameters.AddWithValue("@id", busca);
                Cmd.Parameters.AddWithValue("@Data", busca);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    VendaDTO objVenda = new VendaDTO();

                    objVenda.Id = Convert.ToInt32(Dr["Id"]);
                    objVenda.Cliente = Dr["Cliente"].ToString();
                    objVenda.Data = Dr["Data"].ToString();
                    objVenda.Total = Dr["Total"].ToString();
                    objVenda.Status = Dr["Status"].ToString();

                    listVenda.Add(objVenda);
                }
                return listVenda;
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<VendaDTO> GetAll()
        {
            List<VendaDTO> listVenda = new List<VendaDTO>();

            try
            {
                OpenConnection();

                string strConn = @"SELECT * from ViewVenda";

                Cmd = new SqlCommand(strConn, Con);

                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    VendaDTO objVenda = new VendaDTO();

                    objVenda.Id = Convert.ToInt32(Dr["Id"]);
                    objVenda.Cliente = Dr["Cliente"].ToString();
                    objVenda.Data = Dr["Data"].ToString();
                    objVenda.Total = Dr["Total"].ToString();
                    objVenda.Status = Dr["Status"].ToString();

                    listVenda.Add(objVenda);
                }
                return listVenda;
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<VendaDTO> GetAllPendentes()
        {
            List<VendaDTO> listVenda = new List<VendaDTO>();

            try
            {
                OpenConnection();

                string strConn = @"SELECT * from ViewVenda where status = 'Pendente'";

                Cmd = new SqlCommand(strConn, Con);

                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    VendaDTO objVenda = new VendaDTO();

                    objVenda.Id = Convert.ToInt32(Dr["Id"]);
                    objVenda.Cliente = Dr["Cliente"].ToString();
                    objVenda.Data = Dr["Data"].ToString();
                    objVenda.Total = Dr["Total"].ToString();
                    objVenda.Status = Dr["Status"].ToString();

                    listVenda.Add(objVenda);
                }
                return listVenda;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
