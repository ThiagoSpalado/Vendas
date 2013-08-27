using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Persistence
{
    public class DetalheDAL : DAL
    {

        public List<DetalheDTO> GetById(string id)
        {
            List<DetalheDTO> listDetalhe = new List<DetalheDTO>();

            try
            {
                OpenConnection();

                string strConn;
                string codRef = "";

                strConn = @"SELECT * from Compra WHERE Id = @Id";

                Cmd = new SqlCommand(strConn, Con);

                Cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(id));
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    codRef = Dr["CodReferencia"].ToString();
                }

                if (codRef != "")
                {
                    CloseConnection();
                    OpenConnection();
                }                

                strConn = @"SELECT * from ViewDetalhe WHERE CodReferencia = @CodReferencia";

                Cmd = new SqlCommand(strConn, Con);

                Cmd.Parameters.AddWithValue("@CodReferencia", codRef);
                Dr = Cmd.ExecuteReader();

                while (Dr.Read())
                {
                    DetalheDTO objDetalhe = new DetalheDTO();

                    objDetalhe.Produto = Dr["Produto"].ToString();
                    objDetalhe.Quantidade = Dr["Quantidade"].ToString();
                    objDetalhe.Preco = Dr["Preco"].ToString();
                    objDetalhe.Texto = Dr["Texto"].ToString();

                    listDetalhe.Add(objDetalhe);
                }

                return listDetalhe;
            }
            catch(Exception ex)
            {
                return listDetalhe;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
